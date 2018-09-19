using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromeian

{
    class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to see if it is a palindrome: ");
            String TestPalindrome = Console.ReadLine();
            Boolean pt = false;
            pt = IsPalindrome(TestPalindrome);
            if (pt)
                Console.WriteLine("{0} is a palindrome.", TestPalindrome);
            else
                Console.WriteLine("{0} is NOT a palindrome.", TestPalindrome);
            Console.WriteLine("Press Enter/Return to continue");
            Console.ReadLine();
        }
        public static Boolean IsPalindrome(string palindromeCandidate)
        {
            //first clear spaces and set case
            string sPalindrome = palindromeCandidate.ToLower().Replace(" ","");
            int HaltIndex = sPalindrome.Length % 2 == 0 ? sPalindrome.Length / 2 : sPalindrome.Length / 2 + 1;
            for (int i = 0; i < HaltIndex - 1; i++)
            {
                char Front = sPalindrome[i];
                char Back = sPalindrome[sPalindrome.Length - i - 1];
                if (Front != Back) return false;
            }

            return true;
        }
    }
}
