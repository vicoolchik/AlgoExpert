namespace AlgoExpert.MergeOverlappingIntervals;

public class Solutions
{
    public static void Run()
    {
        var intervals = new int[][]
        {
            new int[] { 1, 2 },
            new int[] { 6, 8 },
            new int[] { 3, 5 },
            new int[] { 4, 7 },
            new int[] { 9, 10 }
        };
        var result = MergeOverlappingIntervals(intervals);
        Console.WriteLine("Result: " + string.Join(", ", result.Select(x => $"[{x[0]}, {x[1]}]")));
    }
    public static int[][] MergeOverlappingIntervals(int[][] intervals)
    {
        // O(nlog(n)) time | O(n) space where n is the length of the intervals
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        var mergedIntervals = new List<int[]>();
        var currentInterval = intervals[0];
        mergedIntervals.Add(currentInterval);
        foreach (var nextInterval in intervals)
        {
            var currentIntervalEnd = currentInterval[1];
            var nextIntervalStart = nextInterval[0];
            var nextIntervalEnd = nextInterval[1];
            if (currentIntervalEnd >= nextIntervalStart)
            {
                currentInterval[1] = Math.Max(currentIntervalEnd, nextIntervalEnd);
            }
            else
            {
                currentInterval = nextInterval;
                mergedIntervals.Add(currentInterval);
            }
        }
        return mergedIntervals.ToArray();
    }
}
