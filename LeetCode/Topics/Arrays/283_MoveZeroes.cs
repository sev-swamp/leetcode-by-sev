namespace LeetCode;

/// <summary>
/// LeetCode #283 — Move Zeroes
/// https://leetcode.com/problems/move-zeroes/
/// Difficulty: Easy | Topic: Arrays, Two Pointers
///
/// Problem:
///   Move all 0s to the end while maintaining the relative order of non-zero elements.
///   Modify in place, no return value.
///
/// MoveZeroes — O(n): Two-pointer swap, preserves relative order.
/// MoveZeroe1 — O(n): Reverse scan variant, does NOT preserve order.
/// MoveZeroes2 — O(n): Forward scan variant, does NOT preserve order.
/// </summary>
public static class MoveZeroes
{
    public static void MoveZeroes1(int[] nums)
    {
        int left = 0;
        int right = 0;

        while (right < nums.Length - 1)
        {
            right += 1;
            if (nums[left] == 0 && nums[right] == 0)
                continue;
            if (nums[left] == 0)
            {
                nums[left] = nums[right];
                nums[right] = 0;
            }
            left += 1;
        }
    }

    // does NOT preserve order
    public static void MoveZeroes2(int[] nums)
    {
        int left = nums.Length - 1;
        int right = nums.Length - 1;

        while (left != 0)
        {
            left -= 1;
            if (nums[left] == 0)
            {
                nums[left] = nums[right];
                nums[right] = 0;
                right -= 1;
            }
        }
    }

    // does NOT preserve order
    public static void MoveZeroes3(int[] nums)
    {
        int index = nums.Length - 1;
        for (int i = index; i >= 0; i--)
        {
            if (i == index && nums[i] == 0)
            {
                index -= 1;
                continue;
            }

            if (nums[i] == 0)
            {
                nums[i] = nums[index];
                nums[index] = 0;
                index -= 1;
            }
        }
    }
}
