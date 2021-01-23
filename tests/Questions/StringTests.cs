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
        public void ValidParenthesesTest () {
            // arrange
            var s = "{]}";
            var expected = false;
            // actual
            var actual = StringTest.IsValid (s);
            // assert
            Assert.AreEqual (actual, expected);
        }
    }
}