namespace AlgoExpert.TwoNumberSum;

public class Solutions
{
    public static void Run()
    {
        int[] array = { 3, 5, -4, 8, 11, 1, -1, 6 };
        int targetSum = 10;
        int[] result = TwoNumberSumHash(array, targetSum);
        Console.WriteLine("Result: " + result[0] + " " + result[1]);
    }
    public static int[] TwoNumberSumHash(int[] array, int targetSum)
    {
        //O(n) time | O(n) space
        HashSet<int> nums = new HashSet<int>();
        foreach (int num in array)
        {
            int potMatch = targetSum - num;
            if (nums.Contains(potMatch))
            {
                return new int[] { potMatch, num };
            }
            else
            {
                nums.Add(num);
            }
        }
        return new int[0];
    }
    public static int[] TwoNumberSumForLoop(int[] array, int targetSum)
    {
        //O(n^2) time | O(1) space
        for (int i = 0; i < array.Length - 1; i++)
        {
            int firstNum = array[i];
            for (int j = i + 1; j < array.Length; j++)
            {
                int secondNum = array[j];
                if (firstNum + secondNum == targetSum)
                {
                    return new int[] { firstNum, secondNum };
                }
            }
        }
        return new int[0];
    }
    public static int[] TwoNumberSumSort(int[] array, int targetSum)
    {
        //O(nlog(n)) time | O(1) space
        Array.Sort(array);
        int left = 0;
        int right = array.Length - 1;
        while (left < right)
        {
            int currentSum = array[left] + array[right];
            if (currentSum == targetSum)
            {
                return new int[] { array[left], array[right] };
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
        return new int[0];
    }
}
