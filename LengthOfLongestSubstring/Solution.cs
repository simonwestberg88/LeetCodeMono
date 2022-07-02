namespace LengthOfLongestSubstring;

public class Solution
{
    public static int LengthOfLongestSubstring(string s)
    {
        if(s.Length == 0) return 0;
        var charList = new List<char>();
        var len = 1;
        for (var i = 0; i < s.Length; i++)
        {
            if(!charList.Contains(s[i]))
            {
                charList.Add(s[i]);
                if (len < charList.Count)
                {
                    len = charList.Count;
                }
            }
            else
            {
                if (len < charList.Count)
                {
                    len = charList.Count;
                }
                charList = GetSubList(charList, s[i]);
            }
        }
        return len;
    }

    private static List<char> GetSubList(List<char> charList, char c)
    { 
        var indexOfChar = charList.IndexOf(c);
        var skip = indexOfChar + 1;
        charList = charList.Skip(skip).ToList();
        charList.Add(c);
        return charList;
    }
}