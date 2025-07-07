using System.Numerics;

namespace LeetCode;

public class LeetCode_StringToInteger
{
    public int MyAtoi(string s)
    {
        int i = 0;
        bool positive = true;
        foreach (char c in s)
        {
            if (c == ' ')
            {
                i++;
                continue;
            }
            else
            {
                if (c == '-')
                {
                    positive = false;
                    i++;
                }
                else if (c == '+')
                {
                    positive = true;
                    i++;
                }
                break;
            }
        }
        string removedLeadingWhitespace = s.Substring(i);

        Dictionary<char, int> digits = new Dictionary<char, int>();
        digits.Add('0', 0);
        digits.Add('1', 1);
        digits.Add('2', 2);
        digits.Add('3', 3);
        digits.Add('4', 4);
        digits.Add('5', 5);
        digits.Add('6', 6);
        digits.Add('7', 7);
        digits.Add('8', 8);
        digits.Add('9', 9);

        BigInteger result = 0;
        foreach (char c in removedLeadingWhitespace)
        {
            if (digits.ContainsKey(c))
            {
                result = result * 10 + digits[c];
            }
            else
            {
                break;
            }
        }

        int intResult;
        try
        {
            intResult = positive ? (int) result : (int) result * -1;
        }
        catch
        {
            if (positive)
            {
                intResult = int.MaxValue;
            }
            else
            {
                intResult = int.MinValue;
            }
        }

        
        return intResult;
    }
}