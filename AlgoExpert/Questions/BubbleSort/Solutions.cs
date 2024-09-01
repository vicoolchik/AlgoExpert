namespace AlgoExpert.BubbleSort;

public class Solutions
{
    public static void Run()
    {
        var array = new int[] { 8, 5, 2, 9, 5, 6, 3 };
        var result = BubbleSort(array);
        foreach (var item in result)
        {
            Console.WriteLine("Result: " + item);
        }
    }

    public static int[] BubbleSort(int[] array)
    {
        // O(n^2) time | O(1) space where n is the length of the array
        var isSorted = false;
        var counter = 0;
        while (!isSorted)
        {
            isSorted = true;
            for (var i = 0; i < array.Length - 1 - counter; i++)
            {
                if (array[i] > array[i + 1])
                {
                    Swap(i, i + 1, array);
                    isSorted = false;
                }
            }
            counter++;
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
