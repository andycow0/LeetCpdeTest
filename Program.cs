using System;
using LeetCodeTest.ArrayTest;

namespace LeetCodeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = "THIS";
            Console.WriteLine(a.Length);
            Console.WriteLine(ArrayObj.ToLowerCaseString(a));

            var s = "This is a test.";
            var t = ", and this is as well.";
            Console.WriteLine(String.Join(s, t.ToCharArray()));

            Console.ReadLine();
        }
    }
}
