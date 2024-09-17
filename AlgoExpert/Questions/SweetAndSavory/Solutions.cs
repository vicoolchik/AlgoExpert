using System.Runtime.CompilerServices;

namespace AlgoExpert.SweetAndSavory;

public class Solutions
{
    public static void Run()
    {
        var dishes = new int[] { 1, 2, -3, 4, 5, -6, 7, -8, 9 };
        var result = SweetAndSavory(dishes, 3);
        Console.WriteLine("Result: " + result);
    }
     public static int[] SweetAndSavory(int[] dishes, int target)
    {
        List<int> sweetDishes = new List<int>();
        List<int> savoryDishes = new List<int>();

        foreach (var dish in dishes)
        {
            if (dish < 0)
            {
                sweetDishes.Add(dish);
            }
            else
            {
                savoryDishes.Add(dish);
            }
        }

        sweetDishes.Sort((a, b) => Math.Abs(a) - Math.Abs(b));
        savoryDishes.Sort();

        int[] bestPair = new int[2];
        int bestDifference = Int32.MaxValue;
        int sweetIndex = 0, savoryIndex = 0;

        while (sweetIndex < sweetDishes.Count && savoryIndex < savoryDishes.Count)
        {
            int currentSum = sweetDishes[sweetIndex] + savoryDishes[savoryIndex];

            if (currentSum <= target)
            {
                int currentDifference = target - currentSum;
                if (currentDifference < bestDifference)
                {
                    bestDifference = currentDifference;
                    bestPair[0] = sweetDishes[sweetIndex];
                    bestPair[1] = savoryDishes[savoryIndex];
                }
                savoryIndex++;
            }
            else
            {
                sweetIndex++;
            }
        }

        return bestPair;
    }
}
