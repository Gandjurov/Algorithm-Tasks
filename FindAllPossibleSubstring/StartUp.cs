using System;
using System.Text;

namespace FindAllPossibleSubstring
{
    public class StartUp
    {
        public static void Main()
        {
            var firstInput = "abcd";

            FindAllSubstring(firstInput);
        }

        private static void FindAllSubstring(string inputStr)
        {
            for (int i = 0; i < inputStr.Length; i++)
            {
                StringBuilder subString = new StringBuilder();

                for (int j = i; j < inputStr.Length; j++)
                {
                    subString.Append(inputStr[j]);
                    Console.Write(subString + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
