using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Circle
    {
        //property
        public double radius { get; set; }

        public double CalculateArea()
        {
            //Math.Pow(X, power) returns X to the power 
            return Math.PI * Math.Pow(radius, 2); 
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
