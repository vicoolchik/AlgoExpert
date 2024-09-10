namespace AlgoExpert.LongestPeak;

public class Solutions
{
    public static void Run()
    {
        var array = new int[] { 1, 2, 3, 3, 4, 0, 10, 6, 5, -1, -3, 2, 3 };
        var result = LongestPeak(array);
        Console.WriteLine("Result: " + result);
    }
    public static int LongestPeak(int[] array)
    {
        // O(n) time | O(1) space where n is the length of the array
        var longestPeakLength = 0;
        var i = 1;
        while (i < array.Length - 1)
        {
            var isPeak = array[i - 1] < array[i] && array[i] > array[i + 1];
            if (!isPeak)
            {
                i++;
                continue;
            }
            var leftIdx = i - 2;
            while (leftIdx >= 0 && array[leftIdx] < array[leftIdx + 1])
            {
                leftIdx--;
            }
            var rightIdx = i + 2;
            while (rightIdx < array.Length && array[rightIdx] < array[rightIdx - 1])
            {
                rightIdx++;
            }
            var currentPeakLength = rightIdx - leftIdx - 1;
            if (currentPeakLength > longestPeakLength)
            {
                longestPeakLength = currentPeakLength;
            }
            i = rightIdx;
        }
        return longestPeakLength;
    }
}
