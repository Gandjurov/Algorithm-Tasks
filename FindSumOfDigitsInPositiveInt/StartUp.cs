using System;

namespace FindSumOfDigitsInPositiveInt
{
    public class StartUp
    {
        public static void Main()
        {
            //Question: How to find the sum of digits of a positive integer?
            //Answer: The user will input a positive integer and the method should return the sum of all the digits in that integer.

            var firstInput = 168;

            SumOfDigits(firstInput);
        }

        private static void SumOfDigits(int number)
        {
            int sum = 0;
            
            while (number > 0)
            {
                int temp = number % 10;

                sum += temp;
                number /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
