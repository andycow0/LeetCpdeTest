using System;
using System.Linq;

namespace LeetCodeTest.ArrayTest
{
    public class ArrayObj
    {
        public static string ToLowerCaseString(string s)
        {
            var result = string.Empty;

            var charArray = new Char[s.Length];
            var dic = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'A' && s[i] <= 'Z')
                {
                    var a = (s[i] - 'A' + 'a');
                    result += (char)a;
                }
                else
                {
                    result += s[i];
                }
            }

            return result;
        }
    }
}