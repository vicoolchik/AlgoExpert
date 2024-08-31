namespace AlgoExpert.ProductSum;

public class Solutions
{
    public static void Run()
    {
        var array = new List<object> { 5, 2, new List<object> { 7, -1 }, 3, new List<object> { 6, new List<object> { -13, 8 }, 4 } };
        var result = ProductSum(array);
        Console.WriteLine("Result: " + result);
    }
    public static int ProductSum(List<object> array)
    {
        //O(n) time | O(d) space where n is the total number of elements in the array, including sub-elements, and d is the greatest depth of "special" arrays in the array
        return ProductSum(array, 1);
    }
    public static int ProductSum(List<object> array, int multiplier)
    {
        var sum = 0;
        foreach (var element in array)
        {
            if (element is List<object>)
            {
                sum += ProductSum((List<object>)element, multiplier + 1);
            }
            else
            {
                sum += (int)element;
            }
        }
        return sum * multiplier;
    }
}
