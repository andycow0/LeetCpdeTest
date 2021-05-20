using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeTest.Questions {
    public class NumbersTest {
        public static IList<string> FizzBuzz (int n) {
            var result = new List<string> ();

            for (int i = 1; i <= n; i++) {
                if (i % 15 == 0) {
                    result.Add ("FizzBuzz");
                } else if (i % 3 == 0) {
                    result.Add ("Fizz");
                } else if (i % 5 == 0) {
                    result.Add ("Buzz");
                } else {
                    result.Add (i.ToString ());
                }
            }

            return result;
        }

        public static int FibonacciSequence (int n) {
            if (n == 0) {
                return 1;
            }
            if (n == 1) {
                return 1;
            }

            return FibonacciSequence (n - 1) + FibonacciSequence (n - 2);
        }

        public static bool IsPrimeNumber (int n) {

            if (n == 0 || n == 1) {
                return false;
            }

            var isFlag = true;

            for (int i = 2; i < n; i++) {
                if (n % i == 0) {
                    isFlag = false;
                }

                if (!isFlag) {
                    break;
                }
            }

            return isFlag;
        }

        public static int CountPrimes (int n) {
            var result = 0;
            var primes = new List<int> ();

            for (var i = 2; i < n; i++) {

                var isPrime = true;

                for (var j = 0; j < primes.Count; j++) {
                    if (i % primes[j] == 0) {
                        isPrime = false;
                        break;
                    }
                    if (i < primes[j] * primes[j]) {
                        break;
                    }
                }

                if (isPrime) {
                    primes.Add (i);
                    result++;
                }
            }

            return result;
        }

        public static int TrailingZeroes (int n) {
            if (n < 1) {
                return 0;
            }

            var factorial = 1;

            while (n > 0) {
                factorial = factorial * n;
                n--;
            }

            var result = factorial.ToString ();

            return result.Where (s => s == '0').Any () ? 1 : 0;
        }

        public static int Reverse (int x) {

            if (x < -1 * int.MaxValue ||
                x > int.MaxValue) {
                return 0;
            }

            long result = 0;

            var absN = Math.Abs (x);

            while (absN != 0) {
                result = result * 10 + absN % 10;
                absN = absN / 10;
            }

            if (result < -1 * Math.Pow (2, 31) ||
                result > Math.Pow (2, 31) - 1) {
                return 0;
            }

            return x > 0 ? (int) result : (int) result * -1;
        }

        public static int MySqrt (int x) {

            if (x <= 1) return x;

            var i = 1; // prevent overflow
            var sq = i * i;
            while (sq <= x) {
                i++;
                sq = i * i;
            }
            return (int) i - 1;
        }

        public static bool IsPerfectSquare (int num) {

            var i = 1;
            var sq = i * i;

            while (i <= num / i) {
                if (sq == num) return true;
                i++;
                sq = i * i;
            }

            return false;

            // #online solution.
            // for (int i = 1; i <= num / i; i++) {
            //     if (i * i == num) return true;
            // }
            // return false;
        }

        public static IList<IList<int>> Generate (int numRows) {
            var result = new List<IList<int>> (numRows);
            IList<int> last = null;
            for (var i = 0; i < numRows; i++) {
                var subSize = i + 1;
                var currList = new int[subSize];

                for (var j = 0; j < subSize; j++) {
                    if (j == 0 || j == subSize - 1) {
                        currList[j] = 1;
                    } else {
                        currList[j] = last[j - 1] + last[j];
                    }

                }

                last = currList;
                result.Add (currList);
            }

            return result;
        }

        public static string CountAndSay (int n) {
            var result = string.Empty;
            var currNum = 0;
            var count = 1;
            var stack = new Stack<string> ();

            while (n != 0) {
                var nowNum = n % 10;

                if (currNum == nowNum) {
                    count++;
                } else if (currNum == 0) {
                    currNum = nowNum;
                    count = 1;
                } else {
                    stack.Push ($"{count}{currNum}");
                    currNum = nowNum;
                    count = 1;
                }

                n = n / 10;
            }

            if (currNum != 0) {
                stack.Push ($"{count}{currNum}");
            }

            while (stack.Count > 0) {
                result += stack.Pop ();
            }

            return result;
        }

        public static string ConvertToBase7 (int num) {
            if (num == 0) {
                return "0";
            }

            var stack = new Stack<int> ();
            var abs = Math.Abs (num);

            var result = 0;
            var n = 1;
            while (abs != 0) {
                var r = abs % 7;
                stack.Push (r);
                abs = abs / 7;
                if (abs != 0) {
                    n = n * 10;
                }
            }

            while (n != 0) {
                result += n * stack.Pop ();
                n = n / 10;
            }

            result = num < 0 ? -1 * result : result;

            return result.ToString ();
        }

    }
}