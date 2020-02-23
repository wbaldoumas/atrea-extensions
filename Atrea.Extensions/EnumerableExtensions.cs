using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Atrea.Extensions
{
    public static class EnumerableExtensions
    {
        /// <summary>
        ///     Batch items in an enumerable by batchSize.  Does not fully load the source enumeration
        ///     while making batches. Arrays are returned to optimize memory usage.  Implemented as
        ///     iterator for just-in-time creation.
        /// </summary>
        /// <typeparam name="T">The source enumeration type</typeparam>
        /// <param name="source">The source enumeration</param>
        /// <param name="batchSize">Number of elements by which to group items</param>
        /// <returns>An IEnumerable of lists</returns>
        public static IEnumerable<IEnumerable<T>> BatchBy<T>(this IEnumerable<T> source, int batchSize)
        {
            if (batchSize < 1)
            {
                throw new ArgumentException("Must provide a positive, non-zero batch size.");
            }

            T[] bucket = null;
            var count = 0;

            foreach (var item in source)
            {
                if (bucket == null)
                {
                    bucket = new T[batchSize];
                }

                bucket[count++] = item;

                if (count != batchSize)
                {
                    continue;
                }

                yield return bucket;

                bucket = null;
                count = 0;
            }

            if (bucket != null && count > 0)
            {
                yield return bucket.Take(count);
            }
        }

        /// <summary>
        ///     Process an enumeration in parallel, asynchronously, with a limit on simultaneous asynchronous tasks.
        /// </summary>
        /// <typeparam name="T">The source enumeration type</typeparam>
        /// <typeparam name="TOut">The result type</typeparam>
        /// <param name="source">The source enumeration</param>
        /// <param name="threads">The degree of parallelism to use</param>
        /// <param name="func">The asynchronous function to execute</param>
        /// <returns>A task to await for all processes to be complete</returns>
        public static async Task<IEnumerable<TOut>> ForEachAsync<T, TOut>(
            this IEnumerable<T> source,
            int threads,
            Func<T, Task<TOut>> func)
        {
            var partitions = Partitioner.Create(source).GetPartitions(threads);
            var results = new ConcurrentBag<TOut>();

            var tasks = partitions.Select(
                partition
                    => Task.Run(
                        () =>
                        {
                            using (partition)
                            {
                                while (partition.MoveNext())
                                {
                                    results.Add(func(partition.Current).Result);
                                }
                            }
                        })).ToList();

            await Task.WhenAll(tasks);

            return results;
        }

        /// <summary>
        ///     Process an enumeration in parallel, asynchronously, with a limit on simultaneous asynchronous tasks.
        /// </summary>
        /// <typeparam name="T">The source enumeration type</typeparam>
        /// <param name="source">The source enumeration</param>
        /// <param name="threads">The degree of parallelism to use</param>
        /// <param name="action">The asynchronous action to execute</param>
        /// <returns>A task to await for all processes to be complete</returns>
        public static async Task ForEachAsync<T>(
            this IEnumerable<T> source,
            int threads,
            Func<T, Task> action)
        {
            var partitions = Partitioner.Create(source).GetPartitions(threads);

            var tasks = partitions.Select(
                partition
                    => Task.Run(
                        async () =>
                        {
                            using (partition)
                            {
                                while (partition.MoveNext())
                                {
                                    await action(partition.Current);
                                }
                            }
                        })).ToList();

            await Task.WhenAll(tasks);
        }

        /// <summary>
        ///     Negation of standard Any() method.
        /// </summary>
        /// <typeparam name="T">The source enumeration type</typeparam>
        /// <param name="source">The source enumeration</param>
        /// <returns>Whether the enumeration is empty</returns>
        public static bool None<T>(this IEnumerable<T> source)
        {
            return !source.Any();
        }

        /// <summary>
        ///     Iterate over a list, returning both the index and the item.
        /// </summary>
        /// <typeparam name="T">The source enumeration type</typeparam>
        /// <param name="source">The source enumeration</param>
        /// <param name="action">A function taking an item and its index</param>
        public static void ForEachWithIndex<T>(this IList<T> source, Action<T, int> action)
        {
            var i = 0;

            foreach (var item in source)
            {
                action(item, i);
                i++;
            }
        }

        /// <summary>
        ///     Iterate over a list, projecting using both the index and the item, a la Select(...).
        /// </summary>
        /// <typeparam name="TIn">The source enumeration type</typeparam>
        /// <typeparam name="TOut">The projected type</typeparam>
        /// <param name="source">The source enumeration</param>
        /// <param name="lambda">A function taking an item and its index</param>
        public static IEnumerable<TOut> SelectWithIndex<TIn, TOut>(
            this IList<TIn> source,
            Func<TIn, int, TOut> lambda)
        {
            var i = 0;

            foreach (var item in source)
            {
                yield return lambda(item, i);
                i++;
            }
        }

        /// <summary>
        ///     Iterate over a enumeration, filtering out distinct items by property.
        /// </summary>
        /// <typeparam name="T">The source enumeration type</typeparam>
        /// <typeparam name="TKey">The selector type to filter on</typeparam>
        /// <param name="source">The source enumeration</param>
        /// <param name="selector">The selector to filter on</param>
        /// <returns>An IEnumerable of items that are distinct by the selector property</returns>
        public static IEnumerable<T> DistinctBy<T, TKey>(this IEnumerable<T> source, Func<T, TKey> selector)
        {
            if (source == null)
            {
                yield break;
            }

            var seenKeys = new HashSet<TKey>();

            foreach (var item in source)
            {
                if (seenKeys.Add(selector(item)))
                {
                    yield return item;
                }
            }
        }

        /// <summary>
        ///     Apply a side-effect function to each element of an enumerable.
        /// </summary>
        /// <typeparam name="T">The source enumeration type</typeparam>
        /// <param name="source">The source enumeration</param>
        /// <param name="action">The side-effect action to perform on T</param>
        /// <returns>The input sequence after having the action performed on each member</returns>
        public static IEnumerable<T> Apply<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source)
            {
                action(item);
                yield return item;
            }
        }

        /// <summary>
        ///     Extension to add multiple items at a time to a ConcurrentBag.
        /// </summary>
        /// <typeparam name="T">The source enumeration type</typeparam>
        /// <param name="source">The source enumeration</param>
        /// <param name="toAdd">An IEnumerable of elements to add</param>
        public static void AddRange<T>(this ConcurrentBag<T> source, IEnumerable<T> toAdd)
        {
            foreach (var item in toAdd)
            {
                source.Add(item);
            }
        }

        /// <summary>
        ///     Shuffles the source list.
        /// </summary>
        /// <typeparam name="T">The source enumeration type</typeparam>
        /// <param name="list">The source enumeration</param>
        public static void Shuffle<T>(this IList<T> list)
        {
            using var provider = new RNGCryptoServiceProvider();

            var count = list.Count;

            while (count > 1)
            {
                var box = new byte[1];

                do provider.GetBytes(box);
                while (!(box[0] < count * (byte.MaxValue / count)));

                var k = box[0] % count;
                count--;

                var value = list[k];

                list[k] = list[count];
                list[count] = value;
            }
        }

        /// <summary>
        ///     Creates and returns an enumeration of lists, which is every combinationSize size combination that
        ///     can be created from the source enumeration.
        /// </summary>
        /// <typeparam name="T">The source enumeration type</typeparam>
        /// <param name="source"></param>
        /// <param name="combinationSize"></param>
        /// <returns>An enumeration of lists, which is every combinationSize combination that can be created from the source enumeration</returns>
        public static IEnumerable<T[]> Combinations<T>(this IList<T> source, int combinationSize)
        {
            if (source.Count < combinationSize)
                throw new ArgumentException("List length can't be less than number of selected elements");
            if (combinationSize < 1)
                throw new ArgumentException("Number of selected elements can't be less than 1");

            var result = new T[combinationSize];

            foreach (var indexCombinations in Combinations(combinationSize, source.Count))
            {
                for (var i = 0; i < combinationSize; i++)
                {
                    result[i] = source[indexCombinations[i]];
                }

                yield return (T[])result.Clone();
            }
        }

        /// <summary>
        ///     Enumerate all possible combinationSize size combinations of an [0, 1, ..., maxIndex-1] array
        ///     in lexicographic order (first [0, 1, ..., combinationSize-1]).
        /// </summary>
        /// <param name="combinationSize"></param>
        /// <param name="maxIndex"></param>
        /// <returns>An enumeration of all possible combinationSize combinations of the specified array</returns>
        private static IEnumerable<int[]> Combinations(int combinationSize, int maxIndex)
        {
            var result = new int[combinationSize];
            var stack = new Stack<int>(combinationSize);

            stack.Push(0);

            while (stack.Count > 0)
            {
                var index = stack.Count - 1;
                var value = stack.Pop();

                while (value < maxIndex)
                {
                    result[index++] = value++;
                    stack.Push(value);
                    if (index != combinationSize) continue;
                    yield return (int[])result.Clone();
                    break;
                }
            }
        }
    }
}