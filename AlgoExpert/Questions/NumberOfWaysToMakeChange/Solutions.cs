namespace AlgoExpert.NumberOfWaysToMakeChange;

public class Solutions
{
    public static void Run()
    {
        var result = NumberOfWaysToMakeChange(6, new int[] { 1, 5 });
        Console.WriteLine("Result: " + result);
    }
    public static int NumberOfWaysToMakeChange(int n, int[] denoms)
    {
        // O(nd) time | O(n) space where n is the target amount and d is the number of denominations
        var ways = new int[n + 1];
        ways[0] = 1;
        foreach (var denom in denoms)
        {
            for (int amount = 1; amount < n + 1; amount++)
            {
                if (denom <= amount)
                {
                    ways[amount] += ways[amount - denom];
                }
            }
        }
        return ways[n];
    }
}
