using System;
using System.Collections.Generic;
using System.Collections;

namespace Anagram.Models 
{
    public class Word 
    {
        public string  AnagramWord { get; set;}
        private string  SortedAnagramWord;

        private Dictionary <char,int> CharDictionary ;

        public Word(string anagramWord) {
            AnagramWord = anagramWord;
            char[] anagramCharArray = AnagramWord.ToCharArray();
            Array.Sort(anagramCharArray);
            SortedAnagramWord = string.Join("",anagramCharArray);
            CharDictionary = new Dictionary<char, int>();
           for (int i = 0; i < anagramCharArray.Length; i++)
            {
                char letter = anagramCharArray[i];
                if (CharDictionary.ContainsKey(letter))
                {
                    CharDictionary[letter] += 1;
                }
                else
                {
                    CharDictionary.Add(letter, 1);
                }
            }
        }

    public bool Compare(string anagramComparison)
    {
        char[] anagramCompasionCharArray = anagramComparison.ToCharArray();
        Array.Sort(anagramCompasionCharArray);

        if (AnagramWord.Length == anagramComparison.Length)
        {
            string SortedAnagramComparison = string.Join("",anagramCompasionCharArray);
            if (SortedAnagramWord == SortedAnagramComparison) {
                return true;
            }
        }
        else
        {
            Dictionary<char, int> CharDictClone = new Dictionary<char,int>(CharDictionary);
            foreach (char letter in anagramCompasionCharArray) 
            {
                if (CharDictClone.ContainsKey(letter)) 
                {
                    CharDictClone[letter] --;
                    if (CharDictClone[letter] < 0) 
                    {
                        return false;
                    }
                } 
                else 
                {
                    return false;
                }
            }
            return true;
        }

        return false;

    }

    }
}