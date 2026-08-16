using Microsoft.VisualBasic;

namespace LeetCode;

/// <summary>
/// LeetCode #438 — Find All Anagrams in a String
/// https://leetcode.com/problems/find-all-anagrams-in-a-string/
/// Difficulty: Medium | Topic: Strings, Sliding Window, Hash Map
///
/// Problem:
///   Find all start indices of anagrams of p in s.
///
/// Time: O(n) | Space: O(1)
/// </summary>
public static class FindAllAnagrams
{
    public static IList<int> FindAnagrams(string s, string p)
    {
        List<int> anagrams = new List<int>();

        if (s.Length < p.Length)
            return anagrams;

        int left = 0;
        int right = p.Length - 1;
        int[] need = new int[26];
        int[] window = new int[26];
        for (int i = 0; i <= right; i++)
        {
            need[p[i] - 'a']++;
            window[s[i] - 'a']++;
        }
        if (IsCompareArray(need, window))
            anagrams.Add(left);

        right++;
        while (right < s.Length)
        {
            var rightitem = s[right] - 'a';
            var leftitem = s[left] - 'a';

            window[rightitem]++;
            window[leftitem]--;

            if (IsCompareArray(need, window))
                anagrams.Add(left + 1);
            right++;
            left++;
        }

        return anagrams;
    }

    private static bool IsCompareArray(int[] need, int[] window)
    {
        return need.SequenceEqual(window);
    }
    // "cbaebabacd", "abc" 
    //[1, 1, 1, 0 ,0 ...]
    //[1, 1, 1, 0 ,0 ...]
    //[0, 1, 1, 0 ,1 ...]
    //[0, 1, 1, 0 ,1 ...]
}
