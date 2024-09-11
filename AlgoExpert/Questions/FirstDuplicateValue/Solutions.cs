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
}
