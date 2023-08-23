using System;
using System.Collections.Generic;

class Program_3
{
    static void Main(string[] args)
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
        List<char> foundVowels = new List<char>();

        foreach (char letter in sentence.ToLower())
        {
            if (vowels.Contains(letter) && !foundVowels.Contains(letter))
            {
                foundVowels.Add(letter);
            }
        }

        foundVowels.Sort();

        Console.WriteLine("Found Vowels:");
        foreach (char vowel in foundVowels)
        {
            Console.WriteLine(vowel);
        }
    }
}