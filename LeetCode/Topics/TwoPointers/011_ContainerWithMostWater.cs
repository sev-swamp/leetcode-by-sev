namespace LeetCode;

/// <summary>
/// LeetCode #11 — Container With Most Water
/// https://leetcode.com/problems/container-with-most-water/
/// Difficulty: Medium | Topic: Arrays, Two Pointers, Greedy
///
/// Problem:
///   Given n vertical lines at positions 0..n-1 with heights height[i],
///   find two lines that form a container holding the most water.
///
/// Time: O(n) | Space: O(1)
/// </summary>
public static class ContainerWithMostWater
{
    public static int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int result = 0;
        if (height.Length == 0)
            return 0;

        while (left < right)
        {
            var h = Math.Min(height[left], height[right]);
            var w = right - left;
            var s = w * h;
            if (s > result)
                result = s;

            if (height[right] > height[left])
                left++;
            else
                right--;

        }
        return result;
    }
}
