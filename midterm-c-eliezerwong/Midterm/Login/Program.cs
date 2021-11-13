//Eliezer Emmanuel Wong
//MIS 3013-995
using System;

namespace Login
{
    class Program
    {
        //stored id & pass
        const string OUID = "wong0014";
        const string password = "ABC123";
        static void Main(string[] args)
        {
            string title = "--- Login ---";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            //input id & pass

            int counter = 1;

            
                Console.WriteLine("Please Enter Your OUNetID");
                string inputID = Console.ReadLine();
                inputID = inputID.Trim().ToLower();

                Console.WriteLine("Please Enter Your Password");
                string inputPass = Console.ReadLine();

            //3 tries to get right, else try again
                while (inputID != OUID || inputPass != password)
                {
                    Console.WriteLine($"Incorrect ID or Password, Attempt {counter}");
                    Console.WriteLine("Please Enter Your OUNetID");
                    inputID = Console.ReadLine();
                    inputID = inputID.Trim().ToLower();

                    Console.WriteLine("Please Enter Your Password");
                    inputPass = Console.ReadLine();
                    counter++;

                    if(counter == 3)
                    {
                        return;
                    }
                }
            
            

            Console.WriteLine($"Welcome Eliezer, {OUID}");

            Console.ReadKey();
        }
    }
}
