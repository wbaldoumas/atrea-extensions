using System;
using System.Collections.Generic;
using System.Linq;

namespace Atrea.Extensions
{
    /// <summary>
    ///     A set of useful extension methods related to the <see cref="IDictionary{TKey,TValue}" /> type.
    /// </summary>
    public static class DictionaryExtensions
    {
        /// <summary>
        ///     Merge the new dictionary into the source directory, overwriting on duplicate keys.
        ///     If the new dictionary is null or empty, the first dictionary is returned unmodified.
        ///     If the source dictionary is null or empty, the new dictionary is returned unmodified.
        /// </summary>
        /// <typeparam name="TKey">The dictionary key type</typeparam>
        /// <typeparam name="TValue">The dictionary value type</typeparam>
        /// <param name="source">The dictionary of old values</param>
        /// <param name="newDictionary">The dictionary with new values</param>
        /// <returns>
        ///     A merged dictionary whose keys are a union of the keys of the two dictionaries, and
        ///     whose values are drawn from the second dictionary if they are present, otherwise the first.
        /// </returns>
        public static IDictionary<TKey, TValue> Merge<TKey, TValue>(
            this IDictionary<TKey, TValue> source,
            IDictionary<TKey, TValue> newDictionary)
        {
            if (source is null)
            {
                return newDictionary;
            }

            if (newDictionary is null)
            {
                return source;
            }

            if (source.None())
            {
                return newDictionary;
            }

            if (newDictionary.None())
            {
                return source;
            }

            var toReturn = new Dictionary<TKey, TValue>();

            foreach (var key in source.Keys.Concat(newDictionary.Keys).Distinct())
            {
                toReturn[key] = newDictionary.ContainsKey(key) ? newDictionary[key] : source[key];
            }

            return toReturn;
        }

        /// <summary>
        ///     Create a lookup by key that maps to multiple items per key.
        /// </summary>
        /// <typeparam name="TKey">The dictionary key type</typeparam>
        /// <typeparam name="TValue">The source item type</typeparam>
        /// <param name="source">The source enumeration</param>
        /// <param name="keyFunction">The function to map items to their keys</param>
        /// <returns>A dictionary mapping keys to an enumeration of source items with that key</returns>
        public static Dictionary<TKey, List<TValue>> ToMultiLookup<TKey, TValue>(
            this IEnumerable<TValue> source,
            Func<TValue, TKey> keyFunction)
        {
            if (source is null)
            {
                return null;
            }

            var toReturn = new Dictionary<TKey, List<TValue>>();

            foreach (var item in source)
            {
                var key = keyFunction(item);

                if (toReturn.ContainsKey(key))
                {
                    toReturn[key].Add(item);
                }
                else
                {
                    toReturn[key] = new List<TValue> { item };
                }
            }

            return toReturn;
        }

        /// <summary>
        ///     Creates a readable string value from a given dictionary.
        /// </summary>
        /// <typeparam name="TKey">The dictionary key type</typeparam>
        /// <typeparam name="TValue">The dictionary value type</typeparam>
        /// <param name="source">The dictionary being parsed into a string</param>
        /// <returns>A string parsed from the dictionary key => value pairs</returns>
        public static string ToReadableString<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> source)
        {
            if (source is null)
            {
                return "{null}";
            }

            var keyValuePairs = source.ToList();

            if (keyValuePairs.None())
            {
                return string.Empty;
            }

            var strings = keyValuePairs.Select(keyValuePair => $"{{ {keyValuePair.Key} => {keyValuePair.Value} }}");

            return "{ " + string.Join(", ", strings) + " }";
        }
    }
}