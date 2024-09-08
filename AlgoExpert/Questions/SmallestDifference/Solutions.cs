namespace AlgoExpert.SmallestDifference;

public class Solutions
{
 public static void Run()
 {
     var arrayOne = new int[] { -1, 5, 10, 20, 28, 3 };
     var arrayTwo = new int[] { 26, 134, 135, 15, 17 };
     var result = SmallestDifference(arrayOne, arrayTwo);
     Console.WriteLine("Result: " + result);
 }
 public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
 {
     // O(nlog(n) + mlog(m)) time | O(1) space where n is the length of the arrayOne and m is the length of the arrayTwo
     Array.Sort(arrayOne);
     Array.Sort(arrayTwo);
     var idxOne = 0;
     var idxTwo = 0;
     var smallest = int.MaxValue;
     var current = int.MaxValue;
     var smallestPair = new int[2];
     while (idxOne < arrayOne.Length && idxTwo < arrayTwo.Length)
     {
         var firstNum = arrayOne[idxOne];
         var secondNum = arrayTwo[idxTwo];
         if (firstNum < secondNum)
         {
             current = secondNum - firstNum;
             idxOne++;
         }
         else if (secondNum < firstNum)
         {
             current = firstNum - secondNum;
             idxTwo++;
         }
         else
         {
             return new int[] { firstNum, secondNum };
         }
         if (smallest > current)
         {
             smallest = current;
             smallestPair = new int[] { firstNum, secondNum };
         }
     }
     return smallestPair;
 }
}
