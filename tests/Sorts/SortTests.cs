using System;
using NUnit.Framework;
using src.Questions.SortTest;

namespace tests.Questions {
    public class SortTests {
        [Test]
        [TestCase (new int[] { 3, -9, -12, -1, 8 })]
        [TestCase (new int[] { 5, 3, 8, 2, 1, 4 })]
        [TestCase (new int[] { 20, 20, 31, 56, 1, 12, 12 })]
        public void BubbleSortTest (int[] nums) {

            // var nums = new int[] { 5, 3, 8, 2, 1, 4 };
            // var nums = new int[] { 3, -9, -12, -1, 8 };
            var acutal = Sorts.BubbleSort (nums);

            Array.Sort (nums);
            var expected = nums;

            Assert.AreEqual (acutal, expected);
        }

    }
}