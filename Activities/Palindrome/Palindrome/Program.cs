using Palindrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        string words = @"C:\Users\m.moletsane\Desktop\palindrome.txt";

        //List<string> words = new List<string>();
        var word = File.ReadAllLines(words);

        using (StreamReader sr = File.OpenText(words))
        {
            string text;
            while ((text = sr.ReadLine()) != null)
            {
                Console.WriteLine(text);
            }
        }

        //foreach (string word in words)
        //{
        //    Console.WriteLine(Palindromes.Palindome(word));
        //}
        
     
    }
}