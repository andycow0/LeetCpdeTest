using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTest.Questions.LinkedListTest {
    public class ListTest {
        public static ListNode GetIntersectionNode (ListNode headA, ListNode headB) {

            while (headA != null) {
                ListNode pB = headB;
                while (pB != null) {
                    if (headA.val == pB.val)
                        return headA;
                    pB = pB.next;
                }
                headA = headA.next;
            }
            return null;
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
            var result = new ListNode ();
            var current = result;

            while (l1 != null || l2 != null) {
                if (l1 == null || (l2 != null && l1.val > l2.val)) {
                    current.next = l2;
                    l2 = l2.next;
                } else {
                    current.next = l1;
                    l1 = l1.next;
                }
                current = current.next;
            }

            return result.next;
        }

        public static ListNode ReverseList (ListNode head) {

            ListNode result = null;
            while (head != null) {
                var last = result;
                result = new ListNode (head.val);
                result.next = last;

                head = head.next;
            }

            return result;
        }

        public static bool IsPalindrome (ListNode head) {

            var list = new List<int> ();

            while (head != null) {
                list.Add (head.val);
                head = head.next;
            }

            var idx = 0;
            var count = list.Count;
            while (idx < (count / 2 + 1)) {
                if (list[idx] != list[count - idx - 1]) {
                    return false;
                }
                idx++;
            }

            return true;
        }

        public static ListNode AddTwoNumbers (ListNode l1, ListNode l2) {

            // var list1 = new List<int> ();
            // var list2 = new List<int> ();
            var sum1 = 0;
            var sum2 = 0;
            var count = 1;
            while (l1 != null || l2 != null) {

                if (l1 != null) {
                    sum1 = sum1 * 10 + l1.val;
                }

                if (l2 != null) {
                    sum2 = sum2 * 10 + l2.val;
                }
                l1 = l1 is null ? null : l1.next;
                l2 = l2 is null ? null : l2.next;

                if ((l1 is null) && (l2 is null)) {
                    break;
                }

                count++;
            }

            var result = new ListNode (0);
            var current = result;
            var sum = sum1 + sum2;
            if (sum == 0) {
                return result;
            }
            while (sum > 0) {
                current.next = new ListNode (sum % 10);
                sum = sum / 10;
                count--;
                current = current.next;
            }

            return result.next;
        }
    }
}