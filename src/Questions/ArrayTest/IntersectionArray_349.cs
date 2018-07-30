using System.Collections.Generic;

namespace src.Questions.ArrayTest
{
    public class IntersectionArray_349
    {
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            var result = new List<int>();

            if (nums1.Length < 1 || nums2.Length < 1)
            {
                return result.ToArray();
            }

            foreach (var num1 in nums1)
            {
                foreach (var num2 in nums2)
                {
                    if (num1 == num2 && !result.Contains(num1))
                    {
                        result.Add(num1);
                    }
                }
            }

            return result.ToArray();
        }
    }
}