namespace LeetCode;

/// <summary>
/// LeetCode #125 — Valid Palindrome
/// https://leetcode.com/problems/valid-palindrome/
/// Difficulty: Easy | Topic: Strings, Two Pointers
///
/// Problem:
///   A phrase is a palindrome if, after converting to lowercase and removing
///   non-alphanumeric characters, it reads the same forward and backward.
///
/// Time: O(n) | Space: O(1)
/// </summary>
public static class ValidPalindrome
{
    public static bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;
        while (left < right)
        {
            char leftChar = char.ToLowerInvariant(s[left]);
            char rightChar = char.ToLowerInvariant(s[right]);
            if (!char.IsLetterOrDigit(leftChar))
            {
                left++;
                continue;
            }
            if (!char.IsLetterOrDigit(rightChar))
            {
                right--;
                continue;
            }

            if (leftChar != rightChar)
                return false;

            left++;
            right--;
        }
        return true;
    }
}
