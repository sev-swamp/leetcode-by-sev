namespace LeetCode;

/// <summary>
/// LeetCode #525 — Contiguous Array
/// https://leetcode.com/problems/contiguous-array/
/// Difficulty: Medium | Topic: Arrays, Hash Table
///
/// Problem:
///   Given a binary array nums, return the maximum length of a contiguous
///   subarray with an equal number of 0 and 1.
///
/// Algorithm: Prefix Sum + Hash Map
///   Treat 0 as -1 and track a running sum. If sum[i] == sum[j],
///   the subarray between i+1 and j has equal 0s and 1s.
///
/// Time: O(n) | Space: O(n)
/// </summary>
public static class ContiguousArray
{
    public static int FindMaxLength(int[] nums)
    {
        Dictionary<int, int> countMap = new Dictionary<int, int>();
        int maxlen = 0;
        int sumval = 0;
        for (int i = 0; i <= nums.Length - 1; i++)
        {
            sumval = nums[i] == 0 ? sumval - 1 : sumval + 1;
            if (sumval == 0)
                maxlen = i + 1;
            if (countMap.ContainsKey(sumval))
                maxlen = Math.Max(maxlen, i - countMap[sumval]);
            else
                countMap[sumval] = i;
        }
        return maxlen;
    }
}
