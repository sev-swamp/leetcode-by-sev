namespace LeetCode;

/// <summary>
/// https://leetcode.com/problems/find-pivot-index/
/// </summary>
public static class PivotIndex
{
    //O{n} - 
    public static int PivotsIndex(int[] nums)
    {
        int left_total = 0;
        int right_total = nums.Sum();

        for (int i = 0; i < nums.Length; i++)
        {
            right_total -= nums[i];
            if (right_total == left_total)
                return i;
            left_total += nums[i];
        }
        return -1;
    }
}