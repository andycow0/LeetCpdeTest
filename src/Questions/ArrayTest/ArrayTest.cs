using System;
using System.Collections.Generic;
using System.Linq;
using LeetCodeTest.Classes;

namespace src.Questions.ArrayTest {
    public class ArrayTest {
        public static void DuplicateZeros (int[] arr) {
            if (!(arr.Length >= 1 && arr.Length <= 1000)) {
                return;
            }

            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] < 0 || arr[i] > 9) {
                    return;
                }
            }

            var newIdx = 0;
            var idx = 0;
            while (idx < arr.Length) {
                if (arr[idx] == 0) {
                    arr[idx] = arr[idx + 1];
                    newIdx += 2;
                } else {
                    newIdx++;
                }
            }
        }

        public static int NumberofGoodPairs (int[] nums) {
            var result = 0;

            if (nums.Length < 1) return result;

            for (int i = 0; i < nums.Length; i++) {
                for (int j = nums.Length - 1; j > i; j--) {
                    if (nums[i] == nums[j]) {
                        result++;
                    }
                }
            }

            return result;
        }

        public static int[] Shuffle (int[] nums, int n) {
            if (n < 1 || nums.Length % n != 0) {
                return null;
            }

            var result = new int[nums.Length];

            for (var i = 0; i < n; i++) {
                result[i * 2] = nums[i];
                result[i * 2 + 1] = nums[i + n];
            }

            return result;
        }

        public static string LongestCommonPrefix (string[] strs) {
            var strsLength = strs.Length;

            var hasTooLongPrefixLength = strs.Any (s => s.Length > 200);

            if (strsLength < 1 || strsLength > 200 || hasTooLongPrefixLength) {
                return null;
            }

            var result = strs[0];

            for (int i = 1; i < strs.Length; i++) {
                while (strs[i].IndexOf (result) != 0) {
                    result = result.Substring (0, result.Length - 1);
                    if (result.Length < 1) {
                        return string.Empty;
                    }
                }
            }

            return result;
        }

        public static string Interpret (string command) {

            var result = new List<string> ();

            var idx = 0;

            while (idx < command.Length) {
                if (command[idx] == 'G') {
                    idx++;
                    result.Add ("G");
                } else if (command[idx] == '(' && command[idx + 1] == ')') {
                    idx += 2;
                    result.Add ("o");
                } else {
                    idx += 4;
                    result.Add ("al");
                }

            }

            return string.Join (string.Empty, result);
        }

        public static int NumJewelsInStones (string jewels, string stones) {

            var result = 0;

            foreach (var stone in stones) {
                if (jewels.Contains (stone)) {
                    result++;
                }
            }

            return result;
        }

        public static int[] RunningSum (int[] nums) {

            var result = new List<int> ();

            for (var i = 0; i < nums.Length; i++) {
                if (i == 0) {
                    result.Add (nums[i]);
                } else {
                    var sum = 0;
                    for (var j = i; j > -1; j--) {
                        sum += nums[j];
                    }
                    result.Add (sum);
                }

            }

            return result.ToArray ();
        }

        public static string ShuffleString (string s, int[] indices) {

            var result = new string[s.Length];

            for (var i = 0; i < s.Length; i++) {
                var idx = indices[i];
                result[idx] = s[i].ToString ();
            }

            return string.Join ("", result);
        }

        public static char[] ReverseString (char[] s) {

            for (var i = 0; i < s.Length; i++) {
                var j = s.Length - 1 - i;
                if (j == i || i > j) {
                    break;
                }
                var temp = s[i];
                s[i] = s[j];
                s[j] = temp;
            }

            return s;
        }

        public static int SingleNumber (int[] nums) {
            var numList = new List<int> ();

            for (int i = 0; i < nums.Length; i++) {
                var idx = numList.IndexOf (nums[i]);
                if (idx > -1) {
                    numList.Remove (nums[i]);
                } else {
                    numList.Add (nums[i]);
                }
            }

            return numList[0];
        }

        public static int MaxProfit (int[] prices) {
            var maxProfit = 0;
            var minPrice = 0;

            for (int i = 0; i < prices.Length; i++) {
                if (i == 0) {
                    minPrice = prices[i];
                } else if (prices[i] < minPrice) {
                    minPrice = prices[i];
                } else {
                    maxProfit = Math.Max (prices[i] - minPrice, maxProfit);
                }
            }

            return maxProfit;
        }

        public static bool ContainsDuplicate (int[] nums) {
            var duplicateDic = new List<int> ();

            for (var i = 0; i < nums.Length; i++) {
                if (!duplicateDic.Any (d => d == nums[i])) {
                    duplicateDic.Add (nums[i]);
                }
            }

            return duplicateDic.Count != nums.Length;
        }

        public static int RemoveDuplicates (int[] nums) {
            if (nums.Length < 1) {
                return 0;
            }

            var count = 1;
            var nowIdx = 1;
            var now = nums[0];

            for (int i = 1; i < nums.Length; i++) {
                if (now != nums[i]) {
                    count++;
                    now = nums[i];
                    nums[nowIdx] = nums[i];
                    nowIdx++;
                }
            }

            return count;
        }

        public static int MaxSubArray (int[] nums) {

            var sum = 0;
            var max = int.MinValue;

            for (var i = 0; i < nums.Length; i++) {
                sum += nums[i];
                if (nums[i] > sum) {
                    sum = nums[i];
                }

                if (sum > max) {
                    max = sum;
                }
            }

            return max;
        }

        public static int MaxProfitV2 (int[] nums) {
            var maxProfit = 0;
            var buyPrice = 0;
            for (var i = 0; i < nums.Length; i++) {
                if (i == 0) {
                    buyPrice = nums[i];
                } else {
                    var currProfit = nums[i] - buyPrice;

                    if (currProfit > maxProfit) {
                        maxProfit = currProfit;
                    }
                    buyPrice = nums[i];

                }
            }

            return maxProfit < 0 ? 0 : maxProfit;
        }

        public static int[] FindDisappearedNumbers (int[] nums) {
            var numLength = nums.Length;
            var numDic = Enumerable.Range (1, numLength).ToDictionary (k => k, v => false);

            var result = new List<int> ();

            for (int i = 0; i < numLength; i++) {
                if (numDic.TryGetValue (nums[i], out bool _)) {
                    numDic[nums[i]] = true;
                }
            }

            return numDic.Where (r => !r.Value).Select (r => r.Key).ToArray ();

        }

        public static IList<int> FindDuplicates (int[] nums) {
            var result = new List<int> ();

            var status = new bool[nums.Length];

            for (var i = 0; i < nums.Length; i++) {
                if (status[nums[i] - 1]) {
                    result.Add (nums[i]);
                } else {
                    status[nums[i] - 1] = true;
                }
            }

            return result;
        }

        public static void Merge (int[] nums1, int m, int[] nums2, int n) {
            n--;
            m--;
            while (n >= 0) {
                if (m < 0 || nums1[m] < nums2[n]) {
                    nums1[m + n + 1] = nums2[n];
                    n--;
                } else {
                    nums1[m + n + 1] = nums1[m];
                    m--;
                }
            }
        }

        public static int MissingNumber (int[] nums) {
            var keys = new bool[nums.Length + 1];

            for (int i = 0; i < nums.Length; i++) {
                keys[nums[i]] = true;
            }

            for (int i = 0; i < keys.Length; i++) {
                if (!keys[i]) {
                    return i;
                }
            }

            return 0;
        }

        public static IList<int> AddToArrayForm (int[] A, int K) {
            var stack = new Stack<int> ();

            var i = A.Length - 1;

            var carry = 0;
            var kVal = 0;

            while (i > -1 || K > 0) {
                kVal = K % 10;
                var aVal = i > -1 ? A[i] : 0;
                var sum = aVal + kVal + carry;
                if (sum > 9) {
                    stack.Push (sum % 10);
                    carry = 1;
                } else {
                    stack.Push (sum);
                    carry = 0;
                }
                i--;
                K = K / 10;
            }
            if (carry == 1) {
                stack.Push (1);
            }

            var result = new List<int> ();

            while (stack.Count > 0) {
                result.Add (stack.Pop ());
            }

            return result.ToArray ();
        }

        public static int[] Intersect (int[] nums1, int[] nums2) {

            var result = new List<int> ();
            var bucket = new List<int> ();

            int[] longArr;
            int[] shortArr;

            if (nums1.Length > nums2.Length) {
                longArr = nums1;
                shortArr = nums2;
            } else {
                longArr = nums2;
                shortArr = nums1;
            }

            for (int i = 0; i < longArr.Length; i++) {
                bucket.Add (longArr[i]);
            }

            for (var j = 0; j < shortArr.Length; j++) {
                var idx = bucket.IndexOf (shortArr[j]);
                if (idx > -1) {
                    result.Add (shortArr[j]);
                    bucket.RemoveAt (idx);
                }
            }

            return result.ToArray ();
        }

        public static IList<string> CommonChars (string[] A) {

            var result = new List<string> ();
            var baseStr = A[0].ToList ();

            return result;
        }

        public static int FindDuplicate (int[] nums) {
            //var n = nums.Length - 1;

            var list = new List<int> ();

            for (int i = 0; i < nums.Length; i++) {
                if (list.IndexOf (nums[i]) < 0) {
                    list.Add (nums[i]);
                } else {
                    return nums[i];
                }
            }

            return 0;
        }

        public static int[] FindErrorNums (int[] nums) {
            var n = nums.Length;
            var set = new Dictionary<int, int> ();

            var result = new int[2];

            for (int i = 1; i <= n; i++) {
                set.Add (i, 0);
            }

            var j = 0;

            while (j < n) {
                if (set.TryGetValue (nums[j], out int times)) {
                    times++;

                    set[nums[j]] = times;
                } else {
                    set.Add (nums[j], 0);
                }
                j++;
            }

            result[0] = set.FirstOrDefault (r => r.Value > 1).Key;
            result[1] = set.FirstOrDefault (r => r.Value == 0).Key;

            return result;
        }

        public static TreeNode SortedArrayToBST (int[] nums) {
            throw new NotImplementedException ();
        }

        public static int RemoveElement (int[] nums, int val) {

            var count = 0;
            var i = 0;
            while (i < nums.Length) {
                if (nums[i] != val) {
                    nums[count++] = nums[i];
                }
                i++;
            }

            return count;
        }

        public static void MoveZeroes (int[] nums) {

            var count = 0;

            for (var i = 0; i < nums.Length; i++) {

                if (nums[i] != 0) {
                    nums[count++] = nums[i];
                }
            }

            for (var j = count; j < nums.Length; j++) {
                nums[j] = 0;
            }

        }

        public static int SearchInsert (int[] nums, int target) {

            var currentIdx = 0;

            for (var i = 0; i < nums.Length; i++) {
                if (nums[i] == target) {
                    return i;
                }

                if (target > nums[i]) {
                    currentIdx = i + 1;
                } else {
                    break;
                }
            }

            return currentIdx;

        }

        // public static int[] PlusOne (int[] digits) {
        //     long sum = 0;
        //     var j = 0;
        //     for (var i = digits.Length; i > 0; i--) {
        //         var mul = (long) Math.Pow (10, j);
        //         sum += digits[i - 1] * mul;
        //         j++;
        //     }

        //     sum++;

        //     var result = new Stack<int> ();

        //     while (sum /10> 0 || sum % 10 > 0) {
        //         var num = sum % 10;
        //         result.Push ((int)num);
        //         sum = sum / 10;
        //     }

        //     return result.ToArray ();
        // }

        public static int[] PlusOne (int[] digits) {
            var stack = new Stack<int> ();
            var isCarry = false;
            for (var i = digits.Length - 1; i > -1; i--) {

                var digit = i == digits.Length - 1 ? digits[i] + 1 : digits[i];

                if (isCarry) {
                    digit++;
                } else {

                }
                isCarry = digit > 9 ? true : false;
                stack.Push (digit % 10);
            }
            if (isCarry) {
                stack.Push (1);
            }
            return stack.ToArray ();
        }

        public static int[] TwoSumII (int[] numbers, int target) {
            var result = new int[2];

            for (var i = 0; i < numbers.Length; i++) {
                for (var j = i + 1; j < numbers.Length; j++) {
                    var firstNum = numbers[i];
                    var secNum = numbers[j];
                    if (firstNum + secNum == target) {
                        result[0] = i + 1;
                        result[1] = j + 1;
                        return result;
                    }
                }

            }

            return result;
        }

        public static int[] TwoSumII2 (int[] numbers, int target) {
            var result = new int[2];

            var start = 0;
            var end = numbers.Length - 1;

            while (start < end) {
                var first = numbers[start];
                var second = numbers[end];
                var sum = first + second;
                if (sum == target) {
                    result[0] = start + 1;
                    result[1] = end + 1;
                    return result;
                } else if (sum > target) {
                    end--;
                } else {
                    start++;
                }

            }
            return result;
        }
    }
}