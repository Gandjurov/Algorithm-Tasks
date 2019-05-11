using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseEachWordInString
{
    public class StartUp
    {
        public static void Main()
        {
            //Question: How to reverse each word in a given string?
            //Answer: The user will input a sentence and we need to reverse each word individually without changing its position in the sentence.

            var firstInput = "Welcome to Csharp corner";

            ReverseWords(firstInput);
        }

        private static void ReverseWords(string inputStr)
        {
            StringBuilder result = new StringBuilder();
            List<char> charList = new List<char>();

            for (int i = 0; i < inputStr.Length; i++)
            {
                if (inputStr[i] == ' ' || i == inputStr.Length - 1)
                {
                    if (i == inputStr.Length - 1)
                    {
                        charList.Add(inputStr[i]);
                    }

                    for (int j = charList.Count - 1; j >= 0; j--)
                    {
                        result.Append(charList[j]);
                    }

                    result.Append(' ');
                    charList = new List<char>();
                }
                else
                {
                    charList.Add(inputStr[i]);
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
