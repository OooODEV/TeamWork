using System;
using System.Collections.Generic;
using System.Text;

namespace Second
{
    class Rectangle
    {
        public double side1 { get; set; }
        public double side2 { get; set; }

        public double Perimeter { get; }
        public double Area { get; }


        public void rectangle(double length, double widht)
        {
            side1 = length;
            side2 = widht;
        }

        public double CalculatePerimeter(double length, double width, double perimeter)
        {
            perimeter = (length + width) * 2;
            return perimeter;
        }

        public double CalculateArea(double length, double width, double area)
        {
            area = length * width;
            return area;
        }
    }
}
