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
}
