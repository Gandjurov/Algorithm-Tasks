using System;
using System.Collections.Generic;

namespace CountOccurrenceEachChar
{
    public class StartUp
    {
        public static void Main()
        {
            //Question: How to count the occurrence of each character in a string?
            //Answer: The user will input a string and we need to find the count of each character of the string and display it on console. We won’t be counting space character.

            var firstInput = "hello world";

            CountCharacter(firstInput);
        }

        private static void CountCharacter(string inputStr)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (var currentChar in inputStr)
            {
                if (currentChar != ' ')
                {
                    if (!charCount.ContainsKey(currentChar))
                    {
                        charCount.Add(currentChar, 1);
                    }
                    else
                    {
                        charCount[currentChar]++;
                    }
                }
            }

            foreach (var character in charCount)
            {
                Console.WriteLine($"{character.Key} - {character.Value}");
            }
        }
    }
}
