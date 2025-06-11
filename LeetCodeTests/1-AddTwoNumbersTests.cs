using System.Globalization;
using LeetCode;

namespace LeetCodeTests;

public class AddTwoNumbersTests1
{
    private Solution solution;
    [SetUp]
    public void Setup()
    {
        solution = new Solution();
    }

    [TestCase(342, 465, 807)]
    [TestCase(0, 0, 0)]
    [TestCase(9999999, 9999, 10009998)]
    public void Test1(int intInput1, int intInput2, int intExpectedOutput)
    {
        ListNode input1 = ListNode.createNodeFromInt(intInput1);
        ListNode input2 = ListNode.createNodeFromInt(intInput2);
        ListNode expectedOutput = ListNode.createNodeFromInt(intExpectedOutput);

        var result = solution.AddTwoNumbers(input1, input2);

        CollectionAssert.AreEqual(ListNode.ToArray(expectedOutput), ListNode.ToArray(result));
    }
}