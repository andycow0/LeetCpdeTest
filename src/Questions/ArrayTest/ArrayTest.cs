using System.Collections.Generic;

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
    }
}