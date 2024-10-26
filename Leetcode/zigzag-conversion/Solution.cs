namespace zigzag_conversion;

public static class Solution {
    public static string Convert(string s, int numRows)
    {
        var lists = new List<char>[numRows];
        for (var i = 0; i < numRows; i++)
        {
            lists[i] = [];
        }
        var index = 0;
        var k = 1;
        foreach (var c in s)
        {
            lists[index].Add(c);
            if (numRows == 1)
            {
                continue;
            }
            if (index == numRows-1)
            {
                k = -1;
            }

            if (index == 0)
            {
                k = 1;
            }
            index += k;
        }
        var retString = string.Empty;
        foreach (var list in lists)
        {
            retString += string.Concat(list);
        }
        return retString;
    }
}