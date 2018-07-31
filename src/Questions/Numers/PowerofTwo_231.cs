namespace src.Questions.Numers {
    public class PowerofTwo_231 {
        public static bool IsPowerOfTwo (int n) {
            if (n == 0 || n < 0) {
                return false;
            }

            if (n == 1) {
                return true;
            }

            var s = 0;

            do {
                s = n % 2;
                if (s == 1) {
                    break;
                }
                n = n / 2;
            } while (n != 1);

            return s == 0;
        }
    }
}