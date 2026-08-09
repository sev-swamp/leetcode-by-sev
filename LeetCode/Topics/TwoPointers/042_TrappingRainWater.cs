namespace LeetCode;

/// <summary>
/// LeetCode #42 — Trapping Rain Water
/// https://leetcode.com/problems/trapping-rain-water/
/// Difficulty: Hard | Topic: Arrays, Two Pointers, Stack
///
/// Problem:
///   Given an elevation map, compute how much water it can trap after raining.
///
/// Time: O(n) | Space: O(1)
/// </summary>
public static class TrappingRainWater
{
    public static int Trap2(int[] height)
    {
        int cursor_left = 0;
        int cursor_right = height.Length - 1;

        int max_left = height[cursor_left];
        int max_right = height[cursor_right];

        int result = 0;
        while (cursor_left < cursor_right)
        {
            if (max_left < max_right)
            {
                cursor_left++;
                max_left = Math.Max(height[cursor_left], max_left);
                result += max_left - height[cursor_left];
            }
            else
            {
                cursor_right--;
                max_right = Math.Max(height[cursor_right], max_right);
                result += max_right - height[cursor_right];
            }
        }
        return result;
    }
    //  поиск максимальной горы с разных сторон и поиск разницы внутри горы
    public static int Trap(int[] height)
    {
        int result = 0;
        int[] leftArray = new int[height.Length];
        int[] rightArray = new int[height.Length];

        int temp = 0;

        for (var i = 0; i <= height.Length - 1; i++)
        {
            temp = Math.Max(height[i], temp);
            leftArray[i] = temp;
        }
        temp = 0;
        for (var i = height.Length - 1; i >= 0; i--)
        {
            temp = Math.Max(height[i], temp);
            rightArray[i] = temp;
        }

        for (var i = 0; i < height.Length - 1; i++)
        {
            temp = Math.Min(leftArray[i], rightArray[i]);
            result += temp - height[i];
        }

        return result;
    }
}
