using System.Numerics;
using LeetCode;

namespace LeetCodeTests;

public class ReverseIntegerTests1
{
    private LeetCode_ReverseInteger leetCode_ReverseInteger;

    [SetUp]
    public void Setup()
    {
        leetCode_ReverseInteger = new();
    }

    [TestCase(123, 321)]
    [TestCase(-123, -321)]
    [TestCase(120, 21)]
    [TestCase(1534236469, 0)]
    public void GetReverseInt_WithValidInputInt_ReturnExpectedReverse(int orig, int expectedReverse)
    {
        Assert.That(leetCode_ReverseInteger.Reverse(orig), Is.EqualTo(expectedReverse));
    }
}