using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTest.Questions.LinkedListTest
{
    public class ListTest
    {
        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {

            var lengthA = GetLength(headA);
            var lengthB = GetLength(headB);
            ListNode result = null;
            var diff = lengthA - lengthB;
            var skip = Math.Abs(diff);

            if (diff < 0)
            {
                while (skip > 0)
                {
                    headB = headB.next;
                    skip--;
                }
            }
            else
            {
                while (skip > 0)
                {
                    headA = headA.next;
                    skip--;
                }
            }

            while (headA != null)
            {
                if (headA.val == headB.val)
                {
                    result = headA;
                    break;
                }
                headB = headB.next;
                headA = headA.next;
            }

            return result;
        }

        private static int GetLength(ListNode listNode)
        {
            var result = 0;
            while (listNode != null)
            {
                result++;
                listNode = listNode.next;
            }
            return result;
        }

        private static int[] GetNewArray(ListNode listNode)
        {
            var result = new List<int>();
            while (listNode != null)
            {
                result.Add(listNode.val);
                listNode = listNode.next;
            }
            return result.ToArray();
        }

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var result = new ListNode();
            var current = result;

            while (l1 != null || l2 != null)
            {
                if (l1 == null || (l2 != null && l1.val > l2.val))
                {
                    current.next = l2;
                    l2 = l2.next;
                }
                else
                {
                    current.next = l1;
                    l1 = l1.next;
                }
                current = current.next;
            }

            return result.next;
        }
    }
}