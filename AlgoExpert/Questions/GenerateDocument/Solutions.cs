namespace AlgoExpert.GenerateDocument;

public class Solutions
{
    public static void Run()
    {
        var characters = "Bste!hetsi ogEAxpelrt x ";
        var document = "AlgoExpert is the Best!";
        var result = GenerateDocument(characters, document);
        Console.WriteLine("Result: " + result);
    }
    public static bool GenerateDocument(string characters, string document)
    {
        // O(c + d) time | O(u) space where c is the number of characters, d is the number of documents, and u is the number of unique characters in the characters string
        var characterCounts = new Dictionary<char, int>();
        foreach (var character in characters)
        {
            if (!characterCounts.ContainsKey(character))
            {
                characterCounts[character] = 0;
            }
            characterCounts[character]++;
        }
        foreach (var character in document)
        {
            if (!characterCounts.ContainsKey(character) || characterCounts[character] == 0)
            {
                return false;
            }
            characterCounts[character]--;
        }
        return true;
    }
}
