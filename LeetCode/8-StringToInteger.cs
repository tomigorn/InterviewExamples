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

        long result = 0;
        foreach (char c in removedLeadingWhitespace)
        {
            if (c >= '0' && c <= '9' && result < int.MaxValue)
            {
                int digit = c - '0';
                result = result * 10 + digit;
            }
            else
            {
                break;
            }
        }

        int intResult;
        if (positive && result > int.MaxValue) {
            intResult = int.MaxValue;
        } else if (!positive && result > int.MaxValue) {
            intResult = int.MinValue;
        } else {
            intResult = positive ? (int) result : (int) result * -1;
        }
        
        return intResult;
    }
}