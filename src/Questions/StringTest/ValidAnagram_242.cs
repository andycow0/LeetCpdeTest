using System.Collections.Generic;
using System.Linq;

namespace src.Questions.StringTest
{
    public class ValidAnagram_242
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            var sOrdered = s.OrderBy(c => c).ToArray();
            var tOrdered = t.OrderBy(c => c).ToArray();

            if (string.Equals(string.Join("", sOrdered), string.Join("", tOrdered)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}