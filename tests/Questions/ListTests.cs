using LeetCodeTest.Questions.LinkedListTest;
using NUnit.Framework;

namespace tests.Questions
{
    public class ListTests
    {
        // 160. Intersection of Two Linked Lists
        // https://leetcode.com/problems/intersection-of-two-linked-lists/submissions/
        [Test, Category("ListTest")]
        public void GetIntersectionNodeTest()
        {

            var headA = new ListNode(4);
            headA.next = new ListNode(1);
            headA.next.next = new ListNode(8);
            headA.next.next.next = new ListNode(4);
            headA.next.next.next.next = new ListNode(5);

            var headB = new ListNode(5);
            headB.next = new ListNode(6);
            headB.next.next = new ListNode(1);
            headB.next.next.next = new ListNode(8);
            headB.next.next.next.next = new ListNode(4);
            headB.next.next.next.next.next = new ListNode(5);

            // var headA = new ListNode(8);

            // var headB = new ListNode(4);
            // headB.next = new ListNode(1);
            // headB.next.next = new ListNode(8);
            // headB.next.next.next = new ListNode(4);
            // headB.next.next.next.next = new ListNode(5);

            // actual
            var actual = ListTest.GetIntersectionNode(headA, headB);
            // assert
            //Assert.AreEqual(actual, expected);
        }

        // 21. Merge Two Sorted Lists
        // https://leetcode.com/problems/merge-two-sorted-lists/
        [Test, Category("ListTest")]
        public void MergeTwoListsTest()
        {

            var l1 = new ListNode(1);
            //l1.next = new ListNode(2);
            //l1.next.next = new ListNode(4);

            //ListNode l1 = null;

            //var l2 = new ListNode(1);
            //l2.next = new ListNode(3);
            //l2.next.next = new ListNode(4);

            //var l2 = new ListNode(0);

            ListNode l2 = null;

            // actual
            var actual = ListTest.MergeTwoLists(l1, l2);
            // assert
            //Assert.AreEqual(actual, expected);
        }

        // 206. Reverse Linked List
        // https://leetcode.com/problems/reverse-linked-list/
        [Test, Category("ListTest")]
        public void ReverseListTest()
        {

            var head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);

            // actual
            var actual = ListTest.ReverseList(head);
            // assert
            //Assert.AreEqual(actual, expected);
        }

        // 234. Palindrome Linked List
        // https://leetcode.com/problems/palindrome-linked-list/
        [Test, Category("ListTest")]
        public void IsPalindromeTest()
        {

            var head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(2);
            // head.next.next.next.next = new ListNode(1);

            // actual
            var actual = ListTest.IsPalindrome(head);
            // assert
            //Assert.AreEqual(actual, expected);
        }

        // 2. Add Two Numbers
        // https://leetcode.com/problems/add-two-numbers/submissions/
        [Test, Category("ListTest")]
        public void AddTwoNumbersTest()
        {

            // var l1 = new ListNode (2);
            // l1.next = new ListNode (4);
            // l1.next.next = new ListNode (3);

            // var l2 = new ListNode (5);
            // l2.next = new ListNode (6);
            // l2.next.next = new ListNode (4);

            var l1 = new ListNode(9);
            l1.next = new ListNode(9);
            l1.next.next = new ListNode(9);
            l1.next.next.next = new ListNode(9);
            l1.next.next.next.next = new ListNode(9);
            l1.next.next.next.next.next = new ListNode(9);
            l1.next.next.next.next.next.next = new ListNode(9);

            var l2 = new ListNode(9);
            l2.next = new ListNode(9);
            l2.next.next = new ListNode(9);
            l2.next.next.next = new ListNode(9);

            // var l1 = new ListNode (0);
            // var l2 = new ListNode (0);

            // actual
            var actual = ListTest.AddTwoNumbers(l1, l2);
            // assert
            //Assert.AreEqual(actual, expected);
        }

        // 141. Linked List Cycle
        // https://leetcode.com/problems/linked-list-cycle/
        [Test, Category("ListTest")]
        public void HasCycleTest()
        {
            var head = new ListNode(3);
            //head.next = new ListNode(2);
            //head.next.next = new ListNode(0);
            //head.next.next.next = new ListNode(9);
            //head.next.next.next.next = new ListNode(9);
            //head.next.next.next.next.next = new ListNode(9);
            //head.next.next.next.next.next.next = new ListNode(9);


            // actual
            var actual = ListTest.HasCycle(head);
            // assert
            //Assert.AreEqual(actual, expected);
        }
    }
}