using System.Linq;

namespace src.Questions.Numers {
    public class PowerOfOneBit_191 {
        public static int HammingWeight (uint n) {
            if (n == 0) {
                return 0;
            }

            var bitString = string.Empty;
            uint s = 0;

            while (n != 0) {
                s = n % 2;
                n = n / 2;
                bitString = bitString.Insert (0, s.ToString ());
            }
            bitString = bitString.PadLeft (32, '0');

            return bitString.Where (c => c == '1').Count ();
        }
    }
}