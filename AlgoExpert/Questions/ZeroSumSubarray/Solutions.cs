namespace AlgoExpert.ZeroSumSubarray;

public class Solutions
{
    public static void Run()
    {
        var result = ZeroSumSubarray(new int[] { 1, 2, 3, 4, -4, 6 });
        Console.WriteLine("Result: " + result);
    }
    public static bool ZeroSumSubarray(int[] array)
    {
        // O(n) time | O(n) space where n is the length of the array
        var sum = 0;
        var hashSet = new HashSet<int>();
        foreach (var num in array)
        {
            sum += num;
            if (hashSet.Contains(sum))
            {
                return true;
            }
            hashSet.Add(sum);
        }
        return false;
    }
}
