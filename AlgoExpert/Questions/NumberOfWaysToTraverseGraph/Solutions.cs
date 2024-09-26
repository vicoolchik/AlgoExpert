namespace AlgoExpert.NumberOfWaysToTraverseGraph;

public class Solutions
{
    public static void Run()
    {
        var width = 4;
        var height = 3;
        var result = NumberOfWaysToTraverseGraph(width, height);
        Console.WriteLine("Result: " + result);
    }
    public static int NumberOfWaysToTraverseGraph(int width, int height)
    {
        // O(nm) time | O(nm) space
        var ways = new int[height + 1, width + 1];
        for (var i = 1; i < height + 1; i++)
        {
            for (var j = 1; j < width + 1; j++)
            {
                if (i == 1 || j == 1)
                {
                    ways[i, j] = 1;
                }
                else
                {
                    ways[i, j] = ways[i - 1, j] + ways[i, j - 1];
                }
            }
        }
        return ways[height, width];
    }
    public static int NumberOfWaysToTraverseGraphBetterSpace(int width, int height)
    {
        // O(nm) time | O(min(n, m)) space
        var small = width < height ? width : height;
        var big = width < height ? height : width;
        var evenWays = new int[small + 1];
        var oddWays = new int[small + 1];
        for (var i = 1; i < small + 1; i++)
        {
            evenWays[i] = 1;
            oddWays[i] = 1;
        }
        for (var i = 2; i < big + 1; i++)
        {
            var currentWays = i % 2 == 1 ? oddWays : evenWays;
            var previousWays = i % 2 == 1 ? evenWays : oddWays;
            currentWays[1] = 1;
            for (var j = 2; j < small + 1; j++)
            {
                currentWays[j] = currentWays[j - 1] + previousWays[j];
            }
        }
        return big % 2 == 0 ? evenWays[small] : oddWays[small];
    }
    public static int NumberOfWaysToTraverseGraphRecursive(int width, int height)
    {
        // O(2^(n + m)) time | O(n + m) space
        if (width == 1 || height == 1)
        {
            return 1;
        }
        return NumberOfWaysToTraverseGraphRecursive(width - 1, height) + NumberOfWaysToTraverseGraphRecursive(width, height - 1);
    }
    public static int NumberOfWaysToTraverseGraphRecursiveBetter(int width, int height)
    {
        // O(n + m) time | O(1) space
        int xDistanceToCorner = width - 1;
        int yDistanceToCorner = height - 1;
        return Factorial(xDistanceToCorner + yDistanceToCorner) / (Factorial(xDistanceToCorner) * Factorial(yDistanceToCorner));
    }
    private static int Factorial(int num)
    {
        int result = 1;
        for (var i = 2; i < num + 1; i++)
        {
            result *= i;
        }
        return result;
    }
}
