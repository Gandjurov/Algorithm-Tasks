using System;
using System.Text;

namespace ReverseWordOrder
{
    public class StartUp
    {
        public static void Main()
        {
            //Question: How to reverse the order of words in a given string.
            //Answer: The user will input a sentence and we need to reverse the sequence of words in the sentence.

            var firstInput = "Welcome to Csharp corner";

            ReverseWordOrder(firstInput);
        }

        private static void ReverseWordOrder(string inputStr)
        {
            int i;
            StringBuilder reverseSentance = new StringBuilder();

            int start = inputStr.Length - 1;
            int end = inputStr.Length - 1;

            while (start > 0)
            {
                if (inputStr[start] == ' ')
                {
                    i = start + 1;

                    while (i <= end)
                    {
                        reverseSentance.Append(inputStr[i]);
                        i++;
                    }
                    reverseSentance.Append(' ');
                    end = start - 1;
                }

                start--;
            }

            for (int j = 0; j <= end; j++)
            {
                reverseSentance.Append(inputStr[j]);
            }

            Console.WriteLine(reverseSentance.ToString());
        }

    }
}
