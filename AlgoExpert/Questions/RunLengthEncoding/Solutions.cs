namespace AlgoExpert.RunLengthEncoding;

public class Solutions
{
    public static void Run()
    {
        var str = "AAAAAAAAAAAAABBCCCCDD";
        var result = RunLengthEncoding(str);
        Console.WriteLine("Result: " + result);
    }
    public static string RunLengthEncoding(string str)
    {
        // O(n) time | O(n) space where n is the length of the string
        var encodedChars = new List<char>();
        var currentRunLength = 1;
        for (var i = 1; i < str.Length; i++)
        {
            var currentChar = str[i];
            var previousChar = str[i - 1];
            if (currentChar != previousChar || currentRunLength == 9)
            {
                encodedChars.Add(currentRunLength.ToString()[0]);
                encodedChars.Add(previousChar);
                currentRunLength = 0;
            }
            currentRunLength++;
        }
        encodedChars.Add(currentRunLength.ToString()[0]);
        encodedChars.Add(str[str.Length - 1]);
        return new string(encodedChars.ToArray());
    }
}
