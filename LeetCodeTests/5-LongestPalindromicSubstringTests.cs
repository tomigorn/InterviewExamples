using LeetCode;

namespace LeetCodeTests;

public class LongestPalindromicSubstringTests1
{
    private LeetCode_LongestPalindromicSubstring leetCode_LongestPalindromicSubstring;

    [SetUp]
    public void Setup()
    {
        leetCode_LongestPalindromicSubstring = new();
    }

    [TestCase("babad", "bab")]
    [TestCase("cbbd", "bb")]
    [TestCase("ccc", "ccc")]
    public void FindLongestPalindromicSubstring_WithValidInputString_ReturnExpectedPalindrome(string inputString, string LongestPalindromicSubstring)
    {
        Assert.That(leetCode_LongestPalindromicSubstring.LongestPalindrome(inputString), Is.EqualTo(LongestPalindromicSubstring));
    }
}