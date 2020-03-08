using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Atrea.Extensions
{
    public static class StringExtensions
    {
        private static readonly Regex WhitespaceRegex = new Regex(@"[\s]+", RegexOptions.Compiled);
        private static readonly Regex WhitespaceNoNewlinesRegex = new Regex(@"[^\S\r\n]+", RegexOptions.Compiled);

        /// <summary>
        ///     Compress all whitespace into single spaces, including newlines.
        /// </summary>
        /// <param name="source">The string to compress</param>
        /// <returns>The compressed string</returns>
        public static string CompressWhiteSpace(this string source)
        {
            return WhitespaceRegex.Replace(source, " ");
        }

        /// <summary>
        ///     Compress all whitespace into single spaces, keeping new lines.
        /// </summary>
        /// <param name="source">The string to compress</param>
        /// <returns>The compressed string</returns>
        public static string CompressWhiteSpaceKeepNewLines(this string source)
        {
            return WhitespaceNoNewlinesRegex.Replace(source, " ");
        }

        /// <summary>
        ///     Capitalizes the first letter of a given string.
        /// </summary>
        /// <param name="source">The string to capitalize</param>
        /// <returns>The capitalized string</returns>
        public static string Capitalize(this string source)
        {
            if (string.IsNullOrEmpty(source))
            {
                return source;
            }

            if (char.IsUpper(source[0]))
            {
                return source;
            }

            var charArray = source.ToCharArray();

            charArray[0] = char.ToUpper(charArray[0]);

            return new string(charArray);
        }

        /// <summary>
        ///     Un-capitalizes the first letter of a given string.
        /// </summary>
        /// <param name="source">The source string to un-capitalize</param>
        /// <returns>The un-capitalized string</returns>
        public static string UnCapitalize(this string source)
        {
            if (string.IsNullOrEmpty(source))
            {
                return source;
            }

            if (char.IsLower(source[0]))
            {
                return source;
            }

            var charArray = source.ToCharArray();

            charArray[0] = char.ToLower(charArray[0]);

            return new string(charArray);
        }

        /// <summary>
        ///     In contrast to string.Replace, this will only replace whole words. For example: 
        ///     Using this method on the string "test testing test" and passing "test" as oldValue 
        ///     and "text", this will return the string "text testing text", whereas 
        ///     string.Replace would return "text texting text."
        /// </summary>
        /// <param name="source">The source string to replace words in</param>
        /// <param name="oldValue">The word in the string we want to replace</param>
        /// <param name="newValue">The replacement word to use</param>
        /// <returns></returns>
        public static string ReplaceWord(this string source, string oldValue, string newValue)
        {
            if (string.IsNullOrEmpty(source))
            {
                return source;
            }

            var pattern = string.Concat(@"\b", oldValue, @"\b");

            return Regex.Replace(source, pattern, newValue);
        }

        /// <summary>
        ///     List of numeric text to be used in the ContainsNumericText extension below.
        /// </summary>
        private static readonly List<string> NumericStrings = new List<string>
        {
            "one",
            "two",
            "three",
            "four",
            "five",
            "six",
            "seven",
            "eight",
            "nine",
            "ten",
            "eleven",
            "twelve",
            "thirteen",
            "fourteen",
            "fifteen",
            "sixteen",
            "seventeen",
            "eighteen",
            "nineteen",
            "twenty",
            "thirty",
            "forty",
            "fifty",
            "sixty",
            "seventy",
            "eighty",
            "ninety",
            "hundred",
            "thousand",
            "million",
            "billion",
            "trillion"
        };

        /// <summary>
        ///     Regex to be used in the string extension ContainsNumericText below.
        /// </summary>
        private static readonly Regex NumericRegexer = new Regex(
            @"\b(" + string.Join("|",
                NumericStrings.Select(Regex.Escape).ToArray()) + @"\b)|([0-9]+)",
            RegexOptions.Compiled | RegexOptions.IgnoreCase
        );

        /// <summary>
        ///     Checks whether the source string contains numeric text.
        /// 
        ///     Example strings that would return true:
        ///
        ///         "One way to shop"
        ///         "A billion things to do"
        ///         "There are 4 things"
        ///         "There are actually 3.5 things"
        /// </summary>
        /// <param name="source">The source string to check for numeric text</param>
        /// <returns>Whether the string contains numeric text</returns>
        public static bool ContainsNumericText(this string source)
        {
            return NumericRegexer.IsMatch(source);
        }
    }
}