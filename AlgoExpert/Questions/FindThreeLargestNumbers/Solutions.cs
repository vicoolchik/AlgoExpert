namespace AlgoExpert.FindThreeLargestNumbers;

public class Solutions
{
    public static void Run()
    {
        var array = new int[] { 141, 1, 17, -7, -17, -27, 18, 541, 8, 7, 7 };
        var result = FindThreeLargestNumbers(array);
        Console.WriteLine("Result: " + string.Join(", ", result));
    }

    public static int[] FindThreeLargestNumbers(int[] array)
    {
        // O(n) time | O(1) space where n is the length of the array
        var threeLargest = new int[] { int.MinValue, int.MinValue, int.MinValue };
        foreach (var num in array)
        {
            UpdateLargest(threeLargest, num);
        }
        return threeLargest;
    }

    public static void UpdateLargest(int[] threeLargest, int num)
    {
        if (num > threeLargest[2])
        {
            ShiftAndUpdate(threeLargest, num, 2);
        }
        else if (num > threeLargest[1])
        {
            ShiftAndUpdate(threeLargest, num, 1);
        }
        else if (num > threeLargest[0])
        {
            ShiftAndUpdate(threeLargest, num, 0);
        }
    }

    public static void ShiftAndUpdate(int[] array, int num, int index)
    {
        for (var i = 0; i <= index; i++)
        {
            if (i == index)
            {
                array[i] = num;
            }
            else
            {
                array[i] = array[i + 1];
            }
        }
    }
}
