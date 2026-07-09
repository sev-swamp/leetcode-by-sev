namespace LeetCode;

/// <summary>
/// LeetCode #724 — Find Pivot Index
/// https://leetcode.com/problems/find-pivot-index/
/// Difficulty: Easy | Topic: Arrays, Prefix Sum
///
/// Problem:
///   Find the leftmost index where the sum of all elements to its left
///   equals the sum of all elements to its right.
///   Return -1 if no such index exists.
///
/// Algorithm: Prefix Sum
///   Pre-compute total sum. Iterate left to right maintaining left_sum.
///   At each index: right_sum = total - left_sum - nums[i].
///   If right_sum == left_sum, return index.
///
/// Time: O(n) | Space: O(1)
/// </summary>
public static class PivotIndex
{
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
