using System;

namespace SecondLargestInteger
{
    public class StartUp
    {
        public static void Main()
        {
            //Question: How to find second largest integer in an array using only one loop?
            //Answer: The user will input an unsorted integer array and the method should find the second largest integer in the array.

            int[] numbers = { 3, 2, 1, 5, 4 };

            FindSecondLargeInArray(numbers);
        }

        private static void FindSecondLargeInArray(int[] numbers)
        {
            int max1 = int.MinValue;
            int max2 = int.MinValue;

            foreach (var num in numbers)
            {
                if (num > max1)
                {
                    max2 = max1;
                    max1 = num;
                }
                else if (num > max2)
                {
                    max2 = num;
                }
            }

            Console.WriteLine(max2);
        }
    }
}
