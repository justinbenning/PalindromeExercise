using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool UsePalindrome(string palindrome)
        {
            if (palindrome.Contains(" "))
            {
                palindrome = palindrome.Replace(" ", "");
            }
            string reversePalindrome = new string(palindrome.ToLower().ToCharArray().Reverse().ToArray());
            return reversePalindrome == palindrome.ToLower();
        }
    }
}
