using LeetCodeTest.Questions;
using NUnit.Framework;
using src.Questions.Numers;

namespace tests.Questions {
    public class NumbersTests {

        [Test, Category ("NumbersTest")]
        [TestCase (0, 1),
            TestCase (1, 1),
            TestCase (2, 2),
            TestCase (3, 3),
            TestCase (4, 5),
            TestCase (5, 8)
        ]
        public void FibonacciSequenceTest (int n, int expected) {
            // actual
            var actual = NumbersTest.FibonacciSequence (n);
            // assert
            Assert.AreEqual (actual, expected);
        }

        [Test, Category ("NumbersTest")]
        [TestCase (0, 1),
            TestCase (1, 1),
            TestCase (2, 2),
            TestCase (3, 6),
            TestCase (4, 24),
            TestCase (5, 120)
        ]
        public void FactorialTest (int n, int expected) {
            // actual
            var actual = NumbersTest.Factorial (n);
            // assert
            Assert.AreEqual (actual, expected);
        }

        [Test, Category ("NumbersTest")]
        public void IsPrimeNumberTest () {
            // arrange
            var n = 2;
            var expected = true;
            // actual
            var actual = NumbersTest.IsPrimeNumber (n);
            // assert
            Assert.AreEqual (actual, expected);
        }

        // 204. Count Primes
        // https://leetcode.com/problems/count-primes/
        // sln: https://leetcode.com/problems/count-primes/discuss/721863/Java-easy-to-understand-with-explanation
        [Test, Category ("NumbersTest")]
        public void CountPrimesTest () {
            // arrange
            var n = 10;
            var expected = 4;
            // actual
            var actual = NumbersTest.CountPrimes (n);
            // assert
            Assert.AreEqual (actual, expected);
        }

        [Test]
        public void PowerOfThree_326Test () {
            var expected = false;

            var acutal = PowerOfThree_326.IsPowerOfThree (45);

            Assert.AreEqual (acutal, expected);
        }

        [Test]
        public void PowerOfOneBit_191Test () {
            var expected = 3;

            var acutal = PowerOfOneBit_191.HammingWeight (11);

            Assert.AreEqual (acutal, expected);
        }

        // 412. Fizz Buzz
        // https://leetcode.com/problems/fizz-buzz/
        // Write a program that outputs the string representation of numbers from 1 to n.
        // But for multiples of three it should output ��Fizz�� instead of the number and for the multiples of five output ��Buzz��. For numbers which are multiples of both three and five output ��FizzBuzz��.
        [Test, Category ("NumbersTest")]
        public void FizzBuzzTest () {
            // arrange
            var n = 15;
            var expected = false;
            // actual
            var actual = NumbersTest.FizzBuzz (n);
            // assert
            Assert.AreEqual (actual, expected);
        }

