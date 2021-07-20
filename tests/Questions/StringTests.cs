using NUnit.Framework;
using src.Questions.StringTest;

namespace tests.Questions {
    public class StringTests {
        // 20. Valid Parentheses
        // https://leetcode.com/problems/valid-parentheses/
        // Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
        // An input string is valid if:
        // Open brackets must be closed by the same type of brackets.
        // Open brackets must be closed in the correct order.
        [Test, Category ("StringTest")]
        public void ValidParenthesesTest () {
            // arrange
            var s = "{]}";
            var expected = false;
            // actual
            var actual = StringTest.IsValid (s);
            // assert
            Assert.AreEqual (actual, expected);
        }

        // 387. First Unique Character in a String
        // https://leetcode.com/problems/first-unique-character-in-a-string/
        // Given a string, find the first non-repeating character in it and return its index. If it doesn't exist, return -1.
        [Test, Category ("StringTest")]
        public void FirstUniqCharTest () {
            // arrange
            // var s = "leetcode";
            // var expected = 0;
            var s = "leetcode";
            var expected = 2;
            // actual
            var actual = StringTest.FirstUniqChar (s);
            // assert
            Assert.AreEqual (actual, expected);
        }

        // 13. Roman to Integer
        // https://leetcode.com/problems/roman-to-integer/
        [Test, Category ("StringTest")]
        public void RomanToIntTest () {
            // arrange
            // var s = "leetcode";
            // var expected = 0;
            var s = "MCMXCIV";
            var expected = 4;
            // actual
            var actual = StringTest.RomanToInt (s);
            // assert
            Assert.AreEqual (actual, expected);
        }

        // 125. Valid Palindrome
        // https://leetcode.com/problems/valid-palindrome/
        [Test, Category ("StringTest")]
        public void IsPalindromeTest () {
            // arrange
            var s = "0P";
            var expected = true;
            // actual
            bool actual = StringTest.IsPalindrome (s);
            // assert
            Assert.AreEqual (actual, expected);
        }

        // 28. Implement strStr()
        // https://leetcode.com/problems/implement-strstr/
        [Test, Category ("StringTest")]
        public void StrStrTest () {
            // arrange
            var haystack = "abc";
            var needle = "c";
            var expected = 2;
            // actual
            int actual = StringTest.StrStr (haystack, needle);
            // assert
            Assert.AreEqual (actual, expected);
        }

        // 415. Add Strings
        // https://leetcode.com/problems/add-strings/
        [Test, Category ("StringTest")]
        public void AddStringsTest () {
            // arrange
            var num1 = "9";
            var num2 = "1";
            var expected = "";
            // actual
            string actual = StringTest.AddStrings (num1, num2);
            // assert
            Assert.AreEqual (actual, expected);
        }

        // 43. Multiply Strings
        // https://leetcode.com/problems/multiply-strings/
        [Test, Category ("StringTest")]
        public void MultiplyTest () {
            // arrange
            var num1 = "123";
            var num2 = "456";
            var expected = "56088";
            // actual
            string actual = StringTest.Multiply (num1, num2);
            // assert
            Assert.AreEqual (actual, expected);
        }

        // 58. Length of Last Word
        // https://leetcode.com/problems/length-of-last-word/
        [Test, Category ("StringTest")]
        public void LengthOfLastWordTest () {
            // arrange
            var s = "Hello World";
            var expected = 0;
            // actual
            var actual = StringTest.LengthOfLastWord (s);

            // assert
            Assert.AreEqual (actual, expected);
        }

        // 392. Is Subsequence
        // https://leetcode.com/problems/is-subsequence/
        [Test, Category ("StringTest")]
        public void IsSubsequenceTest () {
            // arrange
            var s = "abc";
            var t = "ahbgdc";
            var expected = true;
            // actual
            var actual = StringTest.IsSubsequence (s, t);
            // assert
            Assert.AreEqual (actual, expected);
        }

        // 171. Excel Sheet Column Number
        // https://leetcode.com/problems/excel-sheet-column-number/
        [Test, Category ("StringTest")]
        public void TitleToNumberTest () {
            // arrange
            var columnTitle = "AB"; // 26^1 + 1*26^0
            //"ABC" // 26^2 + 2*26^1 + 3*26^2
            var expected = 27;
            // actual
            var actual = StringTest.TitleToNumber (columnTitle);
            // assert
            Assert.AreEqual (actual, expected);
        }

