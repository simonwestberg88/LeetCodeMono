public class Solution
{
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ulong num1, num2;
        var number1 = GetNumber(l1);
        var number2 = GetNumber(l2);
        
        ulong.TryParse(number1, out num1);
        ulong.TryParse(number2, out num2);
        //todo add the numbers in a different way. need to handle numbers larger than ulong
        var add = num1 + num2;

        var sum = GetSumLinked(num1 + num2);
        return sum;
    }

    static ListNode GetSumLinked(ulong sum)
    {
        var sumString = sum.ToString();
        var length = sumString.Length;
        int val;
        var list = new List<ListNode>();
        for (var index = 0; index < length; index++)
        {
            int.TryParse("" +sumString[index], out val);

            if (index == 0)
            {
                var node = new ListNode(val, null);
                list.Add(node);
            }
            else
            {
                var node = new ListNode(val, list[index - 1]);
                list.Add(node);
            }
        }
        return list.Last();
    }

    public static string GetNumber(ListNode listNode)
    {
        var number = "";
        if (listNode.next != null)
        {
            number += GetNumber(listNode.next);
        }

        return number + listNode.val;

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