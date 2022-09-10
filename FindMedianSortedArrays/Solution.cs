namespace FindMedianSortedArrays;

public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {

        //get length of both arrays
        //get median of both arrays
        // if median of longer 
        var totalLength = nums1.Length + nums2.Length;




        return 0;
    }

    decimal GetMedian(int[] nums)
    {
        var length = nums.Length;
        decimal median = nums[length/2];
        if (IsEven(nums.Count()))
        {
            var i = nums.Count() / 2;
            median = (decimal)(nums[i - 1] + nums[i]) / 2;
        }
        return median;
    }

    bool IsEven(int num) => num % 2 == 0;
}