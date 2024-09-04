namespace AlgoExpert.CaesarCypherEncryptor;

public class Solutions
{
    public static void Run()
    {
        var result = CaesarCypherEncryptor("xyz", 2);
        Console.WriteLine("Result: " + result);
    }
    public static string CaesarCypherEncryptor(string str, int key)
    {
        // O(n) time | O(n) space
        var newLetters = new List<char>();
        var newKey = key % 26;
        foreach (var letter in str)
        {
            newLetters.Add(GetNewLetter(letter, newKey));
        }
        return new string(newLetters.ToArray());
    }
    public static char GetNewLetter(char letter, int key)
    {
        var newLetterCode = letter + key;
        return newLetterCode <= 122 ? (char)newLetterCode : (char)(96 + newLetterCode % 122);
    }
}
