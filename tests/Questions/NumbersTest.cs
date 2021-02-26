using LeetCodeTest.Questions;
using NUnit.Framework;
using src.Questions.Numers;

namespace tests.Questions
{
    public class NumbersTests
    {
        [Test, Category("NumbersTest")]
        public void IsPrimeNumberTest()
        {
            // arrange
            var n = 2;
            var expected = true;
            // actual
            var actual = NumbersTest.IsPrimeNumber(n);
            // assert
            Assert.AreEqual(actual, expected);
        }

        // 204. Count Primes
        // https://leetcode.com/problems/count-primes/
        // sln: https://leetcode.com/problems/count-primes/discuss/721863/Java-easy-to-understand-with-explanation
        [Test, Category("NumbersTest")]
        public void CountPrimesTest()
        {
            // arrange
            var n = 10;
            var expected = 4;
            // actual
            var actual = NumbersTest.CountPrimes(n);
            // assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void PowerOfThree_326Test()
        {
            var expected = false;

            var acutal = PowerOfThree_326.IsPowerOfThree(45);

            Assert.AreEqual(acutal, expected);
        }

        [Test]
        public void PowerOfOneBit_191Test()
        {
            var expected = 3;

            var acutal = PowerOfOneBit_191.HammingWeight(11);

            Assert.AreEqual(acutal, expected);
        }

        // 412. Fizz Buzz
        // https://leetcode.com/problems/fizz-buzz/
        // Write a program that outputs the string representation of numbers from 1 to n.
        // But for multiples of three it should output ��Fizz�� instead of the number and for the multiples of five output ��Buzz��. For numbers which are multiples of both three and five output ��FizzBuzz��.
        [Test, Category("NumbersTest")]
        public void FizzBuzzTest()
        {
            // arrange
            var n = 15;
            var expected = false;
            // actual
            var actual = NumbersTest.FizzBuzz(n);
            // assert
            Assert.AreEqual(actual, expected);
        }

        //172. Factorial Trailing Zeroes
        // https://leetcode.com/problems/factorial-trailing-zeroes/
        // Given an integer n, return the number of trailing zeroes in n!.
        // Follow up: Could you write a solution that works in logarithmic time complexity?
        [Test, Category("NumbersTest")]
        public void TrailingZeroesTest()
        {
            // arrange
            var n = 7;
            var expected = 0;
            // actual
            var actual = NumbersTest.TrailingZeroes(n);
            // assert
            Assert.AreEqual(actual, expected);
        }

        // 7. Reverse Integer
        // https://leetcode.com/problems/reverse-integer/
        // Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.
        //[Test, Category("NumbersTest")]
        //public void ReverseTest()
        //{
        //    // arrange
        //    var n = -2147483648;
        //    var expected = 321;
        //    // actual
        //    var actual = NumbersTest.Reverse(n);
        //    // assert
        //    Assert.AreEqual(actual, expected);
        //}
    }
}