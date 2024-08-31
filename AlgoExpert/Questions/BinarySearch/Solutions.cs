namespace AlgoExpert.BinarySearch;

public class Solutions
{
    public static void Run()
    {
        var array = new int[] { 0, 1, 21, 33, 45, 45, 61, 71, 72, 73 };
        var target = 33;
        var result = BinarySearch(array, target);
        Console.WriteLine("Result: " + result);
    }

    public static int BinarySearch(int[] array, int target)
    {
        // O(log(n)) time | O(log(n)) space
        return BinarySearch(array, target, 0, array.Length - 1);
    }
    public static int BinarySearch(int[] array, int target, int left, int right)
    {
        if (left > right)
        {
            return -1;
        }
        var middle = (left + right) / 2;
        var potentialMatch = array[middle];
        if (target == potentialMatch)
        {
            return middle;
        }
        else if (target < potentialMatch)
        {
            return BinarySearch(array, target, left, middle - 1);
        }
        else
        {
            return BinarySearch(array, target, middle + 1, right);
        }
    }

    public static int BinarySearch1(int[] array, int target, int left, int right)
    {
        while (left <= right)
        {
            var middle = (left + right) / 2;
            var potentialMatch = array[middle];
            if (target == potentialMatch)
            {
                return middle;
            }
            else if (target < potentialMatch)
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }
        return -1;
    }
}
