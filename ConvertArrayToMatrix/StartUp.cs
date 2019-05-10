using System;

namespace ConvertArrayToMatrix
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Question: How to convert a one-dimensional array to a two-dimensional array?
            //Answer:  The user will input 1-D array along with the number of rows and columns. ...
            //The method should convert this 1-D array to a 2-D array(matrix) of given row and column. We will create matrix row wise.

            int[] matrix = { 1, 2, 3, 4, 5, 6 };
            int row = 2;
            int col = 3;

            SingleToMultiArray(matrix, row, col);
        }

        private static void SingleToMultiArray(int[] matrix, int row, int col)
        {
            int index = 0;

            int[,] multiArray = new int[row, col];

            for (int y = 0; y < row; y++)
            {
                for (int x = 0; x < col; x++)
                {
                    multiArray[y, x] = matrix[index];
                    index++;
                    Console.Write(multiArray[y, x] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
