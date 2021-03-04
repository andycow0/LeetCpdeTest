using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTest.Questions.LinkedListTest
{
    //public class ListNode
    //{
    //    public int val;
    //    public ListNode next;
    //    public ListNode(int x) { val = x; }
    //}

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
