namespace ReverseInteger;

public class Solution
{
    public int Reverse(int x)
    {
        var min = new[] { 2, 1, 4, 7, 4, 8, 3, 6, 4, 8 };
        var max = new[] { 2, 1, 4, 7, 4, 8, 3, 6, 4, 7 };
        var sign = x < 0 ? -1 : 1;
        if (x == 0) return 0;
        if (x == 1) return 1;
        var rList = new List<int>();
        for (var i = 0; i < 10; i++)
        {
            var digit = x % 10;
            rList.Add(digit);
            x /= 10;
            if (x == 0) break;
        }

        var newInt = 0;
        var checkOverflow = rList.Count == 10;

        for (var j = 0; j < rList.Count; j++)
        {
            if (checkOverflow)
            {
                var left = max[j] - rList[j];
                switch (left)
                {
                    case < 0:
                        return 0;
                    case > 0:
                        checkOverflow = false;
                        break;
                }
            }

            var pow = rList.Count - (j + 1);
            var mul = (int)Math.Pow(10, pow);
            newInt += rList[j] * mul;
        }

        if (sign < 0 && newInt < 0 || sign > 0 && newInt > 0)
        {
            return newInt;
        }

        return 0;
    }
}