using System.Numerics;

namespace LeetCode;

public class LeetCode_PalindromeNumber
{
    public bool IsPalindromeWithString(int x)
    {
        string inputNumber = x.ToString();

        for (int i = 0, j = inputNumber.Length - 1; i <= j; i++, j--)
        {
            if (inputNumber[i] == inputNumber[j])
            {
                continue;
            }
            else
            {
                return false;
            }
        }
        return true;
    }

    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }

        int possibleReverse = 0;
        int origManipulated = x;

        while (origManipulated > 0)
        {
            possibleReverse = possibleReverse * 10 + origManipulated % 10;
            origManipulated = origManipulated / 10;
        }

        return possibleReverse == x;
    }
}