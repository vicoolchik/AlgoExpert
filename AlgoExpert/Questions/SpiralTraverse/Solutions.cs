namespace AlgoExpert.SpiralTraverse;

public class Solutions
{
    public static void Run()
    {
        var array = new int[,]
        {
            {1, 2, 3, 4},
            {12, 13, 14, 5},
            {11, 16, 15, 6},
            {10, 9, 8, 7}
        };
        var result = SpiralTraverse(array);
        Console.WriteLine("Result: " + result);
    }
    public static List<int> SpiralTraverse(int[,] array)
    {
        // O(n) time | O(n) space where n is the total number of elements in the array
        var result = new List<int>();
        var startRow = 0;
        var endRow = array.GetLength(0) - 1;
        var startCol = 0;
        var endCol = array.GetLength(1) - 1;
        while (startRow <= endRow && startCol <= endCol)
        {
            for (var col = startCol; col <= endCol; col++)
            {
                result.Add(array[startRow, col]);
            }
            for (var row = startRow + 1; row <= endRow; row++)
            {
                result.Add(array[row, endCol]);
            }
            for (var col = endCol - 1; col >= startCol; col--)
            {
                if (startRow == endRow)
                {
                    break;
                }
                result.Add(array[endRow, col]);
            }
            for (var row = endRow - 1; row > startRow; row--)
            {
                if (startCol == endCol)
                {
                    break;
                }
                result.Add(array[row, startCol]);
            }
            startRow++;
            endRow--;
            startCol++;
            endCol--;
        }
        return result;
    }
}
