namespace AlgoExpert.MinNumberOfCoinsForChange;

public class Solutions
{
    public static void Run()
    {
        int[] coins = { 1, 2, 4 };
        int target = 6;
        int result = MinNumberOfCoinsForChange(target, coins);
        Console.WriteLine("Result: " + result);
    }
    public static int MinNumberOfCoinsForChange(int n, int[] denoms)
    {
        // O(nd) time | O(n) space where n is the target amount and d is the number of denominations
        var numOfCoins = new int[n + 1];
        Array.Fill(numOfCoins, int.MaxValue);
        numOfCoins[0] = 0;
        foreach (var denom in denoms)
        {
            for (int amount = 1; amount < n + 1; amount++)
            {
                if (denom <= amount)
                {
                    numOfCoins[amount] = Math.Min(numOfCoins[amount], numOfCoins[amount - denom] + 1);
                }
            }
        }
        return numOfCoins[n] != int.MaxValue ? numOfCoins[n] : -1;
    }
}
