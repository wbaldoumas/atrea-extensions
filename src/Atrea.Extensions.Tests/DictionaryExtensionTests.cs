using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace Atrea.Extensions.Tests
{
    [TestFixture]
    public class DictionaryExtensionTests
    {
        [Test]
        public void When_Merge_Is_Called_With_NonOverlapping_Keys_The_Two_Dictionaries_Are_Merged()
        {
            // arrange
            const string keyA = "a";
            const int valueA = 1;

            const string keyB = "b";
            const int valueB = 2;

            const string keyC = "c";
            const int valueC = 3;

            const string keyD = "d";
            const int valueD = 4;

            var dictionaryA = new Dictionary<string, int>
            {
                {keyA, valueA},
                {keyB, valueB}
            };

            var dictionaryB = new Dictionary<string, int>
            {
                {keyC, valueC},
                {keyD, valueD}
            };

            var expectedDictionary = new Dictionary<string, int>
            {
                {keyA, valueA},
                {keyB, valueB},
                {keyC, valueC},
                {keyD, valueD}
            };

            // act
            var result = dictionaryA.Merge(dictionaryB);

            // assert
            result.Should().BeEquivalentTo(expectedDictionary);
        }

        [Test]
        public void When_Merge_Is_Called_With_Empty_Dictionary_The_Original_Is_Returned_Unmodified()
        {
            // arrange
            const string keyA = "a";
            const int valueA = 1;

            const string keyB = "b";
            const int valueB = 2;

            var dictionaryA = new Dictionary<string, int>
            {
                {keyA, valueA},
                {keyB, valueB}
            };

            var dictionaryB = new Dictionary<string, int>();

            var expectedDictionary = new Dictionary<string, int>
            {
                {keyA, valueA},
                {keyB, valueB}
            };

            // act
            var result = dictionaryA.Merge(dictionaryB);

            // assert
            result.Should().BeEquivalentTo(expectedDictionary);
        }

        [Test]
        public void When_Merge_Is_Called_With_Null_The_Original_Dictionary_Is_Returned_Unmodified()
        {
            // arrange
            const string keyA = "a";
            const int valueA = 1;

            const string keyB = "b";
            const int valueB = 2;

            var dictionaryA = new Dictionary<string, int>
            {
                {keyA, valueA},
                {keyB, valueB}
            };

            var expectedDictionary = new Dictionary<string, int>
            {
                {keyA, valueA},
                {keyB, valueB}
            };

            // act
            var result = dictionaryA.Merge(null);

            // assert
            result.Should().BeEquivalentTo(expectedDictionary);
        }

        [Test]
        public void When_ToMultiLookup_Is_Called_It_Generates_The_Expected_Dictionary()
        {
            // arrange
            var items = new List<int> {1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5};

            var expectedResult = new Dictionary<string, List<int>>
            {
                {"1", new List<int> {1}},
                {"2", new List<int> {2, 2}},
                {"3", new List<int> {3, 3, 3}},
                {"4", new List<int> {4, 4, 4, 4}},
                {"5", new List<int> {5, 5, 5, 5, 5}}
            };

            // act
            var result = items.ToMultiLookup(item => $"{item}");

            // assert
            result.Should().BeEquivalentTo(expectedResult);
        }

        [Test]
        public void When_ToMultiLookup_Is_Called_On_Empty_Collection_Empty_Dictionary_Is_Generated()
        {
            // arrange
            // ReSharper disable once CollectionNeverUpdated.Local
            var items = new List<int>();

            // act
            var result = items.ToMultiLookup(item => $"{item}");

            // assert
            result.Should().BeEmpty();
        }

        [Test]
        public void When_ToMultiLookup_Is_Called_On_Null_Collection_Null_Is_Returned()
        {
            // arrange
            List<int> items = null;

            // ReSharper disable once ExpressionIsAlwaysNull
            var result = items.ToMultiLookup(item => $"{item}");

            // assert
            result.Should().BeNull();
        }

        [Test]
        public void When_ToReadableString_Is_Called_The_Expected_String_Is_Generated()
        {
            // arrange
            var dictionary = new Dictionary<string, int>
            {
                {"a", 1},
                {"b", 2}
            };

            const string expectedResult = "{ { a => 1 }, { b => 2 } }";

            // act
            var result = dictionary.ToReadableString();

            // assert
            result.Should().Be(expectedResult);
        }

        [Test]
        public void When_ToReadableString_Is_Called_With_Empty_Dictionary_Empty_String_Is_Generated()
        {
            // arrange
            // ReSharper disable once CollectionNeverUpdated.Local
            var dictionary = new Dictionary<string, int>();

            // act
            var result = dictionary.ToReadableString();

            // assert
            result.Should().Be(string.Empty);
        }

        [Test]
        public void When_ToReadableString_Is_Called_With_Null_Dictionary_Generated_String_Correctly_Depicts_Null()
        {
            // arrange
            Dictionary<string, int> dictionary = null;

            const string expectedResult = "{null}";

            // act
            // ReSharper disable once ExpressionIsAlwaysNull
            var result = dictionary.ToReadableString();

            // assert
            result.Should().Be(expectedResult);
        }
    }
}