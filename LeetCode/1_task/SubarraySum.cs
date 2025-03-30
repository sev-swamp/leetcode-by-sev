namespace LeetCode;

/// <summary>
/// https://leetcode.com/problems/subarray-sum-equals-k/description/
/// </summary>
public static class SubarraySum
{
    // O(n)
    public static int SubarraySumPrefics(int[] nums, int k)
    {
        int answer = 0;
        int sumvalue = 0;
        Dictionary<int, int> pairs = new Dictionary<int, int>();
        pairs[0] = 1;
        for (var i = 0; i <= nums.Length - 1; i++)
        {
            sumvalue += nums[i];
            var to_temove = sumvalue - k;
            answer += pairs.TryGetValue(to_temove, out int old) ? old : 0;
            var prev_sum = pairs.TryGetValue(sumvalue, out int value) ? value : 0;
            pairs[sumvalue] = prev_sum + 1;
        }
        return answer;
    }
}
// [1,1] , 2
//                   pair = {0,1}
// 1,   1 - 2 = -1   pair = {0,1} {1,1}                         0
// 1,   2 - 2 = 0    pair = {0,1} {1,1} {2,1}                   1
// 1,   3 - 2 = 0    pair = {0,1} {1,1} {2,1} {3,1}             2

// |___to_temove___|_______k_________|
// 0            sumvalue             i
//
//