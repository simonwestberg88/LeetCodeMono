namespace ContainerWithMostWater;

public class Solution
{
    public int MaxArea(int[] height)
    {
        var max = 0;
        var leftList = new List<int>();
        var rightList = new List<int>();
        var lMax = 0;
        var rMax = 0;
        // store indexes of highest values left to right and right to left
        for (var i = 0; i < height.Length; i++)
        {
            var l = height[i];
            if (l > lMax)
            {
                leftList.Add(i);
                lMax = l;
            }

            var r = height[^(i + 1)];
            if (r > rMax)
            {
                rightList.Add(height.Length - 1 - i);
                rMax = r;
            }
        }

        //calculate the max from the two listsfor (var j = 1; j < height.Length; j++)
        for (var i = 0; i < leftList.Count; i++)
        {
            var indexLeft = leftList[i];
            var a = height[indexLeft];
            for (var j = 0; j < rightList.Count; j++)
            {
                var indexRight = rightList[j];
                if (indexLeft >= indexRight) return max;
                var b = height[indexRight];
                var lowest = int.Min(a, b);
                var length = indexRight - indexLeft;
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