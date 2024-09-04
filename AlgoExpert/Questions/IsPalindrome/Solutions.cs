namespace AlgoExpert.IsPalindrome;

public class Solutions
{
   public static void Run()
   {
      var result = IsPalindrome("abcdcba");
      Console.WriteLine("Result: " + result);
   }
   public static bool IsPalindrome(string str)
   {
      // O(n) time | O(1) space
      var leftIdx = 0;
      var rightIdx = str.Length - 1;
      while (leftIdx < rightIdx)
      {
         if (str[leftIdx] != str[rightIdx])
         {
            return false;
         }
         leftIdx++;
         rightIdx--;
      }
      return true;
   } 
}
