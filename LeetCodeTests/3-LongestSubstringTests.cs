using System.Globalization;
using LeetCode;

namespace LeetCodeTests;

public class LongestSubstringTests1
{
    private LeetCode_LongestSubstring leetCode_LongestSubstring;

    [SetUp]
    public void Setup()
    {
        leetCode_LongestSubstring = new();
    }

    [TestCase("abcabcbb", 3, "abc")]
    [TestCase("bbbbb", 1, "b")]
    [TestCase("pwwkew", 3, "wke")]
    [TestCase(" ", 1, " ")]
    [TestCase("abcde", 5, "abcde")]
    public void LengthOfLongestSubstring_WithValidInputString_ReturnExpectedLength(string inputString, int expectedSubstringLength, string expectedSubstring)
    {
        Assert.That(leetCode_LongestSubstring.LengthOfLongestSubstring(inputString), Is.EqualTo(expectedSubstringLength));
    }
}