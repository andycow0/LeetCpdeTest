namespace tests.Questions {
    using NUnit.Framework;
    using src.Questions.ArrayTest;

    public class ArrayTests {
        [Test]
        public void DuplicateZerosTest () {

            var target = new int[] { 1, 0, 2, 3, 0, 4, 5, 0 };
            // var target = new int[] { 8,4,5,0,0,0,0,7 };
            // var target = new int[] { 1, 2, 3 };
            var expected = false;

            ArrayTest.DuplicateZeros (target);

            Assert.AreEqual (target, expected);
        }

        [Test]
        public void NumberofGoodPairsTest () {

            var target = new int[] { 1, 2, 3, 1, 1, 3 };

            var expected = 4;

            var actual = ArrayTest.NumberofGoodPairs (target);

            Assert.AreEqual (actual, expected);
        }

        // Given the array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
        // Return the array in the form [x1,y1,x2,y2,...,xn,yn].
        // nums = null or num length <> 2n -> null.

        [Test]
        public void ShuffleTheArray_1470_Test () {

            var target = new int[] { 2, 5, 1, 3, 4, 7 };

            var n = 3;

            var expected = new int[] { 2, 3, 5, 4, 1, 7 };

            var actual = ArrayTest.ShuffletheArray (target, n);

            Assert.AreEqual (actual, expected);
        }
    }
}