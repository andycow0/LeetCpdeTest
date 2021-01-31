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
    }
}
