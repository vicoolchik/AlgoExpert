namespace AlgoExpert.InsertionSort;

public class Solutions
{
    public static void Run()
    {
        var array = new int[] { 8, 5, 2, 9, 5, 6, 3 };
        var result = InsertionSort(array);
        Console.WriteLine("Result: " + string.Join(",", result));
    }
    public static int[] InsertionSort(int[] array)
    {
        // O(n^2) time | O(1) space where n is the length of the array
        for (var i = 1; i < array.Length; i++)
        {
            var j = i;
            while (j > 0 && array[j] < array[j - 1])
            {
                Swap(j, j - 1, array);
                j--;
            }
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
