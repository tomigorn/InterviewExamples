using LeetCode;

namespace LeetCodeTests;

public class DigitecStringCompressionTests1
{
    private DigitecStringCompression digitecStringCompression;

    [SetUp]
    public void Setup()
    {
        digitecStringCompression = new();
    }

    [TestCase("aaabbccccd", "a3b2c4d1")]
    public void CountCharOccurancesInString_WithValidInputStrings_ReturnExpectedOutputString(string input, string output)
    {
        Assert.That(digitecStringCompression.CountCharOccurancesInString(input), Is.EqualTo(output));

    }


    [TestCase("aaabbccccdaa", "a3b2c4d1a2")]
    public void CountCharOccurancesInOrderInString_WithValidInputStrings_ReturnExpectedOutputString(string input, string output)
    {
        Assert.That(digitecStringCompression.CountCharOccurancesInOrderInString(input), Is.EqualTo(output));

    }
}