        //172. Factorial Trailing Zeroes
        // https://leetcode.com/problems/factorial-trailing-zeroes/
        // Given an integer n, return the number of trailing zeroes in n!.
        // Follow up: Could you write a solution that works in logarithmic time complexity?
        [Test, Category ("NumbersTest")]
        public void TrailingZeroesTest () {
            // arrange
            var n = 7;
            var expected = 0;
            // actual
            var actual = NumbersTest.TrailingZeroes (n);
            // assert
            Assert.AreEqual (actual, expected);
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

        // 69. Sqrt(x)
        // https://leetcode.com/problems/sqrtx/
        [Test, Category ("NumbersTest")]
        public void MySqrtTest () {
            // arrange
            //var n = 2147395599;
            //var expected = 46339;
            //var n = 8;
            //var expected = 2;
            var n = 4;
            var expected = 2;
            // actual
            var actual = NumbersTest.MySqrt (n);
            // assert
            Assert.AreEqual (actual, expected);
        }

        // 367. Valid Perfect Square
        // https://leetcode.com/problems/valid-perfect-square/
        [Test, Category ("NumbersTest")]
        public void IsPerfectSquareTest () {
            // arrange
            var n = 14;
            var expected = false;
            // actual
            bool actual = NumbersTest.IsPerfectSquare (n);
            // assert
            Assert.AreEqual (actual, expected);
        }

        // 118. Pascal's Triangle
        // https://leetcode.com/problems/pascals-triangle/
        [Test, Category ("NumbersTest")]
        public void GeneraTest () {
            // arrange
            //var n = 2147395599;
            //var expected = 46339;
            //var n = 8;
            //var expected = 2;
            var n = 5;
            var expected = 2;
            // actual
            var actual = NumbersTest.Generate (n);
            // assert
            Assert.AreEqual (actual, expected);
        }

        // 38. Count and Say
        [Test, Category ("NumbersTest")]
        [TestCase (5566, "2526"),
            TestCase (1422322, "1114221322"),
            TestCase (2222, "42")
        ]
        public void CountAndSayTest (int n, string expected) {
            // arrange

            // actual
            var actual = NumbersTest.CountAndSay (n);
            // assert
            Assert.AreEqual (actual, expected);
        }

        // 504. Base 7
        // https://leetcode.com/problems/base-7/
        [Test, Category ("NumbersTest")]
        [TestCase (100, "202"),
            TestCase (-7, "-10"),
            TestCase (-1, "-1")
        ]
        public void ConvertToBase7Test (int n, string expected) {
            // arrange

            // actual
            var actual = NumbersTest.ConvertToBase7 (n);
            // assert
            Assert.AreEqual (actual, expected);
        }

        // 278. First Bad Version
        //https://leetcode.com/problems/first-bad-version/
        [Test, Category ("NumbersTest")]
        public void VersionControlTest () {
            // arrange
            var n = 5;
            var expected = 4;
            // actual
            var actual = new VersionControl ().FirstBadVersion (n);
            // assert
            Assert.AreEqual (actual, expected);
        }

        // 70. Climbing Stairs
        // https://leetcode.com/problems/climbing-stairs/
        [Test, Category ("NumbersTest.ClimbStairs")]
        [TestCase (3, 3)]
        [TestCase (4, 5)]
        [TestCase (5, 8)]
        public void ClimbStairsTest (int n, int expected) {
            // arrange

            // actual
            var actual = NumbersTest.ClimbStairs (n);
            // assert
            Assert.AreEqual (actual, expected);
        }

        // 461. Hamming Distance
        // https://leetcode.com/problems/hamming-distance/
        [Test, Category ("NumbersTest")]
        [TestCase (1, 3, 1)]
        [TestCase (1, 4, 2)]
        public void HammingDistanceTest (int x, int y, int expected) {
            // arrange

            // actual
            var actual = NumbersTest.HammingDistance (x, y);
            // assert
            Assert.AreEqual (actual, expected);
        }

        // 507. Perfect Number
        // https://leetcode.com/problems/perfect-number/
        [Test, Category ("NumbersTest")]
        [TestCase (6, true)]
        [TestCase (4, false)]
        [TestCase (1, false)]
        [TestCase (2, false)]
        [TestCase (496, true)]
        [TestCase (8128, true)]
        [TestCase (120, false)]
        public void CheckPerfectNumberTest (int num, bool expected) {
            // arrange

            // actual
            var actual = NumbersTest.CheckPerfectNumber (num);
            // assert
            Assert.AreEqual (expected, actual);
        }

        // 728. Self Dividing Numbers
        // https://leetcode.com/problems/self-dividing-numbers/
        [TestCase (1, 22)]
        [TestCase (47, 85)]
        public void SelfDividingNumbersTest (int left, int right) {
            // arrange

            // actual
            var actual = NumbersTest.SelfDividingNumbers (left, right);
            // assert
            // Assert.AreEqual (actual, expected);
        }

        // 1281. Subtract the Product and Sum of Digits of an Integer
        // https://leetcode.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer/
        [TestCase (234, 15)]
        [TestCase (4421, 21)]
        public void SubtractProductAndSumTest (int n, int expected) {
            // arrange

            // actual
            var actual = NumbersTest.SubtractProductAndSum (n);
            // assert
            Assert.AreEqual (expected, actual);
        }

        // 628. Maximum Product of Three Numbers
        // https://leetcode.com/problems/maximum-product-of-three-numbers/
        [TestCase (new int[] { 3, 2, 1 }, 6)]
        [TestCase (new int[] { 1, 2, 3, 4 }, 24)]
        [TestCase (new int[] {-3, -2, -1 }, -6)]
        [TestCase (new int[] {-100, -98, -1, 2, 3, 4 }, 39200)]
        public void MaximumProductTest (int[] nums, int expected) {
            // arrange

            // actual
            var actual = NumbersTest.MaximumProduct (nums);
            // assert
            Assert.AreEqual (expected, actual);
        }

        // 152. Maximum Product Subarray
        // https://leetcode.com/problems/maximum-product-subarray/
        [TestCase (new int[] {-2 }, -2)]
        [TestCase (new int[] { 2, 3, -2, 4 }, 6)]
        [TestCase (new int[] {-2, 0, -1 }, 0)]
        public void MaxProductTest (int[] nums, int expected) {
            // arrange

            // actual
            var actual = NumbersTest.MaxProduct (nums);
            // assert
            Assert.AreEqual (expected, actual);
        }

        // 342. Power of Four
        // https://leetcode.com/problems/power-of-four/
        [TestCase (6, false)]
        [TestCase (2, false)]
        [TestCase (1, true)]
        [TestCase (16, true)]
        [TestCase (17, false)]
        public void IsPowerOfFourTest (int n, bool expected) {
            // arrange

            // actual
            var actual = NumbersTest.IsPowerOfFour (n);
            // assert
            Assert.AreEqual (expected, actual);
        }

        // 263. Ugly Number
        // https://leetcode.com/problems/ugly-number/
        [TestCase (1, true)]
        [TestCase (4, true)]
        [TestCase (7, false)]
        [TestCase (8, true)]
        [TestCase (14, false)]
        public void IsUglyTest (int n, bool expected) {
            // actual
            var actual = NumbersTest.IsUgly (n);
            // assert
            Assert.AreEqual (expected, actual);
        }

        // 338. Counting Bits
        // https://leetcode.com/problems/counting-bits/
        [TestCase (2, new int[] { 0, 1, 1 })]
        public void CountBitsTest (int n, int[] expected) {
            // actual
            var actual = NumbersTest.CountBits (n);
            // assert
            Assert.AreEqual (expected, actual);
        }
        
        [TestCase (5, new int[] { 0, 1, 1 })]
        public void CountBits2Test (int n, int[] expected) {
            // actual
            var actual = NumbersTest.CountBits2 (n);
            // assert
            Assert.AreEqual (expected, actual);
        }
    }
}