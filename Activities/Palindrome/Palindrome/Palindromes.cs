using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class Palindromes
    {
        public static string Palindome(string word)
        {
            int min = 0;
            int wordLength = word.Length - 1;
            //bool isPalindrome = true;

            while(wordLength >= 0)
            {
                if(min > wordLength)
                {
                    return "Yes";
                }

                char c = word[min];
                char d = word[wordLength];

                if(char.ToLower(c) != char.ToLower(d))
                {
                    return "No";

                }
                min++;
                wordLength--;

            }
            
            return Palindome(word);
        }

    }
}
