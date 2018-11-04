namespace src.Questions.Numers {
    public class IntegerAddOrMinux {
        public static int CountingIntegers (int nums) {
            var result = 0;

            for (int i = 0; i <= nums; i++) {
                if (i % 2 == 1) {
                    result += i;
                } else {
                    result = result - i;
                }
            }

            return result;
        }
    }
}