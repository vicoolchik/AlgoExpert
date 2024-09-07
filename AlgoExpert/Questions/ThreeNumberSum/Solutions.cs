namespace AlgoExpert.ThreeNumberSum;

public class Solutions
{
    public static void Run()
    {
        var array = new int[] { 12, 3, 1, 2, -6, 5, -8, 6 };
        var targetSum = 0;
        var result = ThreeNumberSum(array, targetSum);
        Console.WriteLine("Result: " + result);
    }
    public static List<int[]> ThreeNumberSum(int[] array, int targetSum)
    {
        // O(n^2) time | O(n) space where n is the length of the array
        Array.Sort(array);
        var triplets = new List<int[]>();
        for (var i = 0; i < array.Length - 2; i++)
        {
            var left = i + 1;
            var right = array.Length - 1;
            while (left < right)
            {
                var currentSum = array[i] + array[left] + array[right];
                if (currentSum == targetSum)
                {
                    triplets.Add(new int[] { array[i], array[left], array[right] });
                    left++;
                    right--;
                }
                else if (currentSum < targetSum)
                {
                    left++;
                }
                else if (currentSum > targetSum)
                {
                    right--;
                }
            }
        }
        return triplets;
    }

    public static List<int[]> ThreeNumberSumBruteForce(int[] array, int targetSum)
    {
        // O(n^3) time | O(n) space where n is the length of the array
        var triplets = new List<int[]>();
        for (var i = 0; i < array.Length - 2; i++)
        {
            for (var j = i + 1; j < array.Length - 1; j++)
            {
                for (var k = j + 1; k < array.Length; k++)
                {
                    if (array[i] + array[j] + array[k] == targetSum)
                    {
                        triplets.Add(new int[] { array[i], array[j], array[k] });
                    }
                }
            }
        }
        return triplets;
    }

    public static List<int[]> ThreeNumberSumHash(int[] array, int targetSum)
    {
        // O(n^2) time | O(n) space where n is the length of the array
        var triplets = new List<int[]>();
        for (var i = 0; i < array.Length - 2; i++)
        {
            var nums = new HashSet<int>();
            for (var j = i + 1; j < array.Length; j++)
            {
                var currentSum = targetSum - array[i] - array[j];
                if (nums.Contains(currentSum))
                {
                    triplets.Add(new int[] { array[i], currentSum, array[j] });
                }
                else
                {
                    nums.Add(array[j]);
                }
            }
        }
        return triplets;
    }
}