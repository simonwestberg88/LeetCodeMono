
// var n1_3 = new Solution.ListNode(3,null);
// var n1_2 = new Solution.ListNode(4,n1_3);
// var n1_1 = new Solution.ListNode(2, n1_2);
//
// var n2_3 = new Solution.ListNode(4,null);
// var n2_2 = new Solution.ListNode(6, n2_3);
// var n2_1 = new Solution.ListNode(5, n2_2);

var n1_1 = new Solution.ListNode(9, null);

//1: 0,
//9: 1
//9: 2
//9: 3,
//9: 4,
//9: 5,
//9: 6,
//9: 7
//9: 8
//9: 9]
// var n2_9 = new Solution.ListNode(9, null);
// var n2_8 = new Solution.ListNode(9, n2_9);
// var n2_7 = new Solution.ListNode(9, n2_8);
// var n2_6 = new Solution.ListNode(9, n2_7);
// var n2_5 = new Solution.ListNode(9, n2_6);
// var n2_4 = new Solution.ListNode(9, n2_5);
// var n2_3 = new Solution.ListNode(9, n2_4);
// var n2_2 = new Solution.ListNode(9, n2_3);
// var n2_1 = new Solution.ListNode(9, n2_2);
// var n2_0 = new Solution.ListNode(1, n2_1);
//
// Console.WriteLine("Number1: {0}", Solution.GetNumber(n1_1));
// Console.WriteLine("Number2: {0}", Solution.GetNumber(n2_0));
//
//
//
// var sum = Solution.AddTwoNumbers(n1_1, n2_0);
// Console.WriteLine("sum : {0}", Solution.GetNumber(sum));

var n1 = ConvertIntList(new[]
    {
        1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1
    }
);
var n2 = ConvertIntList(new[] { 5, 6, 4 });
Console.WriteLine("Number1: {0}, Number2: {1}", Solution.GetNumber(n1), Solution.GetNumber(n2));
var solution = Solution.AddTwoNumbers(n1,n2);

Console.WriteLine(Solution.GetNumber(solution));

static Solution.ListNode ConvertIntList(int[] list)
{
    var reverse = list.Reverse().ToList();
    var index = 0;
    var listOfListNode = new List<Solution.ListNode>();
    foreach (var val in reverse)
    {
        if (index == 0)
        {
            listOfListNode.Add(new Solution.ListNode(val, null));
        }
        else
        {
            listOfListNode.Add(new Solution.ListNode(val, listOfListNode[index-1]));
        }
        index++;
    }

    return listOfListNode.Last();
}