using LeetCode;

namespace LeetCodeTests;

public class ZigzagConversionTests1
{
    private LeetCode_ZigzagConversion leetCode_ZigzagConversion;

    [SetUp]
    public void Setup()
    {
        leetCode_ZigzagConversion = new();
    }

    [TestCase("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
    [TestCase("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
    [TestCase("A", 1, "A")]
    public void GetZigzagConversion_WithValidInputStringAndValidLineNR_ReturnExpectedString(string inputString, int numberOfLines, string expectedOutputString)
    {
        Assert.That(leetCode_ZigzagConversion.Convert(inputString, numberOfLines), Is.EqualTo(expectedOutputString));
    }
}

/*

A   I   Q   Y
B  HJ  PR  XZ
C G K O S W
DF  LN  TV
E   M   U

A    K    U
B   JL   TV
C  I M  S W
D H  N R  X
EG   OQ   Y
F    P    Z


*/