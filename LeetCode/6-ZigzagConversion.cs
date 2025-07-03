using System.ComponentModel;
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
public class LeetCode_ZigzagConversion
{
    public string Convert(string s, int numRows)
    {
        if (s.Length < numRows || numRows == 1) {
            return s;
        }

        StringBuilder[] rows = new StringBuilder[numRows];
        for (int i = 0; i < numRows; i++)
        {
            rows[i] = new();
        }

        int currentRow = 0;
        bool diagonal = false;

        foreach (char c in s)
        {
            rows[currentRow].Append(c);

            if (currentRow == 0 || currentRow == numRows - 1)
            {
                diagonal = !diagonal;
            }

            if (!diagonal)
            {
                currentRow--;
            }
            else
            {
                currentRow++;
            }
        }

        StringBuilder result = new();
        foreach (var row in rows)
        {
            result.Append(row);
        }
        return result.ToString();
    }
    



    public string ConvertSuboptimalSolutionWithArray(string s, int numRows)
    {
        int numColumns = s.Length;
        char[,] output = new char[numRows, numColumns];

        int currentRow, currentColumn;
        currentRow = currentColumn = 0;
        bool diagonal = false;
        for (int i = 0; i < s.Length && numRows != 1; i++)
        {
            output[currentRow, currentColumn] = s[i];
            if (!diagonal && currentRow < numRows - 1)
            {
                currentRow++;
            }
            else if (!diagonal)
            {
                diagonal = true;
            }

            if (diagonal && currentRow > 0)
            {
                currentRow--;
                currentColumn++;
            }
            else if (diagonal)
            {
                diagonal = false;

                currentRow++;
            }
        }

        StringBuilder sb = new();
        for (int row = 0; row < numRows; row++)
        {
            for (int column = 0; column < numColumns; column++)
            {
                if (output[row, column] != '\0')
                {
                    sb.Append(output[row, column]);

                }
            }
        }

        if (numRows == 1)
        {
            sb.Clear();
            sb.Append(s);
        }

        return sb.ToString();





        // for (int currentRow = 1; currentRow <= numRows; currentRow++)
        // {
        //     if (currentRow == 2 || currentRow == numRows - 1)
        //     {

        //     }
        //     else if (numRows % 2 == 0 && (currentRow == numRows / 2 || currentRow == numRows / 2 + 1))
        //     {

        //     }
        //     else
        //     {

        //     }

        //     if (currentRow < numRows / 2.0)
        //     {
        //         currentSpaceBetweenChars--;
        //     }
        //     else
        //     {
        //         currentSpaceBetweenChars++;
        //     }


        //     // else if (numRows % 2 == 0 && (currentRow == numRows / 2 || currentRow == numRows / 2 + 1))
        //     // {

        //     // }
        //     // else
        //     // {

        //     // }
        // }
        // return "";
    }
}