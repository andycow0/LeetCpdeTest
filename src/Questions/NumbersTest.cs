using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeTest.Questions
{
    public class NumbersTest
    {
        public static IList<string> FizzBuzz(int n)
        {
            var result = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                if (i % 15 == 0)
                {
                    result.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    result.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add(i.ToString());
                }
            }

            return result;
        }

        public static bool IsPrimeNumber(int n)
        {
            var m = n / 2;
            var isFlag = false;

            for (int i = 2; i < m; i++)
            {
                if (m % i == 0)
                {
                    return false;
                }
                else
                {
                    n = n / i;
                }

                if (isFlag)
                {
                    return true;
                }
            }

            return false;
        }

        public static int TrailingZeroes(int n)
        {
            if (n < 1)
            {
                return 0;
            }

            var factorial = 1;

            while (n > 0)
            {
                factorial = factorial * n;
                n--;
            }

            var result = factorial.ToString();

            return result.Where(s => s == '0').Any() ? 1 : 0;
        }

        public static int Reverse(int x)
        {

            if (x < -1 * int.MaxValue ||
                x > int.MaxValue)
            {
                return 0;
            }

            long result = 0;

            var absN = Math.Abs(x);

            while (absN != 0)
            {
                result = result * 10 + absN % 10;
                absN = absN / 10;
            }

            if (result < -1 * Math.Pow(2, 31) ||
                result > Math.Pow(2, 31) - 1)
            {
                return 0;
            }

            return x > 0 ? (int)result : (int)result * -1;
        }
    }
}