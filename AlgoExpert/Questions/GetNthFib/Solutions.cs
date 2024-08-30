namespace AlgoExpert.GetNthFib;

public class Solutions
{
    public static void Run()
    {
        var result = GetNthFib(6);
        Console.WriteLine("Result: " + result);
    }

    public static int GetNthFib(int n)
    {
        //O(2^n) time | O(n) space
        if (n == 2)
        {
            return 1;
        }
        else if (n == 1)
        {
            return 0;
        }
        else
        {
            return GetNthFib(n - 1) + GetNthFib(n - 2);
        }
    }

    public static int GetNthFib1(int n)
    {
        //O(n) time | O(1) space
        var lastTwo = new int[] { 0, 1 };
        var counter = 3;
        while (counter <= n)
        {
            var nextFib = lastTwo[0] + lastTwo[1];
            lastTwo[0] = lastTwo[1];
            lastTwo[1] = nextFib;
            counter++;
        }
        return n > 1 ? lastTwo[1] : lastTwo[0];
    }
}

