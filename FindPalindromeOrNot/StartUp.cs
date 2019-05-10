using System;

namespace FindPalindromeOrNot
{
    public class StartUp
    {
        public static void Main()
        {
            var firstInput = "madam";
            var secondInput = "step on no pets";
            var thirdInput = "book";

            CheckPalindrome(firstInput);
            CheckPalindrome(secondInput);
            CheckPalindrome(thirdInput);
        }

        private static void CheckPalindrome(string inputStr)
        {
            bool flag = false;

            for (int i = 0, j = inputStr.Length - 1; i < inputStr.Length / 2; i++, j--)
            {
                if (inputStr[i] != inputStr[j])
                {
                    flag = false;
                    break;
                }
                else
                {
                    flag = true;
                }
            }

            if (flag)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
    }
}
