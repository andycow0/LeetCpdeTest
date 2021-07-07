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

        public static int Factorial (int n) {
            if (n == 0) {
                return 1;
            }
            if (n == 1) {
                return 1;
            }

            return n * Factorial (n - 1);
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

        public static int ClimbStairs (int n) {
            if (n == 1) {
                return 1;
            }

            if (n == 2) {
                return 2;
            }

            var last = 2;
            var beforeLast = 1;
            var result = 2;

            for (var i = 3; i <= n; i++) {
                result = beforeLast + last;
                beforeLast = last;
                last = result;
            }

            return result;
        }

        public static int HammingDistance (int x, int y) {
            if (x == y) {
                return 0;
            }
            if (x < 0 || y < 0) {
                return 0;
            }
            var max = x < y ? y : x;
            var min = x < y ? x : y;

            var result = 0;

            while (max != 0) {
                var rMax = max % 2;
                var rMin = min % 2;

                if (rMax != rMin) {
                    result++;
                }

                max = max / 2;
                min = min / 2;
            }

            return result;
        }

        public static bool CheckPerfectNumber (int num) {
            if (num == 0 || num % 2 != 0) {
                return false;
            }

            var half = num / 2;
            var i = 2;

            var sum = 1;
            var list = new List<int> ();

            while (i < half) {
                var q = num / i;
                var r = num % i;

                if (list.IndexOf (i) > 0) {
                    break;
                }

                if (r == 0) {
                    list.Add (q);
                    list.Add (i);
                }

                i++;
            }

            for (var j = 0; j < list.Count; j++) {
                sum += list[j];
            }

            return sum == num;
        }

        // public bool CheckPerfectNumber(int num) {
        //     if(num <= 1)
        //     {
        //         return false;
        //     }        
        //     var sum = 1;        
        //     for(var i = 2; i <= Math.Sqrt(num); i++)
        //     {
        //         if(num % i == 0)
        //         {
        //             sum += i;                
        //             if(i != num / i)
        //             {
        //                 sum += num / i;
        //             }            
        //         }
        //     }        
        //     return sum == num;
        // }

        public static IList<int> SelfDividingNumbers (int left, int right) {
            var result = new List<int> ();
            for (var i = left; i <= right; i++) {
                if (i % 10 == 0) {
                    continue;
                }

                var current = i;
                var isSelfDividNum = true;

                while (current > 0) {
                    var r = current % 10;
                    var q = current / 10;

                    if (r == 0 || i % r != 0) {
                        isSelfDividNum = false;
                        break;
                    }

                    current = q;
                }

                if (isSelfDividNum) {
                    result.Add (i);
                }
            }

            return result;
        }

        public static int MaximumProduct (int[] nums) {

            Array.Sort (nums);

            var topProduct = 1;

            for (var i = nums.Length - 1; i > nums.Length - 4; i--) {
                topProduct = topProduct * nums[i];
            }

            var lowProduct = 1;

            for (var i = 0; i < 2; i++) {
                lowProduct = lowProduct * nums[i];
            }

            lowProduct = lowProduct * nums[nums.Length - 1];

            return Math.Max (topProduct, lowProduct);
        }

        public static int MaxProduct (int[] nums) {
            int max = int.MinValue;

            for (int low = 0; low < nums.Length; low++) {
                int temp = 1;
                for (int fast = low; fast < nums.Length; fast++) {
                    temp = temp * nums[fast];
                    max = Math.Max (max, temp);
                }
            }
            return max;
        }

        public static bool IsPowerOfFour (int n) {
            if (n < 0) return false;
            var count = 0;

            if (n == 1) {
                n = n / 4;
            }

            while (n > 1) {
                //var q = n / 4;
                var r = n % 4;
                if (r != 0) {
                    count++;
                }
                n = n / 4;
            }

            return count == 0;
        }

        public static int SubtractProductAndSum (int n) {
            var sum = 0;
            var mul = 1;
            while (n > 0) {
                var digit = n % 10;
                sum += digit;
                mul *= digit;

                n = n / 10;
            }
            return Math.Abs (mul - sum);
        }

        public static bool IsUgly (int n) {
            var factors = new int[] { 2, 3, 5 };
            n = Math.Abs (n);
            while (n > 1) {
                for (var i = 0; i < factors.Length; i++) {
                    var r = n % factors[i];
                    var q = n / factors[i];

                    if (q != 0 && r == 0) {
                        n = n / factors[i];
                        break;
                    }
                    if (i == factors.Length - 1) {
                        return false;
                    }
                }
            }

            return true;
        }
        /*
        public bool IsUgly (int n) {
            if (n < 1)
                return false;
            while (true) {
                if (n % 2 == 0)
                    n = n / 2;

                else if (n % 3 == 0)
                    n = n / 3;

                else if (n % 5 == 0)
                    n = n / 5;

                else
                    break;
            }

            return n == 1;
        }
        */
    }

}