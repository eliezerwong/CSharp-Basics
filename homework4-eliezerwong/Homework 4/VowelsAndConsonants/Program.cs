//Eliezer Emmanuel Wong
//MIS 3013-995
using System;

namespace VowelsAndConsonants
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "--- Vowels and Consonants ---";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            //user input
            Console.WriteLine("Input a sentence");
            string userSentence = Console.ReadLine();
            
            //string manipulation to more readable
            userSentence = userSentence.Trim().ToLower().Replace(" ","").Replace(".","");
            int characterCount = userSentence.Length;

            //when using array without specifying, eg. cw(vowels);, all values output
            char[] vowel = { 'a', 'e', 'i', 'o', 'u' };
            
            //does it before or after vowel?
            string[] splitVowel = userSentence.Split(vowel);
            int vowelCount = splitVowel.Length - 1;
            int consonantCount = characterCount - vowelCount;

            Console.WriteLine($"There were {vowelCount} vowels in the sentence.");
            Console.WriteLine($"There were {consonantCount} consonants in the sentence.");

            Console.ReadKey();
        }
    }
}
