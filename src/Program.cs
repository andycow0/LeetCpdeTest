using System;
using LeetCodeTest.ArrayTest;
using LeetCpdeTest.Questions.Numers;

namespace LeetCodeTest {
    class Program {
        static void Main (string[] args) {
            var twoSumNums = new int[4] { 2, 7, 11, 15 };
            var target = 9;
            var twoSumResult = TwoSum_1.TwoSum(twoSumNums, 9);

            var a = "THIS";
            Console.WriteLine (a.Length);
            Console.WriteLine (ArrayObj.ToLowerCaseString (a));

            var s = "This is a test.";
            var t = ", and this is as well.";
            Console.WriteLine (String.Join (s, t.ToCharArray ()));

            Console.ReadLine ();
        }
    }
}