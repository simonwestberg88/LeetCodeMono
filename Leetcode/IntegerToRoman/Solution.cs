namespace IntegerToRoman;

public class Solution
{
    public string IntToRoman(int num)
    {
        var dict = new Dictionary<int, string>();
        dict[1] = "I";
        dict[4] = "IV";
        dict[5] = "V";
        dict[9] = "IX";
        dict[10] = "X";
        dict[40] = "XL";
        dict[50] = "L";
        dict[90] = "XC";
        dict[100] = "C";
        dict[400] = "CD";
        dict[500] = "D";
        dict[900] = "CM";
        dict[1000] = "M";
        var s = new Stack<string>();
        for (var i = 0; i < 4; i++)
        {
            if (num == 0) break;
            var mod = num % 10;
            num = num / 10;
            var mult = (int)Math.Pow(10, i);
            if (mod is 4 or 9 or 5)
            {
                s.Push(dict[mod * mult]);
                continue;
            }

            if (mod == 0)
            {
                continue;
            }

            if (mod < 4)
            {
                for (var j = 0; j < mod; j++)
                {
                    s.Push(dict[mult]);
                }

                continue;
            }

            var mod5 = mod % 5;
            var t = mult * 5;
            for (var k = 0; k < mod5; k++)
            {
                s.Push(dict[mult]);
            }
            s.Push(dict[t]);
        }

        var ret = "";
        while(s.TryPop(out var c))
        {
            ret += c;
        }

        return ret;
    }
}