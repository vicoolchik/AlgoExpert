namespace AlgoExpert.MoveElementToEnd;

public class Solutions
{
    public static void Run()
    {
        var array = new List<int> { 2, 1, 2, 2, 2, 3, 4, 2 };
        var toMove = 2;
        var result = MoveElementToEnd2(array, toMove);
        Console.WriteLine("Result: " + string.Join(", ", result));
    }
    public static List<int> MoveElementToEnd(List<int> array, int toMove)
    {
        // O(n) time | O(1) space where n is the length of the array
        var i = 0;
        var j = array.Count - 1;
        while (i < j)
        {
            while (i < j && array[j] == toMove)
            {
                j--;
            }
            if (array[i] == toMove)
            {
                Swap(i, j, array);
            }
            i++;
        }
        return array;
    }
    public static void Swap(int i, int j, List<int> array)
    {
        var temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
     public static List<int> MoveElementToEnd2(List<int> array, int toMove){
        // O(n) time | O(1) space where n is the length of the array
        var len = array.Count;
        for (var i = 0; i < len; )
        {
            if (array[i] == toMove)
            {
                array.RemoveAt(i);
                array.Add(toMove);
                len--;
            }
            else
            {
                i++;
            }
        }
        return array;
     }
}
