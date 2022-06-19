public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dictionary = new Dictionary<int, int>();
        var index = 0;
        var index2 = 0;
        foreach (int num in nums)
        {
            var otherNum = target - num;
            if (dictionary.TryGetValue(otherNum, out index2))
            {
                return new int[] {index2, index};
            }
            dictionary.TryAdd(num, index);

            index++;
        }
        return new int[] {1,1};
    }
    
}