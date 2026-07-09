namespace LeetCode;

/// <summary>
/// LeetCode #442 — Find All Duplicates in an Array
/// https://leetcode.com/problems/find-all-duplicates-in-an-array/
/// Difficulty: Medium | Topic: Arrays
///
/// Problem:
///   Given an array where 1 ≤ a[i] ≤ n, find all elements that appear twice.
///   Must run in O(n) time and use only O(1) extra space.
///
/// FindDuplicates — O(n) / O(1):
///   Use index negation as a visited marker. For each nums[i], negate the value
///   at index abs(nums[i])-1. If already negative — the element is a duplicate.
///
/// FindDuplicates2 — O(n²) / O(1):
///   Naive nested loop comparison.
///
/// RemoveDuplicates — O(n²): Build result array keeping only unique values.
///
/// IsUpperArray — O(n): Check if array is strictly non-decreasing.
/// </summary>
public static class FindDuplicate
{
    public static IList<int> FindDuplicates(int[] nums)
    {
        IList<int> list = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var n = Math.Abs(nums[i]) - 1;
            if (nums[n] < 0)
                list.Add(n + 1);
            nums[n] = -nums[n];
        }
        return list;
    }

    public static IList<int> FindDuplicates2(int[] nums)
    {
        IList<int> list = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] < 0) continue;
                if (nums[i] == nums[j])
                {
                    list.Add(nums[i]);
                    nums[j] = nums[j] * -1;
                }
            }
        }
        return list;
    }

    /// <summary>Build array with unique values from input array.</summary>
    public static int[] RemoveDuplicates(int[] nums)
    {
        int n = nums.Length;
        int[] result = new int[n];
        int count = 0;
        result[0] = nums[0];

        for (int i = 0; i < n; i++)
        {
            int j;
            for (j = 0; j < count; j++)
            {
                if (nums[i] == result[j])
                    break;
            }
            if (j == count)
            {
                result[count] = nums[i];
                count++;
            }
        }
        Array.Resize(ref result, count);
        return result;
    }

    /// <summary>Return true if array is non-decreasing.</summary>
    public static bool IsUpperArray(int[] nums)
    {
        int left = 0;
        int right = 0;

        while (right < nums.Length - 1)
        {
            right += 1;
            if (nums[left] > nums[right])
                return false;
            left += 1;
        }
        return true;
    }
}
