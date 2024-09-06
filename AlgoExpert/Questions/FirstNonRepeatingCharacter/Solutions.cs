namespace AlgoExpert.FirstNonRepeatingCharacter;

public class Solutions
{
    public static void Run()
    {
        var str = "abcdcaf";
        var result = FirstNonRepeatingCharacter(str);
        Console.WriteLine("Result: " + result);
    }

    public static int FirstNonRepeatingCharacter(string str)
    {
        // O(n) time | O(1) space where n is the length of the string
        var characterFrequencies = new Dictionary<char, int>();
        foreach (var character in str)
        {
            if (!characterFrequencies.ContainsKey(character))
            {
                characterFrequencies[character] = 0;
            }
            characterFrequencies[character]++;
        }
        for (var i = 0; i < str.Length; i++)
        {
            if (characterFrequencies[str[i]] == 1)
            {
                return i;
            }
        }
        return -1;
    }
}
