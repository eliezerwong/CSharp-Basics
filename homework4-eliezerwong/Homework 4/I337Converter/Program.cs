//Eliezer Emmanuel Wong
//MIS 3103-995
using System;

namespace I337Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "--- I337Converter ---";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            Console.WriteLine("Input a sentence");
            string userSentence = Console.ReadLine();
            
            //string manipulation to replace characters, *is it possible to Replace(array1, array2)? how to optimize?
            userSentence = userSentence.ToUpper().Replace("A","@").Replace("E","3").Replace("H", "|-|").Replace("S", "$").Replace("T", "7").Replace("U", "|_|");

            //make sure each sentence ends with !
            userSentence = userSentence.Replace("?", "!").Replace(".", "!");
            Console.WriteLine(userSentence);

            /* or,
            string[] sentence = userSentence.Split(new char[] {'.', '?' });
            int sentenceCount = sentence.Length;

            int i = 0;
            bool hasChar = sentence[i].Contains("!");

            for (i = 0; i < sentenceCount; i++)
            {
                if(hasChar)
                {
                    Console.Write(sentence[i] + " ");
                }
                else
                {
                    Console.Write(sentence[i] + "!");
                }
            }
            */

            Console.ReadKey();
        }
    }
}
