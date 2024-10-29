using System.Text;

namespace MyAtio;

public class Solution
{
    public int MyAtoi(string s)
    {
        s = s.TrimStart();
        var list = new List<int>();
        long digit = 0;
        var sign = 1;
        var leadingZero = true;
        var max = new[] { 2, 1, 4, 7, 4, 8, 3, 6, 4, 7 };

        for (var i = 0; i < s.Length; i++)
        {
            if ((s[i] == '+' || s[i] == '-') && i == 0)
            {
                if (s[i] == '-') sign = -1;
                continue;
            }
            //skip leading zeros
            if(s[i] == '0' && leadingZero) continue;
            
            //if not a digit then return digit
            var a = s[i];
            if (a is < '0' or > '9')
            {
                break;
            }

            leadingZero = false;
            list.Add(a - '0');
        }
        if (list.Count > 10)
        {
            return sign == 1 ? int.MaxValue : int.MinValue;
        }

        if (list.Count == 10)
        {
            for (var i = 0; i < 10; i++)
            {
                var left = max[i] - list[i];
                switch (left)
                {
                    case < 0:
                        return sign == 1 ? int.MaxValue : int.MinValue;
                    case > 0:
                        i = 10;
                        break;
                } 
            }
        }

        for (var i = 0; i < list.Count; i++)
        {
            var pow = list.Count - (i + 1);
            var mul = (long)Math.Pow(10, pow);
            digit += list[i] * mul;
        }

        digit *= sign;
        return digit switch
        {
            > int.MaxValue => int.MaxValue,
            < int.MinValue => int.MinValue,
            _ => (int)digit
        };
    }
}