//Eliezer Emmanuel Wong
//MIS 3013-995
using System;

namespace Person_and_Role
{
    enum Role : byte
    {
        Instructor = 1,
        Staff = 2,
        Student = 3,
        Visitor = 4,
    }
    //create enum (new types)

    struct Person
    {
        public Role personRole;
        public string personName;
        public string person4x4;
    }
    //create struct, personRole as Role type as created in enum

    class Program
    {
        static void Main(string[] args)
        {
            string title = "--- Person and Role ---";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            ///save struct as var
            Person person;
            //to step into 1st loop
            int userRole = 0;
            //declare to use in loop or conditional code block
            string user4x4 = "0";
            //to step into nested loop
            bool isNumber = false;

            Console.WriteLine("1) Instructor\n2) Staff\n3) Student\n4) Visitor");

            //makes sure user enters within enum values
            do
            {
                //ensures isNumber
                do
                {
                    Console.WriteLine("Enter your role:");
                    isNumber = Int32.TryParse(Console.ReadLine(), out int roleNum);
                    userRole = roleNum;
                } while (!isNumber);
            } while ((userRole < 1) || (userRole > 4));
            


            if (userRole != 4)
            {
                Console.WriteLine("Enter your 4x4");
                user4x4 = Console.ReadLine();

            }

            Console.WriteLine("Enter your Name");
            string userName = Console.ReadLine();

            //cast int userRole as Role type created in enum and declared in struct
            person.personRole = (Role)userRole;
            person.person4x4 = user4x4;
            person.personName = userName;

            if ((userRole == 1) || (userRole == 2) || (userRole == 3))
            {
                Console.WriteLine($"Welcome back {person.personRole} {person.personName}, \n4x4: {person.person4x4}");
            }
            else
            {
                Console.WriteLine($"Welcome {person.personRole} {person.personName}");
            }


            Console.ReadKey();
        }
    }
}
