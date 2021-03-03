using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTest.Questions.LinkedListTest {
    public class ListTest {
        public static ListNode GetIntersectionNode (ListNode headA, ListNode headB) {

            var lengthA = GetLength (headA);
            var lengthB = GetLength (headB);
            ListNode result = null;
            var diff = lengthA - lengthB;
            var skip = Math.Abs (diff);

            if (diff < 0) {
                while (skip > 0) {
                    headB = headB.next;
                    skip--;
                }
            } else {
                while (skip > 0) {
                    headA = headA.next;
                    skip--;
                }
            }

            while (headA != null) {
                if (headA.val == headB.val) {
                    result = headA;
                    break;
                }
                headB = headB.next;
                headA = headA.next;
            }

            return result;
        }

        private static int GetLength (ListNode listNode) {
            var result = 0;
            while (listNode != null) {
                result++;
                listNode = listNode.next;
            }
            return result;
        }

        private static int[] GetNewArray (ListNode listNode) {
            var result = new List<int> ();
            while (listNode != null) {
                result.Add (listNode.val);
                listNode = listNode.next;
            }
            return result.ToArray ();
        }

        public static ListNode MergeTwoLists (ListNode l1, ListNode l2) {

            if (l1 == null || l2 == null) {
                return null;
            }

            ListNode result = null;

            while (l1 != null) {

                while (l2 != null) {
                    if (l1.val > l2.val) {
                        if (result is null) {
                            result = new ListNode (l2.val);
                        } else {
                            result.next = l2;
                        }
                        break;
                    } else {
                        if (result is null) {
                            result = new ListNode (l1.val);
                        } else {
                            result.next = l1;
                        }
                    }
                    l2 = l2.next;
                }
                
                l1 = l1.next;
            }

            return result;
        }
    }
}