//Eliezer Emmanuel Wong
//MIS 3013-995
using System;

namespace StringManipulation
{
    /*
    1. Use this variable: 
    
    string baconIpsum = "Bacon ipsum dolor amet picanha tri-tip pig pork bacon turducken. Leberkas short ribs prosciutto pork belly ribeye capicola alcatra short loin ham hock rump jowl pig flank beef. Venison tenderloin tail, cupim salami pastrami meatball jerky filet mignon. Salami jerky short loin, chicken pig pork tenderloin rump meatball sausage pancetta sirloin. Drumstick tenderloin ham pork belly cupim, ground round prosciutto jerky ball tip kielbasa tongue andouille picanha alcatra. Ham ribeye t-bone, boudin buffalo pork chop beef tri-tip. Bacon filet mignon frankfurter kevin, pork chop burgdoggen bacon bacon ham hock beef ribs bresaola turkey meatball corned beef.";
    
    2. Use string manipulation, output of a count of how many sentences are in your string variable
    3. Use a loop to iterate through each sentence
    4. If the string "bacon" is found in the sentence, output a happy sentence, otherwise, output  a sad sentence to the console
    5. Output how many times bacon is in baconIpsum and tell if that is enough bacon for you
    */
    class Program
    {
        static void Main(string[] args)
        {
            string title = "--- String Manipulation ---";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            string baconIpsum = "Bacon ipsum dolor amet picanha tri-tip pig pork bacon turducken. Leberkas short ribs prosciutto pork belly ribeye capicola alcatra short loin ham hock rump jowl pig flank beef. Venison tenderloin tail, cupim salami pastrami meatball jerky filet mignon. Salami jerky short loin, chicken pig pork tenderloin rump meatball sausage pancetta sirloin. Drumstick tenderloin ham pork belly cupim, ground round prosciutto jerky ball tip kielbasa tongue andouille picanha alcatra. Ham ribeye t-bone, boudin buffalo pork chop beef tri-tip. Bacon filet mignon frankfurter kevin, pork chop burgdoggen bacon bacon ham hock beef ribs bresaola turkey meatball corned beef.";

            int countSentence = baconIpsum.Split(".").Length - 1;
            Console.WriteLine($"baconIpsum consists of {countSentence} sentences.\n");

            string[] sentences = baconIpsum.Split(". ");
            int sentenceCount = sentences.Length;

            int baconCount = baconIpsum.ToLower().Split("bacon").Length - 1;
            

            for (int i = 0; i < sentenceCount; i++)
            {

                if (sentences[i].ToLower().Contains("bacon"))
                {
                    Console.Write($"{i}) Yay Bacon. ");
                }
                else
                {
                    Console.Write($"{i}) No Bacon. ");
                }
                Console.WriteLine(sentences[i] + ".");
                
            }

            Console.WriteLine($"\nThe word bacon appears {baconCount} times.");

            Console.ReadKey();
        }
    }
}
