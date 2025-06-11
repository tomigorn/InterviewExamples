using System.Linq;

public class LeetCode_LongestSubstring
{
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