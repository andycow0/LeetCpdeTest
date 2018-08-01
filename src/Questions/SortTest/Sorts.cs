namespace src.Questions.SortTest {
    public class Sorts {
        public static int[] BubbleSort (int[] nums) {

            for (int i = nums.Length; i > 0; i--) {
                var idx = 0;
                while (idx < i-1) {
                    var nextIdx = idx + 1;
                    if (nums[idx] > nums[nextIdx]) {
                        var temp = nums[idx];
                        nums[idx] = nums[nextIdx];
                        nums[nextIdx] = temp;
                    }
                    idx++;
                }
            }

            return nums;
        }
    }
}