using System;

namespace ReverseString
{
    public class StartUp
    {
        public static void Main()
        {
            var input = "hello world";
            ReverseString(input);
        }

        private static void ReverseString(string inputStr)
        {
            char[] charArr = inputStr.ToCharArray();

            for (int i = 0, j = inputStr.Length - 1;  i < j; i++, j--)
            {
                charArr[i] = inputStr[j];
                charArr[j] = inputStr[i];
            }

            string reversedString = new string(charArr);

            Console.WriteLine(reversedString);
        }
    }
}
