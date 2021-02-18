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
            var actual = ArrayTest.ShuffleString (s, indices);
            // assert
            Assert.AreEqual (actual, expected);
        }

        // 344. Reverse String
        // Write a function that reverses a string. The input string is given as an array of characters char[].
        // Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
        // You may assume all the characters consist of printable ascii characters.
        [Test]
        public void ReverseString_Test () {
            // arrange
            var s = new char[] { 'h', 'e', 'l', 'l', 'o' };
            var expected = new char[] { 'o', 'l', 'l', 'e', 'h' };
            // actual
            var actual = ArrayTest.ReverseString (s);
            // assert
            Assert.AreEqual (actual, expected);
        }

        // 136. Single Number
        // https://leetcode.com/problems/single-number/
        // Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
        // Follow up: Could you implement a solution with a linear runtime complexity and without using extra memory?
        [Test]
        public void SingleNumber_Test () {
            // arrange
            var nums = new int[] { 1, 1, 2, 3, 4, 5, 4, 5, 3, -1, 2 };
            var expected = 1;
            // actual
            int actual = ArrayTest.SingleNumber (nums);
            // assert
            Assert.AreEqual (actual, expected);
        }

        // 121. Best Time to Buy and Sell Stock
        // https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
        // You are given an array prices where prices[i] is the price of a given stock on the ith day.
        //You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
        //Return the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.
        [Test, Category ("ArrayTests")]
        public void MaxProfitr_Test () {
            // arrange
            var nums = new int[] { 7, 1, 5, 3, 6, 4 };
            //var nums = new int[] { 7, 6, 4, 3, 1 };
            var expected = 5;
            //var expected = 0;
            // actual
            int actual = ArrayTest.MaxProfit (nums);
            // assert
            Assert.AreEqual (actual, expected);
        }
        // 217. Contains Duplicate
        // https://leetcode.com/problems/contains-duplicate/
        // Given an array of integers, find if the array contains any duplicates.
        //Your function should return true if any value appears at least twice in the array, and it should return false if every element is distinct.
        [Test]
        public void ContainsDuplicate_Test () {
            // arrange
            var nums = new int[] { 1, 2, 3, 1 };
            var expected = true;
            // var nums = new int[] { 1,2,3,4};
            // var expected = false;
            // actual
            bool actual = ArrayTest.ContainsDuplicate (nums);
            // assert
            Assert.AreEqual (actual, expected);
        }

        // 26. Remove Duplicates from Sorted Array
        // https://leetcode.com/problems/remove-duplicates-from-sorted-array/
        [Test]
        public void RemoveDuplicatesTest () {
            // arrange
            var nums = new int[] { 1, 1, 2 };
            var expected = 2;

            // actual
            int actual = ArrayTest.RemoveDuplicates (nums);
            // assert
            Assert.AreEqual (actual, expected);
        }

        // 53. Maximum Subarray
        // https://leetcode.com/problems/maximum-subarray/
        // Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.
        [Test]
        public void MaxSubArrayTest () {
            // arrange
            var nums = new int[] {-2, 1, -3, 4, -1, 2, 1, -5, 4 };
            var expected = 6;

            // actual
            int actual = ArrayTest.MaxSubArray (nums);
            // assert
            Assert.AreEqual (actual, expected);
        }

        // 448. Find All Numbers Disappeared in an Array
        // https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/
        [Test]
        public void FindDisappearedNumbersTest () {
            // arrange
            var nums = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
            var expected = new int[] { 5, 6 };

            // actual
            int[] actual = ArrayTest.FindDisappearedNumbers (nums);
            // assert
            Assert.AreEqual (actual, expected);
        }

        // 442. Find All Duplicates in an Array
        // https://leetcode.com/problems/find-all-duplicates-in-an-array/
        [Test]
        public void FindDuplicatesTest () {
            // arrange
            var nums = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
            var expected = new int[] { 2, 3 };

            // actual
            var actual = ArrayTest.FindDuplicates (nums);
            // assert
            Assert.AreEqual (actual, expected);
        }

        // 88. Merge Sorted Array
        // https://leetcode.com/problems/merge-sorted-array/
        [Test]
        public void MergeTest () {
            // arrange
            var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            var nums2 = new int[] { 2, 5, 6 };
            var expected = new int[] { 2, 3 };

            // actual
            var actual = ArrayTest.Merge (nums1, 3, nums2, 3);
            // assert
            Assert.AreEqual (actual, expected);
        }
    }
}