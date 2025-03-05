using System.Diagnostics;

namespace LeetCode;

/// <summary>
/// https://leetcode.com/problems/find-all-duplicates-in-an-array/
/// </summary>
public static class FindDuplicate
{
    // O(n)
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
    //O(n^2)
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

    /// <summary>
    /// Формирование массива с уникальными значениями из входного массива
    /// </summary>
    //O(n^2)
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
                {
                    break;
                }
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

    /// <summary>
    /// Определить возростающая последовательность или нет
    /// </summary>
    //O(n)
    public static bool IsUpperArray(int[] nums)
    {
        int left = 0;
        int right = 0;

        while (right < nums.Length - 1)
        {
            right += 1;
            if (nums[left] > nums[right])
            {
                return false;
            }
            left += 1;
        }
        return true;
    }

}
