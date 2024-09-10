namespace AlgoExpert.ArrayOfProducts;

public class Solutions
{
    public static void Run()
    {
        var array = new int[] { 5, 1, 4, 2 };
        var result = ArrayOfProducts(array);
        Console.WriteLine("Result: " + string.Join(", ", result));
    }
    public static int[] ArrayOfProducts(int[] array)
    {
        // O(n) time | O(n) space where n is the length of the array
        var products = new int[array.Length];
        var leftProducts = new int[array.Length];
        var rightProducts = new int[array.Length];
        var leftRunningProduct = 1;
        for (var i = 0; i < array.Length; i++)
        {
            leftProducts[i] = leftRunningProduct;
            leftRunningProduct *= array[i];
        }
        var rightRunningProduct = 1;
        for (var i = array.Length - 1; i >= 0; i--)
        {
            rightProducts[i] = rightRunningProduct;
            rightRunningProduct *= array[i];
        }
        for (var i = 0; i < array.Length; i++)
        {
            products[i] = leftProducts[i] * rightProducts[i];
        }
        return products;
    }
    public static int[] ArrayOfProductsOptimized(int[] array)
    {
        // O(n) time | O(n) space where n is the length of the array
        var products = new int[array.Length];
        var leftRunningProduct = 1;
        for (var i = 0; i < array.Length; i++)
        {
            products[i] = leftRunningProduct;
            leftRunningProduct *= array[i];
        }
        var rightRunningProduct = 1;
        for (var i = array.Length - 1; i >= 0; i--)
        {
            products[i] *= rightRunningProduct;
            rightRunningProduct *= array[i];
        }
        return products;
    }
    public static int[] ArrayOfProductsBruteForce(int[] array)
    {
        // O(n^2) time | O(n) space where n is the length of the array
        var products = new int[array.Length];
        for (var i = 0; i < array.Length; i++)
        {
            var runningProduct = 1;
            for (var j = 0; j < array.Length; j++)
            {
                if (i != j)
                {
                    runningProduct *= array[j];
                }
            }
            products[i] = runningProduct;
        }
        return products;
    }
}
