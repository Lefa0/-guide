using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeA
{
    public class Palindrome
    {
        public void Palindromes()
        {
            var path = @"C:\Users\m.moletsane\Desktop\palindrome.txt";
            var words = File.ReadAllLines(path);
            List<string> wordsList = words.ToList().ConvertAll(i => i.ToLower());
            List<string> reversedWordsList = new List<string>();
            var reversedWord = "";
            List<string> output = new List<string>();

            foreach (var word in wordsList)
            {
                //Console.WriteLine(word);
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reversedWord += word[i];
                }

                reversedWordsList.Add(reversedWord);
                reversedWord = "";
            }

            string result;

            for (int i = 0; i < reversedWordsList.Count; i++)
            {
                if (wordsList[i].Equals(reversedWordsList[i]))
                {
                    result = "Yes";
                }
                else
                {
                    result = "No";
                }

                output.Add(result);
                Console.WriteLine(result);
            }
            File.WriteAllLinesAsync(@"C:\Users\m.moletsane\Desktop\PalindromeOutput.txt", output);

        }
    }
}
