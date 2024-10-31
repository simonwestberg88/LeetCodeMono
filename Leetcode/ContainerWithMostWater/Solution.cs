namespace ContainerWithMostWater;

public class Solution
{
    public int MaxArea(int[] height)
    {
        var max = 0;
        for (var i = 0; i < height.Length; i++)
        {
            var a = height[i];
            for (var j = 1; j < height.Length; j++)
            {
                var b = height[^j];
                var lowest = int.Min(a, b);
                var length = height.Length - j - i;
                var area = lowest * length;
                if (area > max)
                {
                    max = area;
                }
            }
        }

        return max;
    }
}