//Eliezer Emmanuel Wong
//MIS 3013-995
using System;

namespace Orientation
{
    enum Orientation : byte
    {
        North = 1,
        South = 2,
        East = 3,
        West = 4
    }

    struct Route
    {
        public Orientation Direction;
        public double Distance;
    }

    class Program
    {
        static void Main(string[] args)
        {
            string title = "--- Orientation ---";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            Route myRoute;
            int myDirection = 0;
            double myDistance = 0;
            bool isNumber = false;

            Console.WriteLine("1) North\n2) South\n3) East\n4) West");

            do
            {
                do
                {
                    Console.WriteLine("Select a direction");
                    isNumber = Int32.TryParse(Console.ReadLine(), out int directionNum);
                    myDirection = directionNum;
                } while (!isNumber);
            } while ((myDirection < 1) || (myDirection > 4));

            isNumber = false;

            while (!isNumber)
            {
                Console.WriteLine("Enter a distance");
                isNumber = double.TryParse(Console.ReadLine(), out double distanceNum);
                myDistance = distanceNum;
            }

            myRoute.Direction = (Orientation)myDirection;
            myRoute.Distance = myDistance;

            Console.WriteLine($"myRoute specifies a direction of {myRoute.Direction} and a distance of {myRoute.Distance}");

            Console.ReadKey();
        }
    }
}
