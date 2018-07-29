namespace LeetCpdeTest.Questions.Numers {
    public class TwoSum_1 {
        public static int[] TwoSum (int[] nums, int target) {
            var result = new int[2];
            if (nums.Length > 0) {
                for (int i = 0; i < nums.Length; i++) {
                    for (int j = i + 1; j < nums.Length; j++) {
                        if (target == nums[i] + nums[j]) {
                            result[0] = i;
                            result[1] = j;
                        }
                    }
                }
            }
            return result;
        }
    }
}