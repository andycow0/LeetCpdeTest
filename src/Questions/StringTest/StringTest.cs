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
            var map = new int[26];
            //var result = 10001;
            for (var i = 0; i < s.Length; i++) {
                var idx = s[i] - 'a';
                map[idx] += 1;
            }

            for (int i = 0; i < s.Length; i++) {
                if (map[s[i] - 'a'] == 1) {
                    return i;
                }
            }

            return -1;

            // var dic = new Dictionary<char, int> ();

            // for (var i = 0; i < s.Length; i++) {
            //     if (dic.TryGetValue (s[i], out int nums)) {
            //         dic[s[i]] += 1;
            //     } else {
            //         dic.Add (s[i], 1);
            //     }
            // }

            // foreach (var item in dic) {
            //     if (item.Value == 1) {
            //         return s.IndexOf (item.Key);
            //     }
            // }
            // return -1;
        }

        public static int RomanToInt (string s) {
            var dic = new Dictionary<char, int> () { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'C', 100 }, { 'L', 50 }, { 'D', 500 }, { 'M', 1000 }
                };

            if (s.Length < 1) {
                return 0;
            }

            var sum = 0;
            var i = s.Length - 1;
            var preValue = 0;

            while (i > -1) {
                dic.TryGetValue (s[i], out int currValue);

                if (preValue / currValue == 5 || preValue / currValue == 10) {
                    sum -= currValue;
                } else {
                    sum += currValue;
                }

                preValue = currValue;
                i--;
            }

            return sum;
        }

        public static int StrStr (string haystack, string needle) {
            if (haystack == needle) {
                return 0;
            }
            var i = 0;

            while (i < haystack.Length) {
                if (i + needle.Length - 1 > haystack.Length - 1) {
                    return -1;
                }
                var now = haystack.Substring (i, needle.Length);

                if (now == needle) {
                    return i;
                }
                i++;
            }

            return -1;
        }

        public static string Multiply (string num1, string num2) {
            var carry = 0;
            var list = new Stack<int> ();

            for (int i = num1.Length - 1, j = num2.Length - 1; i > -1 || j > -1; i--, j--) {
                var val1 = i < 0 ? 0 : Convert.ToInt16 (num1[i].ToString ());
                var val2 = j < 0 ? 0 : Convert.ToInt16 (num2[j].ToString ());
                var sum = val1 * val2 + carry;

                list.Push (sum % 10);
                carry = sum / 10;
            }

            if (carry > 0) {
                list.Push (1);
            }

            var result = string.Empty;

            while (list.Count > 0) {
                result += list.Pop ().ToString ();
            }

            return result;
        }

        public static int LengthOfLastWord (string s) {

            s = s.Trim ();

            if (s.Length < 1) return 0;

            while (s.Length > 0) {

                var spaceIdx = s.IndexOf (' ');

                if (spaceIdx < 0) {
                    return s.Length;
                } else {
                    s = s.Substring (spaceIdx + 1, s.Length - spaceIdx - 1);
                }
            }

            return s.Length;
        }

        public static string AddStrings (string num1, string num2) {
            var carry = 0;
            var list = new Stack<int> ();

            for (int i = num1.Length - 1, j = num2.Length - 1; i > -1 || j > -1; i--, j--) {
                var val1 = i < 0 ? 0 : Convert.ToInt16 (num1[i].ToString ());
                var val2 = j < 0 ? 0 : Convert.ToInt16 (num2[j].ToString ());
                var sum = val1 + val2 + carry;

                list.Push (sum % 10);
                carry = sum / 10;
            }

            if (carry == 1) {
                list.Push (1);
            }

            var result = string.Empty;

            while (list.Count > 0) {
                result += list.Pop ().ToString ();
            }

            return result;
        }

        public static int TitleToNumber (string columnTitle) {
            var sum = 0;
            var i = 0;

            while (columnTitle.Length > 0) {
                var value = columnTitle[columnTitle.Length - 1] - 64;
                sum += value * (int) Math.Pow (26, i);
                columnTitle = columnTitle.Substring (0, columnTitle.Length - 1);
                i++;
            }

            return sum;
        }

        public static string ConvertToTitle (int n) {

            var result = string.Empty;

            while (n > 0) {
                var r = n % 26;
                int code = r + 64;
                n = r == 0 ? (n - 1) / 26 : n / 26; // n -1 => when r is 0 for 'Z'
                code = r == 0 ? 90 : r + 64;
                result = (char) code + result;

                // if (r == 0 && n == 1) {
                //     break;
                // }
            }

            return result;
        }

        public static bool IsIsomorphic (string s, string t) {
            if (s.Length != t.Length) {
                return false;
            }

            var totalLength = s.Length;

            var map = new Dictionary<char, char> ();

            for (var i = 0; i < totalLength; i++) {
                if (!map.TryGetValue (s[i], out char c)) {
                    // prevent value is duplicated.
                    foreach (var item in map) {
                        if (item.Value == t[i]) {
                            return false;
                        }
                    }
                    map.Add (s[i], t[i]);
                    continue;
                }

                if (t[i] != c) {
                    return false;
                }
            }

            return true;
        }

        public static bool WordPattern (string pattern, string s) {

            var sArray = s.Split (' ');

            if (pattern.Length != sArray.Length) {
                return false;
            }

            if (pattern.Distinct ().Count () != sArray.Distinct ().Count ()) {
                return false;
            }

            var map = new Dictionary<char, string> ();

            for (var i = 0; i < pattern.Length; i++) {
                var key = pattern[i];

                if (map.TryGetValue (key, out string value)) {

                    if (value != sArray[i]) {
                        return false;
                    }
                    break;
                }

                map.Add (key, sArray[i]);
            }

            return true;
        }

        public static int[] DiStringMatch (string s) {
            throw new NotImplementedException ();
        }

        public static bool RepeatedSubstringPattern (string s) {

            var maxSize = s.Length / 2;
            var allLength = s.Length;
            var subString = string.Empty;

            for (var i = 0; i <= maxSize; i++) {
                var count = 0;
                subString += s[i];

                var subLength = subString.Length;

                if (subString == s) {
                    return false;
                }

                for (var j = 0; j < s.Length - 1; j = j + subLength) {
                    if (allLength - j < subLength) {
                        continue;
                    }
                    var subNow = s.Substring (j, subLength);
                    if (subNow == subString) {
                        count++;
                    }
                }

                if (count == allLength / (i + 1) &&
                    allLength % (i + 1) == 0) {
                    return true;
                }
            }

            return false;
        }

        public static string ReverseWords (string s) {
            var result = string.Empty;
            var array = s.Split (" ");
            var stack = new Stack<string> ();

            for (var i = 0; i < array.Length; i++) {
                if (string.IsNullOrEmpty (array[i])) continue;

                stack.Push (array[i]);
            }

            result = string.Join (" ", stack);

            return result;
        }

        public static int LengthOfLongestSubstring (string s) {
            var left = 0;
            var right = 0;
            var window = new List<int> ();
            while (right < s.Length) {
                right++;
                while (true) {

                }
            }

            throw new NotImplementedException ();
        }

        public static int CountGoodSubstrings (string s) {
            var left = 0;
            var right = 0;
            var count = 0;
            while (right < s.Length) {
                right++;
                while (right - left == 3) {
                    var subStr = s.Substring (left, 3);
                    if (subStr[0] != subStr[1] && subStr[1] != subStr[2] && subStr[0] != subStr[2])
                        count++;
                    left++;
                }
            }

            return count;
        }

        public static string[] UncommonFromSentences (string s1, string s2) {

            var dict = new Dictionary<string, int> ();

            var s1Arr = s1.Split (" ");
            var s2Arr = s2.Split (" ");

            var maxLength = s1Arr.Length < s2Arr.Length ? s2Arr.Length : s1Arr.Length;

            var s1Strings = new string[2];

            for (var i = 0; i < maxLength; i++) {
                if (i < s1Arr.Length) {
                    s1Strings[0] = s1Arr[i];
                }

                if (i < s2Arr.Length) {
                    s1Strings[1] = s2Arr[i];
                }

                if (!string.IsNullOrEmpty (s1Strings[0])) {
                    if (dict.TryGetValue (s1Strings[0], out int count1)) {
                        dict[s1Strings[0]] = ++count1;
                    } else {
                        dict.TryAdd (s1Strings[0], 1);
                    }
                }

                if (!string.IsNullOrEmpty (s1Strings[1])) {
                    if (dict.TryGetValue (s1Strings[1], out int count2)) {
                        dict[s1Strings[1]] = ++count2;
                    } else {
                        dict.TryAdd (s1Strings[1], 1);
                    }
                }

                s1Strings[0] = string.Empty;
                s1Strings[1] = string.Empty;
            }

            return dict.Where (d => d.Value == 1).Select (d => d.Key).ToArray ();
        }

        public static bool IsSubsequence (string s, string t) {

            var stack = new Stack<char> ();

            for (var i = 0; i < s.Length; i++) {
                stack.Push (s[i]);
            }

            for (var i = t.Length - 1; i > -1; i--) {
                var current = t[i];
                if (stack.Count == 0) {
                    return true;
                }
                var lastStack = stack.First ();

                if (current == lastStack) {
                    stack.Pop ();
                }
            }

            return stack.Count == 0;
        }

        public static bool IsPalindrome (string s) {
            s = s.ToLower ();

            var target = string.Empty;

            for (int i = 0; i < s.Length; i++) {
                if ((s[i] >= 97 && s[i] <= 122) || (s[i] >= 48 && s[i] <= 57)) {
                    target += s[i];
                }
            }

            var j = target.Length - 1;

            for (int i = 0; i < target.Length; i++) {
                if (i >= j) {
                    break;
                }
                if (target[i] != target[j]) {
                    return false;
                }
                j--;
            }

            return true;
        }
    }
}