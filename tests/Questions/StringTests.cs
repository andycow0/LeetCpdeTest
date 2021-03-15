using NUnit.Framework;
using src.Questions.StringTest;

namespace tests.Questions
{
    public class StringTests
    {
        // 20. Valid Parentheses
        // https://leetcode.com/problems/valid-parentheses/
        // Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
        // An input string is valid if:
        // Open brackets must be closed by the same type of brackets.
        // Open brackets must be closed in the correct order.
        [Test, Category("StringTest")]
        public void ValidParenthesesTest()
        {
            // arrange
            var s = "{]}";
            var expected = false;
            // actual
            var actual = StringTest.IsValid(s);
            // assert
            Assert.AreEqual(actual, expected);
        }

        // 387. First Unique Character in a String
        // https://leetcode.com/problems/first-unique-character-in-a-string/
        // Given a string, find the first non-repeating character in it and return its index. If it doesn't exist, return -1.
        [Test, Category("StringTest")]
        public void FirstUniqCharTest()
        {
            // arrange
            // var s = "leetcode";
            // var expected = 0;
            var s = "loveleetcode";
            var expected = 2;
            // actual
            var actual = StringTest.FirstUniqChar(s);
            // assert
            Assert.AreEqual(actual, expected);
        }

        // 13. Roman to Integer
        // https://leetcode.com/problems/roman-to-integer/
        [Test, Category("StringTest")]
        public void RomanToIntTest()
        {
            // arrange
            // var s = "leetcode";
            // var expected = 0;
            var s = "MCMXCIV";
            var expected = 4;
            // actual
            var actual = StringTest.RomanToInt(s);
            // assert
            Assert.AreEqual(actual, expected);
        }

        // 125. Valid Palindrome
        // https://leetcode.com/problems/valid-palindrome/
        [Test, Category("StringTest")]
        public void IsPalindromeTest()
        {
            // arrange
            var s = "0P";
            var expected = true;
            // actual
            bool actual = StringTest.IsPalindrome(s);
            // assert
            Assert.AreEqual(actual, expected);
        }

        // 28. Implement strStr()
        // https://leetcode.com/problems/implement-strstr/
        [Test, Category("StringTest")]
        public void StrStrTest()
        {
            // arrange
            var haystack = "abc";
            var needle = "c";
            var expected = 2;
            // actual
            int actual = StringTest.StrStr(haystack, needle);
            // assert
            Assert.AreEqual(actual, expected);
        }

        // 415. Add Strings
        // https://leetcode.com/problems/add-strings/
        [Test, Category("StringTest")]
        public void AddStringsTest()
        {
            // arrange
            var num1 = "9";
            var num2 = "1";
            var expected = "";
            // actual
            string actual = StringTest.AddStrings(num1, num2);
            // assert
            Assert.AreEqual(actual, expected);
        }

        // 43. Multiply Strings
        // https://leetcode.com/problems/multiply-strings/
        [Test, Category("StringTest")]
        public void MultiplyTest()
        {
            // arrange
            var num1 = "123";
            var num2 = "456";
            var expected = "56088";
            // actual
            string actual = StringTest.Multiply(num1, num2);
            // assert
            Assert.AreEqual(actual, expected);
        }
    }
}