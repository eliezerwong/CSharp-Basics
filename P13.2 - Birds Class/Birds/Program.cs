//Eliezer Emmanuel Wong
//MIS 3013-995
using System;

namespace Birds
{
    /*
    1. Create three new classes, a base class, and 2 derived classes.Make sure you spell things correctly (case matters!)
    2. Hard code 2 of each type of bird(the user will be entering one male and one female) in your Program.cs Main method, then ask the information needed to give value for the base class fields and for the derived class fields
    3. If the bird is female(T or F of the boolean is your choice, but should be in a console output so the user knows), when you call create a random number between 0 and 5 if a Robin and 0 and 3 if a penguin to put a value in the EggCount field
    4. Then output the results of each method and the number of eggs for each object (if female) to the console(number of outputs depends on the number of objects created, 1 output per object)
        */
    class Program
    {
        static void Main(string[] args)
        {
            //Random random = new Random();
            //int robinRan = random.Next(0, 5);
            //int pengRan = random.Next(0, 3);
            int penguinType = 2;
            int robinType = 1;

            Penguin penguinM = new Penguin();
            Console.WriteLine("Enter male penguin height:");
            penguinM.height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter male penguin weight:");
            penguinM.weight = Convert.ToDouble(Console.ReadLine());
            penguinM.gender = true;
            Console.WriteLine("Enter male penguin max swim depth:");
            penguinM.swimDepthMax = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Male penguin underwater minutes: {penguinM.CalculateUnderwater()}");

            Penguin penguinF = new Penguin();
            Console.WriteLine("Enter female penguin height:");
            penguinF.height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter female penguin weight:");
            penguinF.weight = Convert.ToDouble(Console.ReadLine());
            penguinF.gender = false;
            penguinF.eggCount = penguinF.LayEggs(penguinType);
            //penguinF.eggCount = pengRan;
            Console.WriteLine("Enter female penguin max swim depth:");
            penguinF.swimDepthMax = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Female penguin underwater minutes: {penguinF.CalculateUnderwater()}");
            Console.WriteLine($"Female penguin eggs: {penguinF.eggCount}");

            Robin robinM = new Robin();
            Console.WriteLine("Enter male robin height:");
            robinM.height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Emter male robin weight:");
            robinM.weight = Convert.ToDouble(Console.ReadLine());
            robinM.gender = true;
            Console.WriteLine("Enter male robin flight speed:");
            robinM.flightSpeed = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Male robin wing span: {robinM.CalculateWingspan()}");

            Robin robinF = new Robin();
            Console.WriteLine("Enter female robin height:");
            robinF.height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Emter female robin weight:");
            robinF.weight = Convert.ToDouble(Console.ReadLine());
            robinF.gender = false;
            robinF.eggCount = robinF.LayEggs(robinType);
            //robinF.eggCount = robinRan;
            Console.WriteLine("Enter female robin flight speed:");
            robinF.flightSpeed = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Female robin wing span: {robinF.CalculateWingspan()}");
            Console.WriteLine($"Female robin eggs: {robinF.eggCount}");

            Console.ReadLine();



        }
    }
}
