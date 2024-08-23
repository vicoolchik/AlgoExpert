namespace AlgoExpert.ValidSubsequence;

public class Solutions
{
    public static void Run()
    {
        List<int> array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
        List<int> sequence = new List<int> { 1, 6, -1, 10 };
        bool result = IsValidSubsequenceSolution1(array, sequence);
        Console.WriteLine("Result: " + result);
    }

    public static bool IsValidSubsequenceSolution1(List<int> array, List<int> sequence)
    {
        int arrayIndex = 0;
        int sequenceIndex = 0;
        while (arrayIndex < array.Count && sequenceIndex < sequence.Count)
        {
            if (array[arrayIndex] == sequence[sequenceIndex])
            {
                sequenceIndex++;
            }
            arrayIndex++;
        }
        return sequenceIndex == sequence.Count;
    }

    public static bool IsValidSubsequenceSolution2(List<int> array, List<int> sequence)
    {
        int sequenceIndex = 0;
        foreach (int value in array)
        {
            if (sequenceIndex == sequence.Count)
            {
                break;
            }
            if (sequence[sequenceIndex] == value)
            {
                sequenceIndex++;
            }
        }
        return sequenceIndex == sequence.Count;
    }
}
