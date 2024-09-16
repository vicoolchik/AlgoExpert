namespace AlgoExpert.MajorityElement;

public class Solutions
{
    public static void Run()
    {
        var result = MajorityElement(new int[] { 3, 2, 3 });
        Console.WriteLine("Result: " + result);
    }
    public static int MajorityElement(int[] array)
    {
        // O(n) time | O(1) space where n is the length of the array
        var majorityElement = 0;
        var count = 0;
        foreach (var num in array)
        {
            if (count == 0)
            {
                majorityElement = num;
            }
            if (num == majorityElement)
            {
                count++;
            }
            else
            {
                count--;
            }
        }
        return majorityElement;
    }
}
