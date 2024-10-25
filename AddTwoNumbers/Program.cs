



// var n1 = ConvertIntList(new[]
//     {
//         1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1
//     }
// );
var n1 = ConvertIntList(new[] { 1, 2, 3 });
var n2 = ConvertIntList(new[] { 5, 6, 8 });

var solution = Solution.AddTwoNumbers(n1, n2);



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