using System;
using Classes.ObjserverPatterms;
using LeetCodeTest.ArrayTest;
using LeetCpdeTest.Questions.Numers;
using src.Classes;
using src.Questions.LinkedListTest;
using src.Questions.Numers;
using src.Questions.StringTest;

namespace LeetCodeTest {
    class Program {
        static void Main (string[] args) {
            // var twoSumNums = new int[4] { 2, 7, 11, 15 };
            // var target = 9;
            // var twoSumResult = TwoSum_1.TwoSum(twoSumNums, 9);
            // var z = "PAYPALISHIRING";

            // ObjserverPatterms.DelegatePractice ();
            var num = IntegerAddOrMinux.CountingIntegers (10);
            Console.WriteLine (num);
            // var humanA = new Human () { Age = 10, Name = "Andy" };
            // var humanB = new Human () { Age = 20, Name = "Ning" };
            // Console.WriteLine (humanA == humanB);

            // humanA = humanB;
            // Console.WriteLine (humanA == humanB);
            // Console.WriteLine ($"HumanA age is {humanA.Age}, HumanB age is {humanB.Age}");
            // Console.WriteLine ($"HumanA Name is {humanA.Name}, HumanB age is {humanB.Name}");

            // humanA.Age = 28;
            // humanA.Name = "Test";
            // Console.WriteLine ($"HumanA age is {humanA.Age}, HumanB age is {humanB.Age}");
            // Console.WriteLine ($"HumanA Name is {humanA.Name}, HumanB age is {humanB.Name}");

            // ListNode listNode = new ListNode (4) {
            //     next = new ListNode (5) {
            //     next = new ListNode (1) {
            //     next = new ListNode (9) { }
            //     }
            //     }
            // };
            // var aa = DeleteNodeList_203.RemoveElements (listNode, 9);
            // var isPowerOfTwo = PowerofTwo_231.IsPowerOfTwo (10);
            // MajorityElement_169.MajorityElement (new int[] { 1 });
            // ValidAnagram_242.IsAnagram ("anagram", "nagaram");

            // var nums = new int[] { };

            // var dupl = ContainsDuplicate_217.ContainsDuplicate(nums);

            // var addDigis = AddDigi258.AddDigits(38);

            // var a = "THIS";
            // Console.WriteLine (a.Length);
            // Console.WriteLine (ArrayObj.ToLowerCaseString (a));

            // var s = "This is a test.";
            // var t = ", and this is as well.";
            // Console.WriteLine (String.Join (s, t.ToCharArray ()));

            Console.ReadLine ();
        }
    }
}