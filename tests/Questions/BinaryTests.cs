using LeetCodeTest.Questions.LinkedListTest;
using NUnit.Framework;
using src.Questions.BinayTest;

namespace tests.Questions {
    public class BinaryTests {
        // 67. Add Binary
        // https://leetcode.com/problems/add-binary/
        [Test, Category ("BinaryTest")]
        public void AddBinaryTest () {

            // arrange
            var a = "11";
            var b = "1";
            var expected = "100";

            // actual
            var actual = BinayTest.GetIntersectionNode (a, b);

            // assert
            Assert.AreEqual (actual, expected);
        }
        
    }
}