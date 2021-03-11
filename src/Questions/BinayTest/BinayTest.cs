using System;
using System.Collections.Generic;

namespace src.Questions.BinayTest {
    public class BinayTest {
        public static string GetIntersectionNode (string a, string b) {

            var result = string.Empty;
            var main = a.Length < b.Length ? b : a;
            var sub = a.Length < b.Length ? a : b;
            var stack = new Stack<int> ();
            var i = main.Length - 1;
            var j = sub.Length - 1;
            var carry = 0;

            while (i > -1) {
                var val1 = Convert.ToInt32 (main[i].ToString ());
                var val2 = j < 0 ? 0 : Convert.ToInt32 (sub[j].ToString ());

                var sum = val1 + val2 + carry;

                if (sum == 3) {
                    stack.Push (1);
                    carry = 1;
                } else if (sum == 2) {
                    stack.Push (0);
                    carry = 1;
                } else {
                    carry = 0;
                    stack.Push (sum);
                }

                i--;
                j--;
            }

            if (carry == 1) {
                stack.Push (1);
            }
            while (stack.Count > 0) {
                result += stack.Pop ();
            }
            return result;
        }
    }
}