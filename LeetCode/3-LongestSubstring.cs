using System.Linq;

public class LeetCode_LongestSubstring
{

    /// <summary>
    /// Solution with Time Complexity of O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> set = new();
        int left = 0;
        int right = 0;
        int maxLength = 0;

        while (right < s.Length)
        {
            if (!set.Contains(s[right]))
            {
                set.Add(s[right]);
                maxLength = Math.Max(maxLength, right - left + 1);
                right++;
            }
            else
            {
                set.Remove(s[left]);
                left++;
            }
        }
        return maxLength;
    }

    /// <summary>
    /// Suboptimal Solution with complexity of O(n^2)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int LengthOfLongestSubstringBadSolution(string s)
    {
        int longestSubstringLength = 0;
        string longestSubstring = "";
        int currentSubstringLength = 0;

        Dictionary<char, int> dict = [];

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = i; j < s.Length; j++)
            {
                if (dict.ContainsKey(s[j]))
                {
                    if (longestSubstringLength <= currentSubstringLength)
                    {
                        longestSubstringLength = currentSubstringLength;
                        longestSubstring = s.Substring(i, currentSubstringLength);
                    }
                    break;
                }
                else
                {
                    dict.Add(s[j], 1);
                }
                currentSubstringLength = j - i + 1;
            }

            if (currentSubstringLength >= longestSubstringLength)
            {
                longestSubstringLength = currentSubstringLength;
                longestSubstring = s.Substring(s.Length - currentSubstringLength);
            }

            dict.Clear();
        }


        Console.WriteLine("Longest Substring: " + longestSubstring);
        return longestSubstringLength;
    }
}