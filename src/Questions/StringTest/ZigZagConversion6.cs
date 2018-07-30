namespace src.Questions.StringTest
{
    public class ZigZagConversion6
    {
        public static string Convert(string s, int numRows)
        {
            if (numRows < 1)
            {
                return s;
            }
            var result = string.Empty;
            var stringArray = new char[numRows, s.Length * numRows];
            var colIdx = 0;
            // var charCount = 0;
            var charArray = s.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (i == 0)
                {
                    stringArray[0, 0] = charArray[0];
                }
                if (i % numRows == 0 && i > 0)
                {

                }
                colIdx++;
            }

            for (int j = 0; j < s.Length; j++)
            {
                for (int i = 0; i < numRows; i++)
                {
                    if (colIdx == 0)
                    {
                        stringArray[i, j] = s[i];
                    }
                    else if (colIdx > 0 && colIdx % (numRows - 1) == 0)
                    {
                        stringArray[i, j] = s[numRows];

                    }
                    colIdx++;
                }
            }
            return result;
        }
    }
}