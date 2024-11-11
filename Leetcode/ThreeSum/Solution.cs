using System.Collections;

namespace ThreeSum;

public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var hashSet = new HashSet<(int, int, int)>();
        var posDic = new Dictionary<int, int>();
        var negDic = new Dictionary<int, int>();
        var num0 = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            switch (nums[i])
            {
                case 0:
                    num0 += 1;
                    continue;
                case > 0:
                {
                    posDic[nums[i]] = posDic.TryGetValue(nums[i], out var added) ? added + 1 : 1;
                    break;
                }
                default:
                {
                    negDic[nums[i]] = negDic.TryGetValue(nums[i], out var added) ? added + 1 : 1;
                    break;
                }
            }
        }

        foreach (var pos in posDic)
        {
            var posVal = pos.Key;
            // check if negative value exists in negative dic
            var negPair = pos.Key * -1;
            if (negDic.TryGetValue(negPair, out _) && num0 > 0)
            {
                hashSet.Add((negPair, 0, pos.Key));
            }

            foreach (var neg in negDic)
            {
                var negValue = neg.Key;
                var left = (neg.Key + pos.Key) * -1;
                if (left == pos.Key)
                {
                    if (pos.Value > 1) hashSet.Add((neg.Key, pos.Key, pos.Key));
                    continue;
                }

                if (left == neg.Key)
                {
                    if (neg.Value > 1) hashSet.Add((neg.Key, neg.Key, pos.Key));
                    continue;
                }

                if (negDic.TryGetValue(left, out _))
                {
                    var first = 0;
                    var second = 0;
                    if (neg.Key < left)
                    {
                        first = neg.Key;
                        second = left;
                    }
                    else
                    {
                        first = left;
                        second = neg.Key;
                    }
                    hashSet.Add((first, second, pos.Key));
                }
                else if (posDic.TryGetValue(left, out _))
                {
                    var first = 0;
                    var second = 0;
                    if (left < pos.Key)
                    {
                        first = left;
                        second = pos.Key;
                    }
                    else
                    {
                        first = pos.Key;
                        second = left;
                    }
                    hashSet.Add((neg.Key, first, second));
                }
            }
        }

        var ret = new List<IList<int>>();
        if (num0 >= 3)
        {
            ret.Add([0,0,0]);
        }

        foreach (var hSet in hashSet)
        {
            ret.Add([hSet.Item1, hSet.Item2, hSet.Item3]);
        }

        return ret;
    }
}