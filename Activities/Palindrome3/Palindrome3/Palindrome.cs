using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome3
{
    public class Palindrome
    {
        public void Palindromes()
        {
            var path = @"C:\Users\m.moletsane\Desktop\palindrome.txt";
            var words = File.ReadAllLines(path);
            var wordList = words.ToList().ConvertAll(i => i.ToLower());
            var output = new List<string>();

            foreach (var word in wordList)
            {
                var wordReversed = "";

                wordReversed = ReverseString(word);
                var results = CompareWords(word, wordReversed);
                output.Add(results);

                Console.WriteLine(results);
            }
            
            File.WriteAllLinesAsync(@"C:\Users\m.moletsane\Desktop\Palindrome3.txt", output.ToArray());
        }

        private string ReverseString(string word)
        {
            var wordReversed = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                    wordReversed += word[i];
            }

            return wordReversed;
        }

        private string CompareWords(string word, string wordReversed)
        {
            string result;

            if (word == wordReversed)
            {
                result = "Yes";
            }
            else
            {
                result = "No";
            }
            return result;
        }

    }
}
