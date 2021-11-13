using System;
using System.Collections.Generic;
using System.Text;

namespace Birds
{
    class Penguin : Bird
    {
        public double swimDepthMax;
        public double underwaterMinutes;

        public double CalculateUnderwater()
        {
            underwaterMinutes = (height * weight) / 1860;
            return underwaterMinutes;
        }
    }
}
