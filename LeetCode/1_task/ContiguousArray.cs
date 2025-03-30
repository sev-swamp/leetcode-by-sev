namespace LeetCode;

/// <summary>
/// https://leetcode.com/problems/contiguous-array/
/// </summary>
public static class ContiguousArray
{

    // O(n)
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