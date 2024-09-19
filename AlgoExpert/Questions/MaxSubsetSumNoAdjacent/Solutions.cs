namespace AlgoExpert.MaxSubsetSumNoAdjacent;

public class Solutions
{
    public static void Run()
    {
        var array = new int[] { 75, 105, 120, 75, 90, 135 };
        var result = MaxSubsetSumNoAdjacent(array);
        Console.WriteLine("Result: " + result);
    }
    public static int MaxSubsetSumNoAdjacent(int[] array)
    {
        // O(n) time | O(1) space where n is the length of the array
        if (array.Length == 0)
        {
            return 0;
        }
        if (array.Length == 1)
        {
            return array[0];
        }
        var second = array[0];
        var first = Math.Max(array[0], array[1]);
        for (var i = 2; i < array.Length; i++)
        {
            var current = Math.Max(first, second + array[i]);
            second = first;
            first = current;
        }
        return first;
    }
}
