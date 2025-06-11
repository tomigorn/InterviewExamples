using System.Globalization;
using LeetCode;

namespace LeetCodeTests;

public class AddTwoNumbersTests1
{
    private LeetCode_AddTwoNumbers leetCode_AddTwoNumbers;
    [SetUp]
    public void Setup()
    {
        leetCode_AddTwoNumbers = new();
    }

    [TestCase(342, 465, 807)]
    [TestCase(0, 0, 0)]
    [TestCase(9999999, 9999, 10009998)]
    public void AddTwoNumbers_WithValidIntegers_ReturnsExpectedSumListNode(int intInput1, int intInput2, int intExpectedOutput)
    {
        ListNode input1 = ListNode.createNodeFromInt(intInput1);
        ListNode input2 = ListNode.createNodeFromInt(intInput2);
        ListNode expectedOutput = ListNode.createNodeFromInt(intExpectedOutput);

        var result = leetCode_AddTwoNumbers.AddTwoNumbers(input1, input2);

        CollectionAssert.AreEqual(ListNode.ToArray(expectedOutput), ListNode.ToArray(result));
    }
}