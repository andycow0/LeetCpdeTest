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

            var actual = ArrayTest.Shuffle (target, n);

            Assert.AreEqual (actual, expected);
        }

        // Write a function to find the longest common prefix string amongst an array of strings.
        // If there is no common prefix, return an empty string "".
        [Test]
        public void LongestCommonPrefix_Test () {
            var target = new string[] { "flower", "flow", "flight" };

            var expected = "fl";

            var actual = ArrayTest.LongestCommonPrefix (target);

            Assert.AreEqual (actual, expected);
        }

        // You own a Goal Parser that can interpret a string command. The command consists of an alphabet of "G", "()" and/or "(al)" in some order. The Goal Parser will interpret "G" as the string "G", "()" as the string "o", and "(al)" as the string "al". The interpreted strings are then concatenated in the original order.
        //Given the string command, return the Goal Parser's interpretation of command.
        [Test]
        public void GoalParserInterpretation_Test () {

            var target = "G()(al)";
            // var target = "G()()()()(al)";
            //var target = "G()()()(al)()";
            var expected = "Goal";
            // var expected = "Gooooal";
            // var expected = "Goooalo";

            string actual = ArrayTest.Interpret (target);

            Assert.AreEqual (actual, expected);
        }

        // You own a Goal Parser that can interpret a string command. The command consists of an alphabet of "G", "()" and/or "(al)" in some order. The Goal Parser will interpret "G" as the string "G", "()" as the string "o", and "(al)" as the string "al". The interpreted strings are then concatenated in the original order.
        //Given the string command, return the Goal Parser's interpretation of command.
        [Test]
        public void NumJewelsInStones_Test () {

            var jewels = "aA";
            var stones = "aAAbbbb";
            var expected = 3;

            int actual = ArrayTest.NumJewelsInStones (jewels, stones);

            Assert.AreEqual (actual, expected);
        }
        // 1480. Running Sum of 1d Array
        // https://leetcode.com/problems/running-sum-of-1d-array/
        // Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
        // Return the running sum of nums.
        [Test]
        public void RunningSum_Test () {
            // arrange
            var nums = new int[4] { 1, 2, 3, 4 };
            var expected = new int[4] { 1, 3, 6, 10 };
            // actual
            var actual = ArrayTest.RunningSum (nums);
            // assert
            Assert.AreEqual (actual, expected);
        }

        // 1528. Shuffle String
        // Given a string s and an integer array indices of the same length.
        // The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        // Return the shuffled string.
        [Test]
        public void ShuffleString_Test () {
            // arrange
            var s = "codeleet";
            var indices = new int[] { 4, 5, 6, 7, 0, 2, 1, 3 };
            var expected = "leetcode";
            // actual
            var actual = ArrayTest.ShuffleString(s, indices);
            // assert
            Assert.AreEqual (actual, expected);
        }
    }
}