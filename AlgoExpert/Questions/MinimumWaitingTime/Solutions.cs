namespace AlgoExpert.MinimumWaitingTime;

public class Solutions
{
    public static void Run()
    {
        var queries = new int[] { 3, 2, 1, 2, 6 };
        var result = MinimumWaitingTime(queries);
        Console.WriteLine("Result: " + result);
    }

    public static int MinimumWaitingTime(int[] queries)
    {
        // O(nlogn) time | O(1) space where n is the number of queries
        Array.Sort(queries);
        var totalWaitingTime = 0;
        for (var i = 0; i < queries.Length; i++)
        {
            var duration = queries[i];
            var queriesLeft = queries.Length - (i + 1);
            totalWaitingTime += duration * queriesLeft;
        }
        return totalWaitingTime;
    }
}
