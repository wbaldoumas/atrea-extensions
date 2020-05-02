using FluentAssertions;
using NUnit.Framework;

namespace Atrea.Extensions.Tests
{
    [TestFixture]
    public class StringExtensionTests
    {
        [Test]
        [TestCase("word second", "Word second")]
        [TestCase("Word second", "Word second")]
        [TestCase(null, null)]
        [TestCase("", "")]
        public void Capitalize(string inString, string expected)
        {
            Assert.AreEqual(expected, inString.Capitalize());
        }

        [Test]
        [TestCase("    ", " ")]
        [TestCase("  \t\n\r\v  ", " ")]
        [TestCase("  ack  \t\n  foo\r\vbaz  ", " ack foo baz ")]
        public void CompressWhiteSpace(string sourceString, string expectedResult)
        {
            var result = sourceString.CompressWhiteSpace();

            result.Should().Be(expectedResult);
        }

        [Test]
        [TestCase("    ", " ")]
        [TestCase("  \t\n\r\v  ", " \n\r ")]
        [TestCase("  ack  \t\n  foo\r\vbaz", " ack \n foo\r baz")]
        public void CompressWhiteSpaceKeepNewLines(string inString, string expected)
        {
            Assert.AreEqual(expected, inString.CompressWhiteSpaceKeepNewLines());
        }

        [Test]
        [TestCase("test 1 test")]
        [TestCase("1 test 1")]
        [TestCase("test 123456789 test")]
        [TestCase("123456789 test 123456789")]
        [TestCase("test 1.1 test")]
        [TestCase("1.1 test 1.1")]
        [TestCase("test 123456789.987654321 test")]
        [TestCase("123456789.987654321 test 123456789.987654321")]
        [TestCase("test .000001")]
        [TestCase("test one test")]
        [TestCase("one test one")]
        [TestCase("twenty test")]
        [TestCase("many thousand")]
        [TestCase("eleven billion")]
        [TestCase("ONE THOUSAND")]
        [TestCase("5.")]
        public void ContainsNumericText(string input)
        {
            Assert.IsTrue(input.ContainsNumericText());
        }

        [Test]
        [TestCase("bizarre bird bookcase")]
        [TestCase("crazy cat cabinet")]
        [TestCase("drab dog doorhinge")]
        [TestCase("eerie elephant end-table")]
        [TestCase("finnicky frog fireplace")]
        [TestCase("titanic turtle table")]
        [TestCase("super snake sauna")]
        public void DoesNotContainNumericText(string input)
        {
            Assert.IsFalse(input.ContainsNumericText());
        }

        [Test]
        [TestCase("a a", "b b")]
        [TestCase("aaa a aa", "aaa b aa")]
        [TestCase(null, null)]
        [TestCase("", "")]
        public void ReplaceWholeWord(string inString, string expected)
        {
            Assert.AreEqual(expected, inString.ReplaceWord("a", "b"));
        }

        [Test]
        [TestCase("word second", "word second")]
        [TestCase("Word second", "word second")]
        [TestCase(null, null)]
        [TestCase("", "")]
        public void Uncapitalize(string inString, string expected)
        {
            Assert.AreEqual(expected, inString.UnCapitalize());
        }
    }
}