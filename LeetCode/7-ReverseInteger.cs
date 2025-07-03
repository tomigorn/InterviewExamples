using System.ComponentModel;
using System.Numerics;
using System.Text;

namespace LeetCode;

/*
                                    8 = 3.25
1234567890123               => 26/(2*5-2) *(5-1) = 13
A 3 I 3 Q 3 Y  3 odd nr of lines (5) 1
B2 HJ2 PR2 XZ  2                     2
C1G1K1O1S1W    1                     3
DF2 LN2 TV     2                     4
E 3 M 3 U      3                     5

                                     10 = 2.6
12345678901    s.Length = 26 => 26/(2*6-2)*(6-1)= 11.2
A  4 K    U    4 even number of lines (6) 1
B 3 JL 3 TV    3                          2
C2 I1M2 S1W    2,1                        3
D1H2 N1R2 X    1,2                        4
EG   OQ   Y    3                          5
F    P    Z    4                          6
*/
public class LeetCode_ReverseInteger
{
    public int Reverse(int x)
    {
        string orig = x.ToString();
        StringBuilder reverse = new();
        for (int i = orig.Length - 1; i > 0; i--)
        {
            reverse.Append(orig[i]);
        }

        int result = 0;
        if (orig[0] != '-') {
            reverse.Append(orig[0]);
            int.TryParse(reverse.ToString(), out result);
        } else {
            int.TryParse(reverse.ToString(), out result);
            result *= -1;
        }
        return result;
    }
}