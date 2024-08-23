
namespace AlgoExpert.SortedSquaredArray;

public class Solutions
{
    public static void Run()
    {
        int[] array = { -10, -5, 0, 5, 10 };
        int[] result = SortedSquaredArraySolution1(array);
        Console.WriteLine("Result: " + string.Join(", ", result));
    }
    private static int[] SortedSquaredArraySolution1(int[] array)
    {
        //O(nlog(n)) time | O(n) space
        int[] sortedSquares = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            int value = array[i];
            sortedSquares[i] = value * value;
        }
        Array.Sort(sortedSquares);
        return sortedSquares;
    }
    private static int[] SortedSquaredArraySolution2(int[] array)
    {
        //O(n) time | O(n) space
        int[] sortedSquares = new int[array.Length];
        int smallerValueIndex = 0;
        int largerValueIndex = array.Length - 1;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            int smallerValue = array[smallerValueIndex];
            int largerValue = array[largerValueIndex];
            if (Math.Abs(smallerValue) > Math.Abs(largerValue))
            {
                sortedSquares[i] = smallerValue * smallerValue;
                smallerValueIndex++;
            }
            else
            {
                sortedSquares[i] = largerValue * largerValue;
                largerValueIndex--;
            }
        }
        return sortedSquares;
    }
}
