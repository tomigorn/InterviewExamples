// Input: aaabbccccd

// Ouput: a3b2c4d1

// Case: 
// Input: aaabbccccdaa 
// Ouput: a3b2c4d1a2

using System.Text;

static class CountOccurances
{
    public static string CountCharOccurancesInString(string inputString)
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