        // 168. Excel Sheet Column TitleToNumber
        // https://leetcode.com/problems/excel-sheet-column-title/
        [Test, Category ("StringTest")]
        public void ConvertToTitleTest () {
            // arrange
            // var n = 1;
            // var expected = "A";
            var n = 27;
            var expected = "AA";
            // var n = 701;
            // var expected = "AAA";

            // actual
            string actual = StringTest.ConvertToTitle (n);

            // assert
            Assert.AreEqual (actual, expected);
        }

        // 205. Isomorphic Strings
        // https://leetcode.com/problems/isomorphic-strings/
        [Test, Category ("StringTest")]
        [TestCase ("egg", "add", true),
            TestCase ("paper", "title", true),
            TestCase ("badc", "baba", false)
        ]
        public void IsIsomorphicTest (string s, string t, bool expected) {
            // arrange

            // actual
            var actual = StringTest.IsIsomorphic (s, t);

            // assert
            Assert.AreEqual (actual, expected);
        }

        // 290. Word Pattern
        // https://leetcode.com/problems/word-pattern/
        [Test, Category ("StringTest")]
        [TestCase ("abba", "dog cat cat dog", true)]
        [TestCase ("abba", "dog dog dog dog", false)]
        public void WordPatternTest (string pattern, string s, bool expected) {
            // arrange

            // actual
            var actual = StringTest.WordPattern (pattern, s);

            // assert
            Assert.AreEqual (actual, expected);
        }

        // 459. Repeated Substring Pattern
        // https://leetcode.com/problems/repeated-substring-pattern/
        [Test, Category ("StringTest")]
        [TestCase ("ab", false)]
        //[TestCase ("abab", true)]
        //[TestCase ("aba", false)]
        //[TestCase ("abcabcabc", true)]
        //[TestCase ("ababba", false)]
        public void RepeatedSubstringPatternTest (string s, bool expected) {
            // arrange

            // actual
            var actual = StringTest.RepeatedSubstringPattern (s);

            // assert
            Assert.AreEqual (actual, expected);
        }

        // 942. DI String Match
        // https://leetcode.com/problems/di-string-match/
        [Test, Category ("StringTest")]
        public void DiStringMatchTest () {
            // arrange
            var s = "IDID";
            var expected = new int[] { 0, 4, 1, 3, 2 };

            // actual
            var actual = StringTest.DiStringMatch (s);

            // assert
            Assert.AreEqual (actual, expected);
        }

        // 884. Uncommon Words from Two Sentences
        // https://leetcode.com/problems/uncommon-words-from-two-sentences/
        [Test, Category ("StringTest")]
        public void UncommonFromSentencesTest () {
            // arrange
            // var s1 = "this apple is sweet";
            // var s2 = "this apple is sour";
            // var expected = new string[] { "sweet","sour" };
            var s1 = "apple apple";
            var s2 = "banana";
            var expected = new string[] { "banana" };
            // actual
            var actual = StringTest.UncommonFromSentences (s1, s2);

            // assert
            Assert.AreEqual (actual, expected);
        }

        // 151. Reverse Words in a String
        // https://leetcode.com/problems/reverse-words-in-a-string/
        [Test, Category ("StringTest")]
        [TestCase ("  hello world  ", "world hello"),
            TestCase ("a good   example", "example good a"),
            TestCase ("  Bob    Loves  Alice   ", "Alice Loves Bob")
        ]
        public void ReverseWordsTest (string s, string expected) {
            // arrange

            // actual
            var actual = StringTest.ReverseWords (s);

            // assert
            Assert.AreEqual (actual, expected);
        }

        [Test, Category ("StringTest.SlidingWindows")]
        [TestCase ("abcabcbb", 3)]
        public void LengthOfLongestSubstringTest (string s, int expected) {
            // arrange

            // actual
            var actual = StringTest.LengthOfLongestSubstring (s);

            // assert
            Assert.AreEqual (actual, expected);
        }

        [Test, Category ("StringTest.SlidingWindows")]
        [TestCase ("xyzzaz", 1)]
        public void CountGoodSubstringsTest (string s, int expected) {
            // arrange

            // actual
            var actual = StringTest.CountGoodSubstrings (s);

            // assert
            Assert.AreEqual (actual, expected);
        }

        [Test, Category ("StringTest.DecodeString")]
        [TestCase ("3[a]2[bc]", "aaabcbc")]
        // [TestCase ("3[a2[c]]", "accaccacc")]
        // [TestCase ("2[abc]3[cd]ef", "abcabccdcdcdef")]
        // [TestCase ("abc3[cd]xyz", "abccdcdcdxyz")]
        public void DecodeStringTest (string s, string expected) {
            // arrange

            // actual
            var actual = StringTest.DecodeString (s);

            // assert
            Assert.AreEqual (actual, expected);
        }
    }
}