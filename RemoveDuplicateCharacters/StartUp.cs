using System;

namespace RemoveDuplicateCharacters
{
    public class StartUp
    {
        public static void Main()
        {
            //Question: How to remove duplicate characters from a string?
            //Answer: The user will input a string and the method should remove multiple occurrences of characters in the string
            var firstInput = "csharpcorner";

            RemoveDublicates(firstInput);
        }

        private static void RemoveDublicates(string inputStr)
        {
            string result = string.Empty;

            for (int i = 0; i < inputStr.Length; i++)
            {
                if (!result.Contains(inputStr[i]))
                {
                    result += inputStr[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}
