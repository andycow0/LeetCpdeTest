using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace src.Questions.StringTest {
    public class StringTest {
        public static bool IsValid (string s) {
            var stack = new Stack<char> ();

            var mapping = new Dictionary<char, char> () { { ')', '(' }, { ']', '[' }, { '}', '{' }
                };

            for (var i = 0; i < s.Length; i++) {
                var now = s[i];

                if (stack.Count () > 0 && mapping.TryGetValue (now, out char value)) {
                    if (stack.First () == value) {
                        stack.Pop ();
                    } else {
                        stack.Push (now);
                    }
                } else {
                    stack.Push (now);
                }
            }

            return stack.Count () == 0;
        }

        public static int FirstUniqChar (string s) {

            // if (s.Length == 1) return 0;

            // for (var i = 0; i < s.Length; i++) {

            //     var idx = -1;

            //     if (i == s.Length - 1) {
            //         return -1;
            //     } else {
            //         idx = s.Substring (i + 1, s.Length - i - 1).IndexOf (s[i]);
            //     }
            //     if (idx < 0) {
            //         return i;
            //     }
            // }

            // return -1;

            var dic = new Dictionary<char, int> ();

            for (var i = 0; i < s.Length; i++) {
                if (dic.TryGetValue (s[i], out int nums)) {
                    dic[s[i]] += 1;
                } else {
                    dic.Add (s[i], 1);
                }
            }

            foreach (var item in dic) {
                if (item.Value == 1) {
                    return s.IndexOf (item.Key);
                }
            }
            return -1;
        }

        public static int RomanToInt (string s) {

            var dic = new Dictionary<char, int> () { { 'I', 1 }, { 'X', 10 }, { 'C', 100 } };
            var spDic = new Dictionary<char, int> () { { 'V', 5 }, { 'L', 50 }, { 'D', 500 }, { 'M', 1000 } };

            if (s.Length < 1) {
                return 0;
            }
            var sum = 0;
            var i = 0;
            while (i < s.Length) {
                if (dic.TryGetValue (s[i], out int value) && spDic.TryGetValue (s[i + 1], out int spValue)) {
                    sum += spValue - value;
                    i += 2;
                } else {
                    sum += value;
                }
            }
            return sum;
        }
    }
}