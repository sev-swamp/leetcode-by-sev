namespace LeetCode;

/// <summary>
/// LeetCode #560 — Subarray Sum Equals K
/// https://leetcode.com/problems/subarray-sum-equals-k/
/// Difficulty: Medium | Topic: Arrays, Hash Table, Prefix Sum
///
/// Problem:
///   Given an integer array nums and an integer k,
///   return the total number of subarrays whose sum equals k.
///
/// Algorithm: Prefix Sum + Hash Map
///   prefix[j] - prefix[i] = k  ⟺  prefix[i] = prefix[j] - k
///   Track how many times each prefix sum has been seen.
///   At each step, count how many prior prefix sums equal (current - k).
///
/// Time: O(n) | Space: O(n)
///
/// Trace for [1,1], k=2:
///   pairs={0:1}
///   i=0: sum=1, need=-1 → 0;  pairs={0:1, 1:1}
///   i=1: sum=2, need=0  → 1;  pairs={0:1, 1:1, 2:1}  answer=1 (wait) ...
///   Actually [1,1,1], k=2 → answer=2
/// </summary>
public static class SubarraySum
{
    public static int SubarraySumPrefics(int[] nums, int k)
    {
        int answer = 0;
        int sumvalue = 0;
        Dictionary<int, int> pairs = new Dictionary<int, int>();
        pairs[0] = 1;
        for (var i = 0; i <= nums.Length - 1; i++)
        {
            sumvalue += nums[i];
            var to_remove = sumvalue - k;
            answer += pairs.TryGetValue(to_remove, out int old) ? old : 0;
            var prev_sum = pairs.TryGetValue(sumvalue, out int value) ? value : 0;
            pairs[sumvalue] = prev_sum + 1;
        }
        return answer;
    }
}
