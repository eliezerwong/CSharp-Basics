using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Rectangle
    {
        //field
        public double length;
        public double width;

        public double CalculateArea()
        {
            return length * width;
        }

        public double CalculatePerimeter()
        {
            return 2 * (length + width);
        }
    }
}
