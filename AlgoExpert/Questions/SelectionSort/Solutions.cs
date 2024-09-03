using System.Security.Cryptography.X509Certificates;

namespace AlgoExpert.SelectionSort;

public class Solutions
{
    public static void Run()
    {
        var array = new int[] { 8, 5, 2, 9, 5, 6, 3 };
        var result = SelectionSort(array);
        Console.WriteLine("Result: " + string.Join(",", result));
    }
    public static int[] SelectionSort(int[] array)
    {
        // O(n^2) time | O(1) space where n is the length of the array
        for (var i = 0; i < array.Length - 1; i++)
        {
            var smallestIndex = i;
            for (var j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[smallestIndex])
                {
                    smallestIndex = j;
                }
            }
            Swap(i, smallestIndex, array);
        }
        return array;
    }
    public static void Swap(int i, int j, int[] array)
    {
        var temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}
