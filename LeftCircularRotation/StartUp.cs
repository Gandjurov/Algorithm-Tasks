using System;

namespace LeftCircularRotation
{
    public class StartUp
    {
        public static void Main()
        {
            //Question: How to perform Left circular rotation of an array?
            //Answer: The user will input an integer array and the method should shift each element -
            //of input array to its Left by one position in circular fashion. The logic is to iterate loop from Length-1 to 0 and swap each element with last element.

            int[] firstInput = { 1, 2, 3, 4, 5};

            RotateLeft(firstInput);
        }

        private static void RotateLeft(int[] array)
        {
            int size = array.Length;
            int temp = 0;

            for (int j = size - 1; j > 0; j--)
            {
                temp = array[size - 1];
                array[array.Length - 1] = array[j - 1];
                array[j - 1] = temp;
            }

            foreach (var num in array)
            {
                Console.WriteLine(num + " ");
            }
        }
    }
}
