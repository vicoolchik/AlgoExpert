using System.Linq.Expressions;

namespace AlgoExpert.TandemBicycle;

public class Solutions
{
    public static void Run()
    {
        var redShirtSpeeds =new int[] { 5, 5, 3, 9, 2 };
        var blueShirtSpeeds = new int[] { 3, 6, 7, 2, 1 };
        var result = TandemBicycle(redShirtSpeeds, blueShirtSpeeds, true);
        Console.WriteLine("Result: " + result);
    }

    public static int TandemBicycle(int[] redShirtSpeeds, int[] blueShirtSpeeds, bool fastest)
    {
        // O(nlogn) time | O(1) space where n is the number of students
        Array.Sort(redShirtSpeeds);
        Array.Sort(blueShirtSpeeds);
        var length = redShirtSpeeds.Length-1;
        if(length<0) return 0;
        var diggerarray = (redShirtSpeeds[length] > blueShirtSpeeds[length]) ? redShirtSpeeds : blueShirtSpeeds;
        var loverarray = (redShirtSpeeds[length] > blueShirtSpeeds[length]) ? blueShirtSpeeds : redShirtSpeeds;
        if (!fastest)
        {
            Array.Reverse(blueShirtSpeeds);
        }

        int totalSpeed = 0;
        for (var i = 0; i <= length; i++)
        {
            totalSpeed += Math.Max(loverarray[i], diggerarray[length - i]);
        }
        return totalSpeed;
    }
}
