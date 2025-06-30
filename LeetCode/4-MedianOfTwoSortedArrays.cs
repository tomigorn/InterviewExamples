public class LeetCode_MedianOfTwoSortedArrays
{
    public double FindMedianSortedArraysBigOMPlusN(int[] nums1, int[] nums2) {
        List<int> mergedList = new();

        int left = 0, right = 0;
        while (left < nums1.Length || right < nums2.Length )
        {
            if (left < nums1.Length && (right >= nums2.Length || nums1[left] < nums2[right]))
            {
                mergedList.Add(nums1[left]);
                left++;
            }
            else
            {
                mergedList.Add(nums2[right]);
                right++;
            }
        }

        double median;
        var mergedArray = mergedList.ToArray();
        double mergedArrayLength = mergedArray.Length;
        if (mergedArrayLength % 2 == 1)
        {
            median = mergedArray[(int)Math.Ceiling((mergedArrayLength+1) / 2)-1];
        }
        else
        {
            median = mergedArray[(int)Math.Ceiling((mergedArrayLength+1) / 2) - 1];
            median += mergedArray[(int)Math.Floor((mergedArrayLength+1) / 2) - 1];
            median /= 2.0;
        }



        return median;
    }

    public double FindMeanSortedArrays(int[] nums1, int[] nums2)
    {
        double count = 0;
        double sum = 0;
        foreach (int i in nums1)
        {
            count++;
            sum += i;
        }
        foreach (int j in nums2)
        {
            count++;
            sum += j;
        }
        return sum / count;
    }
}
