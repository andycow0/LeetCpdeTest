using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeTest.ArrayTest {
    public class ContainsDuplicate_217 {
        public static bool ContainsDuplicate (int[] nums) {
            var result = false;

            if (nums.Length < 2) {
                return result;
            }

            var maps = new List<int> ();
            foreach (var num in nums) {
                if (maps.Contains (num)) {
                    result = true;
                    break;
                } else {
                    maps.Add(num);
                }
            }

            return result;
        }
    }
}