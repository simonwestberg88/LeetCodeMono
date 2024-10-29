namespace PalindromeNumber;

public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        var numString = x.ToString();
        var middle = numString.Length / 2;

        for (var i = 0; i < numString.Length / 2; i++)
        {
            var a = numString[i];
            var b = numString[^(i+1)];
            if (a != b)
            {
                return false;
            }
        }

        return true;
    }
}