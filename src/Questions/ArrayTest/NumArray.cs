namespace src.Questions.ArrayTest {
    public class NumArray {
        private int[] _nums;
        public NumArray (int[] nums) {
            _nums = nums;
        }

        public int SumRange (int left, int right) {
            var sum = 0;

            if (left < 0 || right > _nums.Length - 1) {
                return sum;
            }

            for (var i = left; i < right; i++) {
                sum += _nums[i];
            }
            
            return sum;
        }
    }
}