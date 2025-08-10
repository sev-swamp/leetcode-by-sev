using System.Text;

namespace LeetCode;

public static class LargeNumber
{
    /// <summary>
    /// https://leetcode.com/problems/largest-number/
    /// </summary>
    public static string LargestNumberTask(int[] nums)
    {

        var numStrs = nums.Select(n => n.ToString()).ToArray();

        Array.Sort(numStrs, (x, y) => (y + x).CompareTo(x + y));

        if (numStrs[0] == "0") return "0";

        StringBuilder answer = new StringBuilder();
        foreach (var i in numStrs)
            answer.Append(i);
        return answer.ToString();
    }

    public static string LargestNumber2Task(int[] nums)
    {
        var result = new StringBuilder();
        var data = new List<string>[10];
        for (int i = 0; i < data.Length; i++)
            data[i] = new List<string>();

        for (int i = 0; i < nums.Length; i++)
        {
            var line = nums[i].ToString();
            var index = line[0] - '0';
            data[index].Add(line);
        }

        for (int i = 1; i <= data.Length; i++)
        {
            if (data[^i].Count == 0)
                continue;
            data[^i].Sort(CustomCompare);

            if (i == data.Length && result.Length == 0)
            {
                result.Append('0');
                break;
            }

            for (int j = 0; j < data[^i].Count; j++)
                result.Append(data[^i][j]);
        }
        return result.ToString();
    }

    private static int CustomCompare(string firstLine, string secondLine)
    {
        if (firstLine.Length == secondLine.Length)
        {
            string.Compare(secondLine, firstLine, StringComparison.Ordinal);
        }
        return string.Compare(secondLine + firstLine, firstLine + secondLine, StringComparison.Ordinal);
    }

}




// Input: nums = [10, 2]
// Output: "210"

// Input: nums = [3, 30, 34, 5, 9]
// Output: "9534330"
