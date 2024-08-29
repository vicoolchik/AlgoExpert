namespace AlgoExpert.OptimalFreelancing;

public class Solutions
{
    public static void Run()
    {
        Dictionary<string, int>[] jobs = new Dictionary<string, int>[]
        {
            new Dictionary<string, int> { {"deadline", 3}, {"payment", 100} },
            new Dictionary<string, int> { {"deadline", 5}, {"payment", 150} },
            new Dictionary<string, int> { {"deadline", 2}, {"payment", 200} }
        };
        var result = OptimalFreelancing(jobs);
        Console.WriteLine("Result: " + result);
    }

    public static int OptimalFreelancing(Dictionary<string, int>[] jobs)
    {
        // O(nlogn) time | O(n) space where n is the number of jobs
        Array.Sort(jobs, (a, b) => b["payment"].CompareTo(a["payment"]));
        int maxDeadline = 7;
        int[] slots = new int[maxDeadline];
        int totalPayment = 0;
        foreach (var job in jobs)
        {
            int maxTime = Math.Min(job["deadline"], maxDeadline);
            for (int i = maxTime - 1; i >= 0; i--)
            {
                if (slots[i] == 0)
                {
                    slots[i] = job["payment"];
                    totalPayment += job["payment"];
                    break;
                }
            }
        }
        return totalPayment;
    }
}
