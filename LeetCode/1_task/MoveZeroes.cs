namespace LeetCode;
//https://leetcode.com/problems/move-zeroes/
public static class MoveZeroe
{
    //O{n} - 
    public static void MoveZeroes(int[] nums)
    {
        int left = 0;
        int right = 0;

        int compareValue = 0;
        while (right < nums.Length - 1)
        {
            right += 1;
            if (nums[left] == compareValue && nums[right] == compareValue)
            {
                continue;
            }
            if (nums[left] == compareValue)
            {
                nums[left] = nums[right];
                nums[right] = compareValue;
            }
            left += 1;
        }
    }

    //O{n} - ответ не сохраняет порядок
    public static void MoveZeroe1(int[] nums)
    {
        int left = nums.Length - 1;
        int right = nums.Length - 1;

        int compareValue = 0;
        while (left != 0)
        {
            left -= 1;
            if (nums[left] == compareValue)
            {
                nums[left] = nums[right];
                nums[right] = compareValue;
                right -= 1;
            }
        }
    }

    //O(n) -> ответ не сохраняет порядок
    public static void MoveZeroes2(int[] nums)
    {
        int compareValue = 0;
        int index = nums.Length - 1;
        for (int i = index; i >= 0; i--)
        {
            if (i == index && nums[i] == compareValue)
            {
                index -= 1;
                continue;
            }

            if (nums[i] == compareValue)
            {
                nums[i] = nums[index];
                nums[index] = compareValue;
                index -= 1;
            }
        }
    }
}
