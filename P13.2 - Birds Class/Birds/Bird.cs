using System;
using System.Collections.Generic;
using System.Text;

namespace Birds
{
    class Bird
    {
        public double height;
        public double weight;
        public bool gender;
        public int eggCount;

        public int LayEggs(int BirdType)
        {
            Random random = new Random();
            int eggRan = 0;
            //1 = robin, 2 = penguin

            if (BirdType == 1)
            {
                eggRan = random.Next(0, 5);
            }
            else if (BirdType == 2)
            {
                eggRan = random.Next(0, 3);
            }

            return eggRan;
        }
    }
}
