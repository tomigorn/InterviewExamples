using System.Numerics;
using LeetCode;

namespace LeetCodeTests;

public class PalindromeNumberTests1
{
    private LeetCode_PalindromeNumber leetCode_PalindromeNumber;

    [SetUp]
    public void Setup()
    {
        leetCode_PalindromeNumber = new();
    }

    [TestCase(121, true)]
    [TestCase(-121, false)]
    [TestCase(10, false)]
    public void GetReverseInt_WithValidInputInt_ReturnExpectedReverse(int i, bool expectedBool)
    {
        Assert.That(leetCode_PalindromeNumber.IsPalindrome(i), Is.EqualTo(expectedBool));
    }
}