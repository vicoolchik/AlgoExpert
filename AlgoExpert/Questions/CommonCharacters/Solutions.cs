namespace AlgoExpert.CommonCharacters;

public class Solutions
{
    public static void Run()
    {
        var strings = new string[] { "bella", "label", "roller" };
        var result = CommonCharacters(strings);
        Console.WriteLine("Result: " + string.Join(",", result));
    }
    public static string[] CommonCharacters(string[] strings)
    {
        // O(n * m) time | O(c) space - where n is the number of strings, m is the
        // length of the longest string, and c is the number of unique characters
        // across all strings
        Dictionary<char, int> characterCounts = new Dictionary<char, int>();

        foreach (var str in strings)
        {
            HashSet<char> uniqueStringChars = new HashSet<char>();
            for (int i = 0; i < str.Length; i++)
            {
                uniqueStringChars.Add(str[i]);
            }

            foreach (var character in uniqueStringChars)
            {
                if (!characterCounts.ContainsKey(character))
                {
                    characterCounts[character] = 0;
                }
                characterCounts[character] = characterCounts[character] + 1;
            }
        }

        List<char> finalChars = new List<char>();
        foreach (var characterCount in characterCounts)
        {
            char character = characterCount.Key;
            int count = characterCount.Value;
            if (count == strings.Length)
            {
                finalChars.Add(character);
            }
        }

        string[] finalCharsArr = new string[finalChars.Count];
        for (int i = 0; i < finalCharsArr.Length; i++)
        {
            finalCharsArr[i] = finalChars[i].ToString();
        }

        return finalCharsArr;
    }
}
