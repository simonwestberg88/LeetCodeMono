namespace ReverseInteger;

public class Solution
{
    public int Reverse(int x)
    {
        if (x == 0) return 0;
        if (x == 1) return 1;
        var rList = new List<int>();
        for (var i = 0; i < 9; i++)
        {
            var digit = x % 10;
            rList.Add(digit);
            x /= 10;
            if (x == 0) break;
        }

        var newInt = 0;
        var mult = 1;
        for (var j = rList.Count -1; j >= 0; j--)
        {
            newInt += rList[j] * mult;
            mult *= 10;
        }
        return newInt;
    }
}