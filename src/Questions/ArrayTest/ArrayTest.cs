using System.Collections.Generic;
using System.Linq;

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
                    result.Add("G");
                } else if (command[idx] == '(' && command[idx+1] == ')') {
                    idx += 2;
                    result.Add("o");
                } else {
                    idx += 4;
                    result.Add("al");
                }
                
            }

            return string.Join (string.Empty, result);
        }
    }
}