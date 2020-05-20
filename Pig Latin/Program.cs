using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pig_Latin
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramIntroduction();

            bool translatingPigLatin = true;
            while (translatingPigLatin)
            {
                string[] words = UserPhraseString().Split();
                foreach (string word in words)
                {
                    TranslateToPigLatin(word);
                }
                translatingPigLatin = false;
            }
            ProgramClosingStatement();
            Environment.Exit(0);
        }
        static void TranslateToPigLatin(string input)
        {
            char[] word = input.ToCharArray();
            string output = "";
            int firstVowelIndex = LocateFirstVowelIndex(word);
            if (firstVowelIndex == 0)
            {
                output = input + "way";
            }
            else if (firstVowelIndex == -1)
            {
                output = input;
            }
            else
            {
                string prefix = input.Substring(firstVowelIndex);
                string postfix = input.Substring(0, firstVowelIndex) + "ay";
                output = prefix + postfix;
            }
            Console.WriteLine(output);

        }
        static int LocateFirstVowelIndex(char[] word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                char wordLetter = word[i];
                if (IsAVowel(wordLetter))
                {
                    return i;
                }
            }
            return -1;
        }
        static bool IsAVowel(char c)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            foreach (char vowel in vowels)
            {
                if (vowel == c)
                {
                    return true;
                }
            }
            return false;
        }
        static string UserPhraseString()
        {
            Console.WriteLine("");
            Console.WriteLine("Enter a phrase to translate:");
            Console.WriteLine("");
            Console.Write("Your phrase: ");
            return Console.ReadLine().Trim();
        }
        static void ProgramClosingStatement()
        {
            Console.WriteLine("");
            Console.WriteLine("Thank you for using our Pig Latin Translator Application!");
            Console.WriteLine("Have a great day!");
            Console.WriteLine("");
        }
        static void ProgramIntroduction()
        {
            Console.WriteLine("Welcome to the Pig Latin Translator Application!");
            Console.WriteLine("");
            Console.WriteLine("This application will allow you translate any phrase into a phrase written in Pig Latin.");
            Console.WriteLine("Let's Get Started!");
        }
    }
}
