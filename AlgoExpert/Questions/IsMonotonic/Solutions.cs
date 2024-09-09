namespace AlgoExpert.IsMonotonic;

public class Solutions
{
    public static void Run()
    {
        var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var result = IsMonotonic(array);
        Console.WriteLine("Result: " + result);
    }
    public static bool IsMonotonic(int[] array)
    {
        // O(n) time | O(1) space where n is the length of the array
        if (array.Length <= 2)
        {
            return true;
        }
        var direction = array[1] - array[0];
        for (var i = 2; i < array.Length; i++)
        {
            if (direction == 0)
            {
                direction = array[i] - array[i - 1];
                continue;
            }
            if (breaksDirection(direction, array[i - 1], array[i]))
            {
                return false;
            }
        }
        return true;
    }
    public static bool breaksDirection(int direction, int previousInt, int currentInt)
    {
        var difference = currentInt - previousInt;
        if (direction > 0)
        {
            return difference < 0;
        }
        return difference > 0;
    }
}
