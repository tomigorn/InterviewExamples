using LeetCode;

namespace LeetCodeTests;

public class MedianOfTwoSortedArraysTests1
{
    private LeetCode_MedianOfTwoSortedArrays leetCode_MedianOfTwoSortedArrays;

    [SetUp]
    public void Setup()
    {
        leetCode_MedianOfTwoSortedArrays = new();
    }

    [TestCase(new[] {1,3},new[] {2},2.0)]
    [TestCase(new[] {1,2},new[] {3,4},2.5)]
    public void FindMedianSortedArrays_WithValidInputArrays_ReturnExpectedMedian(int[] nums1, int[] nums2, double expectedMedian)
    {
        Assert.That(leetCode_MedianOfTwoSortedArrays.FindMedianSortedArrays(nums1,nums2), Is.EqualTo(expectedMedian));
    }
}