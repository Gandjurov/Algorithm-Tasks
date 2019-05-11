using System;

namespace RightCircularRotation
{
    public class StartUp
    {
        public static void Main()
        {
            //Question: How to perform Right circular rotation of an array?
            //Answer: The user will input an integer array and the method should shift - 
            //each element of input array to its Right by one position in circular fashion. The logic is to iterate loop from 0 to Length-1 and swap each element with first element

            int[] firstInput = { 1, 2, 3, 4, 5 };

            RotateRight(firstInput);
        }

        private static void RotateRight(int[] array)
        {
            int size = array.Length;
            int temp = 0;

            for (int j = 0; j < size - 1; j++)
            {
                temp = array[0];
                array[0] = array[j + 1];
                array[j + 1] = temp;
            }

            foreach (var num in array)
            {
                Console.WriteLine(num + " ");
            }
        }
    }
}
