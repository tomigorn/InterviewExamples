namespace LeetCode;

public class LeetCode_LongestPalindromicSubstring
{
    public string LongestPalindrome(string s)
    {
        string currentlyLongestPalindrome = String.Empty;
        for (int currentPalindromeMiddlePosition = 0; currentPalindromeMiddlePosition < s.Length; currentPalindromeMiddlePosition++)
        {
            ExpandAroundCenter(s, currentPalindromeMiddlePosition, currentPalindromeMiddlePosition, ref currentlyLongestPalindrome); // for odd palindrome length

            ExpandAroundCenter(s, currentPalindromeMiddlePosition, currentPalindromeMiddlePosition + 1, ref currentlyLongestPalindrome); // for even palindrome length
        }
        return currentlyLongestPalindrome;
    }

    private void ExpandAroundCenter(string s, int left, int right, ref string currentlyLongestPalindrome)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            left++;
            right--;

            var currentSubstring = s.Substring(left, right - left + 1);
            if (currentSubstring.Length > currentlyLongestPalindrome.Length)
            {
                currentlyLongestPalindrome = currentSubstring;
            }
    }
}