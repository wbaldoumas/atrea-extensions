using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace Atrea.Extensions.Tests
{
    [TestFixture]
    public class EnumerableExtensionTest
    {
        [Test]
        public void BatchBy_With_Zero_Batch_Size_Results_In_Exception()
        {
            IEnumerable<string> enumerable = new List<string>();

            Assert.Throws<ArgumentException>(
                () =>
                {
                    var foo = enumerable.BatchBy(0).ToList();
                    Assert.IsNotNull(foo);
                });
        }

        [Test]
        public void BatchBy_With_One_Batch_Size_Results_In_One_Batch()
        {
            var list = new List<string>();

            const int batchSize = 1;
            const int count = 12;

            for (var i = 0; i < count; i++)
            {
                list.Add("item");
            }

            var batches = list.BatchBy(batchSize);

            batches.Count().Should().Be(count);
        }

        [Test]
        public void BatchBy_With_Count_One_More_Than_Batch_Size_Results_In_Two_Batches()
        {
            var list = new List<string>();

            const int batchSize = 10;
            const int count = batchSize + 1;

            for (var i = 0; i < count; i++)
            {
                list.Add("entry");
            }

            var batches = list.BatchBy(batchSize).ToArray();

            batches.Length.Should().Be(2);
            batches.Sum(x => x.Count()).Should().Be(list.Count);
        }

        [Test]
        public void BatchBy_With_Count_Equal_To_Batch_Size_Results_In_One_Batch()
        {
            var list = new List<string>();
            const int batchSize = 10;
            const int count = batchSize;
            for (var i = 0; i < count; i++)
            {
                list.Add("entry");
            }

            var batches = list.BatchBy(batchSize).ToArray();

            batches.Length.Should().Be(1);
            batches.Sum(x => x.Count()).Should().Be(list.Count);
        }

        [Test]
        public async Task ForEachAsync_Runs_On_The_Expected_Number_Of_Unique_Threads()
        {
            // arrange
            var threadDictionary = new ConcurrentDictionary<string, int?>();

            for (var i = 0; i < 5; ++i)
            {
                threadDictionary.TryAdd($"string{i}", null);
            }

            // act
            await threadDictionary.ForEachAsync(
                threadDictionary.Count,
                async t =>
                {
                    var threadId = Thread.CurrentThread.ManagedThreadId;

                    await Task.Run(() => { threadDictionary[t.Key] = threadId; });
                });

            // assert
            foreach (var value in threadDictionary.Values)
            {
                value.Should().NotBeNull();
            }

            threadDictionary.Values.Should().OnlyHaveUniqueItems();
        }

        [Test]
        public async Task ForEachAsync_With_Return_Runs_On_The_Expected_Number_Of_Unique_Threads()
        {
            // arrange
            var strings = new List<string>
            {
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty
            };

            // act
            var threadIds = (await strings.ForEachAsync(
                        strings.Count,
                        async s =>
                        {
                            var threadId = Thread.CurrentThread.ManagedThreadId;

                            await Task.Run(() => { s += $"string{threadId}"; });

                            return threadId;
                        }
                    )
                ).ToList();

            // assert
            threadIds.Should().HaveSameCount(strings);
            threadIds.Should().OnlyHaveUniqueItems();
        }

        [Test]
        public async Task AddRange_Adds_Expected_Number_Of_Items()
        {
            var bag = new ConcurrentBag<int> {1, 2, 3};

            var toAdd1 = new List<int> {4, 5, 6};
            var toAdd2 = new List<int> {7, 8, 9};

            var toAddLists = new List<List<int>> {toAdd1, toAdd2};

            var expectedBag = new ConcurrentBag<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};

            // Do things async, to emulate real-world usage.
            await toAddLists.ForEachAsync(
                toAddLists.Count,
                async t => { await Task.Run(() => bag.AddRange(t)); }
            );

            bag.Should().BeEquivalentTo(expectedBag);
        }

        [Test]
        public void None()
        {
            new int[0].None().Should().BeTrue();
            new[] {1}.None().Should().BeFalse();
        }

        [Test]
        public void ForEachWithIndex_Produces_Expected_Result()
        {
            var strings = new[] {"string0", "string1", "string2"};
            var result = new Dictionary<int, string>();

            strings.ForEachWithIndex((s, i) => result.Add(i, s));

            result.Should().HaveSameCount(strings);
            result.Keys.Should().BeEquivalentTo(new[] {0, 1, 2});
            result.Values.Should().BeEquivalentTo(strings);
        }

        [Test]
        public void SelectWithIndex_Produces_Expected_Result()
        {
            var strings = new[] {"string0", "string1", "string2"};

            var result = strings.SelectWithIndex((s, i) => new Tuple<string, int>(s, i)).ToList();

            for (var i = 0; i < 3; i++)
            {
                result.Should().Contain(new Tuple<string, int>(strings[i], i));
            }
        }

        [Test]
        public void DistinctBy_With_Two_Distinct_Values_Produces_Two_Distinct_Results()
        {
            var tuples = new[]
            {
                new Tuple<int, string>(1, "value1"),
                new Tuple<int, string>(1, "value2"),
                new Tuple<int, string>(2, "value1")
            };

            var results = tuples.DistinctBy(t => t.Item1).Select(t => t.Item2).ToList();

            results.Count.Should().Be(2);
            results.All(r => r == "value1").Should().BeTrue();
        }

        [Test]
        public void When_Empty_DistinctBy_Should_Return_Empty_Result()
        {
            new int[0].DistinctBy(i => i).None().Should().BeTrue();
        }

        [Test]
        public void When_Null_DistinctBy_Should_Return_Empty_Result()
        {
            List<Tuple<int, string>> tuples = null;

            // ReSharper disable once ExpressionIsAlwaysNull
            tuples.DistinctBy(t => t.Item1).None().Should().BeTrue();
        }
    }
}