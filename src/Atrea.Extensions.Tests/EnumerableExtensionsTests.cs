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
        public async Task ForEachAsync_Correctly_Applies_Values_To_Enumeration()
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
                async t => { await Task.Run(() => { threadDictionary[t.Key] = 1; }); });

            // assert
            threadDictionary.Values.Should().NotContainNulls();
            threadDictionary.Values.Should().AllBeEquivalentTo(1);
        }

        [Test]
        public async Task ForEachAsync_With_Return_Generates_Expected_Number_Of_Values()
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

        [Test]
        public async Task AddRange_Adds_Expected_Number_Of_Items()
        {
            var bag = new ConcurrentBag<int> {1, 2, 3};

            var toAddA = new List<int> {4, 5, 6};
            var toAddB = new List<int> {7, 8, 9};

            var toAddLists = new List<List<int>> {toAddA, toAddB};

            var expectedBag = new ConcurrentBag<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};

            // Doing things async, to emulate real-world usage of ConcurrentBag.
            await toAddLists.ForEachAsync(
                toAddLists.Count,
                async t => { await Task.Run(() => bag.AddRange(t)); }
            );

            bag.Should().BeEquivalentTo(expectedBag);
        }

        private static IEnumerable<TestCaseData> IsInAscendingOrderIntegersTestCases
        {
            // ReSharper disable once UnusedMember.Local
            get
            {
                yield return new TestCaseData(
                    new List<int> {1, 2, 3, 4, 5},
                    true
                ).SetName("Already sorted list is evaluated as being in ascending order.");

                yield return new TestCaseData(
                    new List<int>(),
                    true
                ).SetName("Empty list is evaluated as being in ascending order.");

                yield return new TestCaseData(
                    new List<int> {1},
                    true
                ).SetName("List with just one item is evaluated as being in ascending order.");

                yield return new TestCaseData(
                    new List<int> {5, 4, 3, 2, 1},
                    false
                ).SetName("Descending ordered list is not considered to be in ascending order.");

                yield return new TestCaseData(
                    new List<int> {5, 1, 4, 2, 3},
                    false
                ).SetName("Randomized list is not considered to be in ascending order.");
            }
        }

        [TestCaseSource(nameof(IsInAscendingOrderIntegersTestCases))]
        public void IsInAscendingOrder(IEnumerable<int> items, bool expectedIsInAscendingOrder)
        {
            items.IsInAscendingOrder(i => i).Should().Be(expectedIsInAscendingOrder);
        }

        [Test]
        public void When_IsInAscendingOrder_Is_Called_With_Null_Source_Exception_Is_Thrown()
        {
            // arrange
            List<int> nullList = null;

            // act
            // ReSharper disable once ExpressionIsAlwaysNull
            Action act = () => nullList.IsInAscendingOrder(i => i);

            // assert
            act.Should().Throw<ArgumentNullException>();
        }

        [Test]
        public void Shuffle_Shuffles_Enumeration_Elements()
        {
            var integers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};
            var expectedIntegers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};

            integers.Should().BeInAscendingOrder();

            while (integers.IsInAscendingOrder(i => i))
            {
                integers.Shuffle();
            }

            integers.Should().NotBeInAscendingOrder();
            integers.Should().OnlyHaveUniqueItems();
            integers.Should().HaveSameCount(expectedIntegers);
            integers.Should().BeSubsetOf(expectedIntegers);
        }

        private static IEnumerable<TestCaseData> CombinationsTestCases
        {
            // ReSharper disable once UnusedMember.Local
            get
            {
                yield return new TestCaseData(
                    new List<int> {1, 2, 3, 4, 5},
                    3,
                    new List<int[]>
                    {
                        new[] {1, 2, 3},
                        new[] {1, 2, 4},
                        new[] {1, 2, 5},
                        new[] {1, 3, 4},
                        new[] {1, 3, 5},
                        new[] {1, 4, 5},
                        new[] {2, 3, 4},
                        new[] {2, 3, 5},
                        new[] {2, 4, 5},
                        new[] {3, 4, 5}
                    }
                ).SetName("Combinations of combination size three produces expected results.");

                yield return new TestCaseData(
                    new List<int> {1, 2, 3, 4, 5},
                    2,
                    new List<int[]>
                    {
                        new[] {1, 2},
                        new[] {1, 3},
                        new[] {1, 4},
                        new[] {1, 5},
                        new[] {2, 3},
                        new[] {2, 4},
                        new[] {2, 5},
                        new[] {3, 4},
                        new[] {3, 5},
                        new[] {4, 5}
                    }
                ).SetName("Combinations of combination size two produces expected results.");

                yield return new TestCaseData(
                    new List<int> {1, 2, 3, 4, 5},
                    1,
                    new List<int[]>
                    {
                        new[] {1},
                        new[] {2},
                        new[] {3},
                        new[] {4},
                        new[] {5}
                    }
                ).SetName("Combinations of combination size one produces expected results.");

                yield return new TestCaseData(
                    new List<int> {1},
                    1,
                    new List<int[]> {new[] {1}}
                ).SetName("Single item in source enumeration results in single result list.");
            }
        }

        [TestCaseSource(nameof(CombinationsTestCases))]
        public void Combinations_Results_In_Expected_Combinations(
            IList<int> items,
            int combinationSize,
            List<int[]> expectedCombinations)
        {
            var combinations = items.Combinations(combinationSize);

            combinations.Should().BeEquivalentTo(expectedCombinations);
        }

        [Test]
        public void Combinations_Throws_Exception_When_Combination_Size_Is_Greater_Than_Enumerable_Count()
        {
            // arrange
            var items = new List<int> {1};

            // act
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action act = () => items.Combinations(5).ToList();

            // assert
            act.Should().Throw<ArgumentException>()
                .WithMessage("List length can't be less than number of selected elements");
        }

        [Test]
        public void Combinations_Throws_Exception_When_Combination_Size_Is_Less_Than_One()
        {
            // arrange
            var items = new List<int> {1};

            // act
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action act = () => items.Combinations(0).ToList();

            // assert
            act.Should().Throw<ArgumentException>().WithMessage("Number of selected elements can't be less than 1");
        }

        public static IEnumerable<TestCaseData> CartesianProductTestCases
        {
            get
            {
                yield return new TestCaseData(
                    new List<List<int>>
                    {
                        new List<int> {1},
                        new List<int> {2, 3},
                        new List<int> {4, 5, 6}
                    },
                    new List<List<int>>
                    {
                        new List<int> {1, 2, 4},
                        new List<int> {1, 2, 5},
                        new List<int> {1, 2, 6},
                        new List<int> {1, 3, 4},
                        new List<int> {1, 3, 5},
                        new List<int> {1, 3, 6}
                    }
                ).SetName("Cartesian product is generated from a list of lists containing values.");

                yield return new TestCaseData(
                    new List<List<int>>
                    {
                        new List<int> {1},
                        new List<int>(),
                        new List<int> {4, 5, 6}
                    },
                    new List<List<int>>
                    {
                        new List<int> {1, 4},
                        new List<int> {1, 5},
                        new List<int> {1, 6}
                    }
                ).SetName("Cartesian product is generated from a list of lists containing an empty list.");

                yield return new TestCaseData(
                    new List<List<int>>
                    {
                        new List<int>(),
                        new List<int>(),
                        new List<int>()
                    },
                    new List<List<int>>()
                ).SetName("All empty sequences produce empty cartesian product.");

                yield return new TestCaseData(
                    new List<List<int>>
                    {
                        new List<int> {1, 2, 3},
                        new List<int>(),
                        new List<int>()
                    },
                    new List<List<int>>
                    {
                        new List<int> {1},
                        new List<int> {2},
                        new List<int> {3}
                    }
                ).SetName("All empty sequences produce empty cartesian product.");
            }
        }

        [Test]
        [TestCaseSource(nameof(CartesianProductTestCases))]
        public void CartesianProduct_Creates_The_Expected_Cartesian_Product(
            IEnumerable<IEnumerable<int>> items,
            IEnumerable<IEnumerable<int>> expectedResult)
        {
            var result = items.CartesianProduct().ToList();

            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}