namespace AlgoExpert.Semordnilap;

public class Solutions
{
    public static void Run(){
        string[] words = new string[] { "dog", "god", "cat", "tac" };
        var result = Semordnilap(words);
        Console.WriteLine("Result: " + result);
    }
    public static List<List<string>> Semordnilap(string[] words)
    {
        // O(w * n) time | O(w) space where w is the number of words and n is the length of the longest word
        var wordSet = new HashSet<string>(words);

        var semordnilaps = new List<List<string>>();
        foreach (var word in words)
        {
            var reversedWord = new string(word.Reverse().ToArray());
            if (word != reversedWord && wordSet.Contains(reversedWord))
            {
                semordnilaps.Add(new List<string> { word, reversedWord });
                wordSet.Remove(word);
                wordSet.Remove(reversedWord);
            }
        }
        return semordnilaps;
    }
}
