namespace AlgoExpert.LevenshteinDistance;

public class Solutions
{
    public static void Run()
    {
        var str1 = "abc";
        var str2 = "yabd";
        var result = LevenshteinDistance(str1, str2);
        Console.WriteLine("Result: " + result);
    }
    public static int LevenshteinDistance(string str1, string str2)
    {
        // O(nm) time | O(nm) space
        var edits = new int[str2.Length + 1, str1.Length + 1];
        for (var i = 0; i < str2.Length + 1; i++)
        {
            for (var j = 0; j < str1.Length + 1; j++)
            {
                edits[i, j] = j;
            }
            edits[i, 0] = i;
        }
        for (var i = 1; i < str2.Length + 1; i++)
        {
            for (var j = 1; j < str1.Length + 1; j++)
            {
                if (str2[i - 1] == str1[j - 1])
                {
                    edits[i, j] = edits[i - 1, j - 1];
                }
                else
                {
                    edits[i, j] = 1 + Math.Min(edits[i - 1, j - 1], Math.Min(edits[i - 1, j], edits[i, j - 1]));
                }
            }
        }
        return edits[str2.Length, str1.Length];
    }
    public static int LevenshteinDistanceBetterSpace(string str1, string str2)
    {
        string small = str1.Length < str2.Length ? str1 : str2;
        string big = str1.Length < str2.Length ? str2 : str1;
        int[] evenEdits = new int[small.Length + 1];
        int[] oddEdits = new int[small.Length + 1];
        for (int j = 0; j < small.Length + 1; j++)
        {
            evenEdits[j] = j;
        }

        int[] currentEdits;
        int[] previousEdits;
        for (int i = 1; i < big.Length + 1; i++)
        {
            if (i % 2 == 1)
            {
                currentEdits = oddEdits;
                previousEdits = evenEdits;
            }
            else
            {
                currentEdits = evenEdits;
                previousEdits = oddEdits;
            }

            currentEdits[0] = i;

            for (int j = 1; j < small.Length + 1; j++)
            {
                if (big[i - 1] == small[j - 1])
                {
                    currentEdits[j] = previousEdits[j - 1];
                }
                else
                {
                    currentEdits[j] = 1 + Math.Min(previousEdits[j - 1],
                        Math.Min(previousEdits[j], currentEdits[j - 1]));
                }
            }
        }

        return big.Length % 2 == 0 ? evenEdits[small.Length] : oddEdits[small.Length];
    }
}
