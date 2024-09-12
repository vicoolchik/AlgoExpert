namespace AlgoExpert.FirstDuplicateValue;

public class Solutions
{
    public static void Run()
    {
        var array = new int[] { 2, 1, 5, 2, 3, 3, 4 };
        var result = FirstDuplicateValue(array);
        Console.WriteLine("Result: " + result);
    }
    public static int FirstDuplicateValue(int[] array)
    {
        // O(n) time | O(1) space where n is the length of the array
        for (var i = 0; i < array.Length; i++)
        {
            var absValue = Math.Abs(array[i]);
            if (array[absValue - 1] < 0)
            {
                return absValue;
            }
            array[absValue - 1] *= -1;
        }
        return -1;
    }
    public static int FirstDuplicateValueBruteForce(int[] array)
    {
        // O(n^2) time | O(1) space where n is the length of the array
        var minimumSecondIndex = array.Length;
        for (var i = 0; i < array.Length; i++)
        {
            for (var j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    minimumSecondIndex = Math.Min(minimumSecondIndex, j);
                }
            }
        }
        return minimumSecondIndex == array.Length ? -1 : array[minimumSecondIndex];
    }
    public static int FirstDuplicateValueOptimized(int[] array)
    {
        // O(n) time | O(n) space where n is the length of the array
        var seen = new HashSet<int>();
        foreach (var value in array)
        {
            if (seen.Contains(value))
            {
                return value;
            }
            seen.Add(value);
        }
        return -1;
    }
}
