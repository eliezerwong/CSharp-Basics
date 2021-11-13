using System;
using System.Collections.Generic;
using System.Text;

namespace Birds
{
    class Robin : Bird
    {
        public double flightSpeed;

        public double CalculateWingspan()
        {
            return height * 1.67;
        }
    }
}
