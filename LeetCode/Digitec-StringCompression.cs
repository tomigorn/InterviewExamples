namespace LeetCode;

using System.Collections;
// Input: aaabbccccd

// Ouput: a3b2c4d1

// Case: 
// Input: aaabbccccdaa 
// Ouput: a3b2c4d1a2

using System.Text;

public class DigitecStringCompression
{
    public string CountCharOccurancesInOrderInString(string inputString)
    {
        List<Tuple<char, int>> resultList = new();
        Char oldChar = inputString[0];
        Char currentChar;
        int oldCharCount = 1;

        for (int i = 1; i < inputString.Length; i++)
        {
            currentChar = inputString[i];

            if (!currentChar.Equals(oldChar))
            {
                resultList.Add(new(oldChar, oldCharCount));
                oldCharCount = 1;
            }
            else
            {
                oldCharCount++;
            }
            oldChar = inputString[i];
        }
        resultList.Add(new(oldChar, oldCharCount));

        StringBuilder sb = new();
        foreach (var keyValuePair in resultList)
        {
            sb.Append(keyValuePair.Item1.ToString());
            sb.Append(keyValuePair.Item2.ToString());
        }
        return sb.ToString();
    }

    public string CountCharOccurancesInString(string inputString)
    {
        Dictionary<char, int> resultDict = new();
        for (int i = 0; i < inputString.Length; i++)
        {
            if (!resultDict.ContainsKey(inputString[i]))
            {
                resultDict.Add(inputString[i], 1);
            }
            else
            {
                resultDict[inputString[i]]++;
            }
        }

        StringBuilder sb = new();
        foreach (var keyValuePair in resultDict)
        {
            sb.Append(keyValuePair.Key.ToString());
            sb.Append(keyValuePair.Value.ToString());
        }
        return sb.ToString();
    }
}