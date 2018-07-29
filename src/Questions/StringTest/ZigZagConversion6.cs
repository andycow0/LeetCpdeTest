namespace src.Questions.StringTest {
    public class ZigZagConversion6 {
        public static string Convert (string s, int numRows) {
            if (numRows < 1) {
                return s;
            }
            var result = string.Empty;
            var stringArray = new char[numRows, s.Length * numRows];
            stringArray[0, 0] = s[0];
            // var charIdx = 0;
            for (int i = 0; i < s.Length; i++)
            {
                                
            }
            return result;
        }
    }
}