using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataSentenceSmash
{
    public class SentenceSmash
    {
        public static string Smash(string[] words)
        {
            return String.Join(" ", words);

            //string result = words[0];
            //for (int i = 1; i < words.Length; ++i)
            //{
            //    result += " " + words[i];
            //}
            //return result;
        }
    }
}
