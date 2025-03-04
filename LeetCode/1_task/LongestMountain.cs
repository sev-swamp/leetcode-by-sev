namespace LeetCode;

/// <summary>
/// https://leetcode.com/problems/longest-mountain-in-array/description/
/// </summary>
public static class LongestMountain
{
    //O{n} - 
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
                //if (index == 0) up += 1;
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