namespace AlgoExpert.KadanesAlgorithm;

public class Solutions
{
    public static void Run()
    {
        var array = new int[] { 3, 5, -9, 1, 3, -2, 3, 4, 7, 2, -9, 6, 3, 1, -5, 4 };
        var result = KadanesAlgorithm(array);
        Console.WriteLine("Result: " + result);
    }
    public static int KadanesAlgorithm(int[] array)
    {
        // O(n) time | O(1) space where n is the length of the array
        var maxEndingHere = array[0];
        var maxSoFar = array[0];
        for (var i = 1; i < array.Length; i++)
        {
            var num = array[i];
            maxEndingHere = Math.Max(num, maxEndingHere + num);
            maxSoFar = Math.Max(maxSoFar, maxEndingHere);
        }
        return maxSoFar;
    }
}
