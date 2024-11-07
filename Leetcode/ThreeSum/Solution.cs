using System.Collections;

namespace ThreeSum;

public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var hashSet = new HashSet<(int, int, int)>();
        var ret = new List<IList<int>>();
        for (var i = 0; i < nums.Length - 2; i++)
        {
            for (var j = i + 1; j < nums.Length - 1; j++)
            {
                for (var k = j + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[j] + nums[k] != 0) continue;
                    var list = new List<int> { nums[i], nums[j], nums[k] };
                    list.Sort();
                    hashSet.Add((list[0], list[1], list[2]));
                }
            }
        }

        foreach (var hash in hashSet)
        {
            ret.Add(new List<int>{hash.Item1, hash.Item2, hash.Item3});
        }

        return ret;
    }
}