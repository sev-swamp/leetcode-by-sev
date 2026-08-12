namespace LeetCode;

/// <summary>
/// LeetCode #56 — Merge Intervals
/// https://leetcode.com/problems/merge-intervals/
/// Difficulty: Medium | Topic: Arrays, Sorting
///
/// Problem:
///   Given an array of intervals where intervals[i] = [start_i, end_i],
///   merge all overlapping intervals and return an array of the non-overlapping
///   intervals that cover all the intervals in the input.
///
/// Time: O(n log n) | Space: O(n)
/// </summary>
public static class MergeIntervals
{
    public static int[][] Merge(int[][] intervals)
    {
        Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));
        List<int[]> newinterval = new List<int[]>();

        var start = intervals[0];

        for (int i = 0; i <= intervals.Length - 1; i++)
        {
            var next = intervals[i];
            if (start[1] >= next[0])
                start[1] = Math.Max(start[1], next[1]);
            else
            {
                newinterval.Add(start);
                start = next;
            }
        }

        newinterval.Add(start);
        return newinterval.ToArray();
    }
}
