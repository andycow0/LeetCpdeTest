using System;
using System.Collections.Generic;

namespace LeetCodeTest.ArrayTest {
    public class MajorityElement_169 {
        public static int MajorityElement (int[] nums) {
            var result = 0;
            var aa = (decimal) nums.Length / 2;
            var benchmark = Math.Round (aa, 0, MidpointRounding.AwayFromZero);
            var numDic = new Dictionary<int, int> ();

            foreach (var num in nums) {
                if (!numDic.ContainsKey (num)) {
                    numDic.Add (num, 1);
                    if (benchmark == 1) {
                        result = num;
                        break;
                    }
                } else {
                    numDic[num]++;

                    if (numDic[num] >= benchmark) {
                        result = num;
                        break;
                    }
                }
            }

            return result;
        }
    }
}