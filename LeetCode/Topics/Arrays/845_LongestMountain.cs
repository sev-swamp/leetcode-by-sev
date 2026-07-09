namespace LeetCode;

/// <summary>
/// LeetCode #845 — Longest Mountain in Array
/// https://leetcode.com/problems/longest-mountain-in-array/
/// Difficulty: Medium | Topic: Arrays, Two Pointers
///
/// Problem:
///   Find the length of the longest subarray that forms a mountain:
///   strictly increasing then strictly decreasing, minimum 3 elements.
///   Return 0 if no mountain exists.
///
/// Algorithm: Single Pass
///   Track consecutive up-steps and down-steps. When direction changes
///   or a plateau is found, reset the counters.
///
/// Time: O(n) | Space: O(1)
/// </summary>
public static class LongestMountain
{
    public static int LongestMountains(int[] arr)
    {
        int maxlength = 0;

        if (arr.Length < 3) return maxlength;
        int index = 0;
        int up = 0;
        int down = 0;
        while (index < arr.Length - 1)
        {
            if (arr[index] == arr[index + 1])
            {
                up = 0;
                down = 0;
            }

            if (arr[index] < arr[index + 1])
            {
                if (down == 0)
                {
                    up += 1;
                    down = 0;
                }
                else
                {
                    up = 1;
                    down = 0;
                }
            }

            if (arr[index] > arr[index + 1])
                down += 1;
            if (up > 0 && down > 0)
                maxlength = Math.Max(maxlength, up + down + 1);
            index++;
        }
        return maxlength;
    }
}
