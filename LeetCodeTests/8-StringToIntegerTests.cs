using System.Numerics;
using LeetCode;

namespace LeetCodeTests;

public class StringToIntegerTests1
{
    private LeetCode_StringToInteger leetCode_StringToInteger;

    [SetUp]
    public void Setup()
    {
        leetCode_StringToInteger = new();
    }

    [TestCase("42", 42)]
    [TestCase(" -042" , -42)]
    [TestCase("1337c0d3" , 1337)]
    [TestCase("0-1" , 0)]
    [TestCase("words and 987" , 0)]
    [TestCase("-91283472332" , -2147483648)]
    public void GetReverseInt_WithValidInputInt_ReturnExpectedReverse(string s, int expectedInt)
    {
        Assert.That(leetCode_StringToInteger.MyAtoi(s), Is.EqualTo(expectedInt));
    }
}