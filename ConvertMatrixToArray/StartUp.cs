using System;

namespace ConvertMatrixToArray
{
    public class StartUp
    {
        public static void Main()
        {
            //Question: How to convert a two-dimensional array to a one-dimensional array?
            //Answer: The user will input a 2-D array (matrix) and we need to convert it to a 1-D array. We will create 1-D array column wise.

            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };

            MultiToSingleArray(matrix);
        }

        private static void MultiToSingleArray(int[,] matrix)
        {
            int index = 0;
            int width = matrix.GetLength(0);
            int height = matrix.GetLength(1);

            int[] singleArray = new int[width * height];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    singleArray[index] = matrix[x, y];
                    Console.Write(singleArray[index] + " ");
                    index++;
                }
            }
            Console.WriteLine();
        }
    }
}
