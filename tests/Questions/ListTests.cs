using LeetCodeTest.Questions.LinkedListTest;
using NUnit.Framework;

namespace tests.Questions
{
    public class ListTests
    {
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

            var expected = 2;
            // actual
            var actual = ListTest.GetIntersectionNode(headA, headB);
            // assert
            //Assert.AreEqual(actual, expected);
        }
    }
}