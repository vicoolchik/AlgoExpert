namespace AlgoExpert.NonConstructibleChange;

public class Solutions
{
    public static void Run()
    {
        int[] coins = { 5, 7, 1, 1, 2, 3, 22 };
        int result = NonConstructibleChange(coins);
        Console.WriteLine("Result: " + result);
    }
    private static int NonConstructibleChange(int[] coins)
    {
        //O(nlog(n)) time | O(1) space
        Array.Sort(coins);
        int currentChangeCreated = 0;
        foreach (var coin in coins)
        {
            if (coin > currentChangeCreated + 1)
            {
                return currentChangeCreated + 1;
            }
            currentChangeCreated += coin;
        }
        return currentChangeCreated + 1;
    }
}
