namespace LeetCode;

/// <summary>
/// LeetCode #75 — Sort Colors
/// https://leetcode.com/problems/sort-colors/
/// Difficulty: Medium | Topic: Arrays, Two Pointers, Sorting
///
/// Problem:
///   Sort array of 0s, 1s, and 2s in-place without using sort library.
///   Dutch National Flag problem.
///
/// Time: O(n) | Space: O(1)
/// </summary>
public static class SortColors
{
    public static void SortColorsSolution(int[] nums)
    {
        int cursor = 0;
        int left = 0;
        int wight = nums.Length - 1;
        while (cursor <= wight)
        {
            if (nums[cursor] == 2)
            {
                nums[cursor] = nums[wight];
                nums[wight] = 2;
                wight--;
            }
            else if (nums[cursor] == 1)
            {
                cursor++;
            }
            else
            {
                nums[cursor] = nums[left];
                nums[left] = 0;
                cursor++;
                left++;
            }
        }
    }
}
