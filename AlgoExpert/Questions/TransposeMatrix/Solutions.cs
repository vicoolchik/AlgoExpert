
namespace AlgoExpert.TransposeMatrix
{
    public class Solutions
    {
        public void Run(string[] args)
        {
            var matrix = new int[,]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
            var transposedMatrix = TransposeMatrix1(matrix);
            foreach (var row in transposedMatrix)
            {
                Console.WriteLine(string.Join(", ", row));
            }
        }

        public int[,] TransposeMatrix(int[,] matrix)
        {
            //O(n*m) time | O(n*m) space
            //n is the number of rows and m is the number of columns
            var transposedMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    transposedMatrix[j, i] = matrix[i, j];
                }
            }
            return transposedMatrix;
        }
         public IEnumerable<int[]> TransposeMatrix1(int[,] matrix){
            //O(n*m) time | O(1) space
            //n is the number of rows and m is the number of columns
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                var row = new int[matrix.GetLength(0)];
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    row[j] = matrix[j, i];
                }
                yield return row;
            }
         }
    }
}