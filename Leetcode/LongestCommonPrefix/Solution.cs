namespace LongestCommonPrefix;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 1) return strs[0];
        var longest = strs[0];
        for (var i = 1; i < strs.Length; i++)
        {
            if (strs[i].Length == 0) return "";
            var len = Math.Min(longest.Length, strs[i].Length);
            var n = "";
            for (var j = 0; j < len; j++)
            {
                if (longest[j] != strs[i][j])
                {
                    if (n.Length == 0) return "";
                    longest = n;
                    break;
                }

                n += longest[j];
            }

            longest = n;
        }

        return longest;
    }
}