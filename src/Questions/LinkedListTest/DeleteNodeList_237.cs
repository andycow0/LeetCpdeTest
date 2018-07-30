namespace src.Questions.LinkedListTest {
    // Definition for singly-linked list.
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode (int x) { val = x; }
    }
    public class DeleteNodeList_203 {
        public static ListNode RemoveElements (ListNode head, int val) {
            if (head == null) {
                return head;
            }

            ListNode node = new ListNode (0);
            var pre = head;
            node.next = head;
            do {
                if (pre.val == val) {
                    pre.val = pre.next.val;
                    pre.next = pre.next.next;
                } else {
                    node.val = pre.val;
                    node.next = pre.next;
                }
                pre = pre.next;
            } while (head.next != null);

            return node.next;
        }
    }
    public class DeleteNodeList_237 {
        private static ListNode listNode = new ListNode (4) {
            next = new ListNode (5) {
            next = new ListNode (1) {
            next = new ListNode (9) { }
            }
            }
        };

        public static void DeleteNode (ListNode node) {
            if (listNode.next != null && listNode.next.val != node.val) {
                DeleteNode (listNode.next);
            } else {
                listNode.next = listNode.next.next;
            }

        }
    }
}