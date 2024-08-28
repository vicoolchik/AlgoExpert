namespace AlgoExpert.ClassPhotos;

public class Solutions
{

    public static void Run()
    {
        var redShirtHeights = new List<int> { 5, 8, 1, 3, 4 };
        var blueShirtHeights = new List<int> { 6, 9, 2, 4, 5 };
        var result = ClassPhotos(redShirtHeights, blueShirtHeights);
        Console.WriteLine("Result: " + result);
    }

    public static bool ClassPhotos(List<int> redShirtHeights, List<int> blueShirtHeights)
    {
        // O(nlogn) time | O(1) space where n is the number of students
        redShirtHeights.Sort();
        blueShirtHeights.Sort();

        int count = redShirtHeights.Count-1;
        var redShirtTaller = redShirtHeights[count] > blueShirtHeights[count];
        for (var i = count; i >= 0; i--)
        {
            if (redShirtTaller)
            {
                if (redShirtHeights[i] <= blueShirtHeights[i]) return false;
            }
            else
            {
                if (redShirtHeights[i] >= blueShirtHeights[i]) return false;
            }
        }
        return true;
    }
}
