using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTest.Questions.LinkedListTest
{
    public class ListTest
    {
        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            var result = new ListNode(0);

            //var arrA = GetArray(headA);
            //var arrB = GetArray(headB);

            while (headA.next != null)
            {
                if (headA.val == headB.val)
                {
                    result.val = headA.val;
                    break;
                }
                headA = headA.next;
            }

            return result;
        }

        //private object GetArray(ListNode headA)
        //{

        //}
    }
}
