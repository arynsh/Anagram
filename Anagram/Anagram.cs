using System;
using System.Collections.Generic;
using Anagram.Models;

namespace Anagram 
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a word:");
            string userInput = Console.ReadLine();
            Word anagramWord = new Word(userInput);
            Console.WriteLine("Please enter a list of words that you think will be anagrams of that word:");
            string strPossibleAnagrams = Console.ReadLine();
            string[] words = strPossibleAnagrams.Split(", ");
            List<string> result = new List<string> {};
            foreach (string word in words)
            {
                if (anagramWord.Compare(word)) {
                    result.Add(word);
                }
            }
            Console.WriteLine($"Anagrams: {string.Join(", ", result)}");

        }
    }
}