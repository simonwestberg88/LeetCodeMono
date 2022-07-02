public class Solution
{
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        return AddThem(l1, l2, 0);
    }

    private static ListNode? AddThem(ListNode? l1, ListNode? l2, int carry)
    {
        if (l1 == null && l2 == null && carry == 0)
        {
            return null;
        }

        var val1 = l1?.val ?? +0;
        var val2 = l2?.val ?? +0;
        var totalVal = val1 + val2 + carry;
        var val = totalVal % 10;
        var nextCarry = totalVal / 10;
        
        var sumNode = new ListNode(val, AddThem(l1?.next, l2?.next, nextCarry));
        return sumNode;
    }
    
    
    

    
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