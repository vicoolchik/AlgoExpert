namespace AlgoExpert.MissingNumbers;

public class Solutions
{
    public static void Run()
    {
        var result = MissingNumbers(new int[] { 1, 2, 3, 4, 6, 7, 8 });
        Console.WriteLine("Result: " + result);
    }
    public static int[] MissingNumbers(int[] array)
    {
        // O(n) time | O(n) space where n is the length of the array
        var missingNumbers = new List<int>();
        var hashSet = new HashSet<int>();
        foreach (var num in array)
        {
            hashSet.Add(num);
        }
        for (int i = 1; i <= array.Length + 2; i++)
        {
            if (!hashSet.Contains(i))
            {
                missingNumbers.Add(i);
            }
        }
        return missingNumbers.ToArray();
    }
}
