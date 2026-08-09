namespace LeetCode;

/// <summary>
/// LeetCode #986 — Interval List Intersections
/// https://leetcode.com/problems/interval-list-intersections/
/// Difficulty: Medium | Topic: Arrays, Two Pointers
///
/// Problem:
///   Given two lists of closed intervals (each sorted and disjoint),
///   return their intersection.
///
/// Time: O(m + n) | Space: O(m + n)
/// </summary>
public static class IntervalListIntersections
{
    public static int[][] IntervalIntersection(int[][] firstList, int[][] secondList)
    {
        int i = 0;
        int j = 0;
        var newarray = new List<int[]>();
        while (i < firstList.Length && j < secondList.Length)
        {
            int start = Math.Max(firstList[i][0], secondList[j][0]);
            int end = Math.Min(firstList[i][1], secondList[j][1]);

            if (start <= end)
            {
                newarray.Add([start, end]);
            }

            if (firstList[i][1] < secondList[j][1])
                i++;
            else
                j++;
        }
        return newarray.ToArray();
    }
}
