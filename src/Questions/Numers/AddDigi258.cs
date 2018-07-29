namespace src.Questions.Numers {
    public class AddDigi258 {
        public static int AddDigits (int num) {
            if (num < 10) {
                return num;
            }

            do {
                var sArray = num.ToString ().ToCharArray ();
                var sum = 0;
                foreach (var item in sArray) {
                    int temp = 0;
                    if (int.TryParse (item.ToString (), out temp)) {
                        sum += temp;
                    }
                }
                num = sum;
            }
            while (num > 9);

            return num;
        }
    }
}