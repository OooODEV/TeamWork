using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Fourth
{
    class Figure
    {
        Point garage = new Point();

        public double GetLenght(double x1, double x2, double y1, double y2, double x, double y)
        {
            double gt = Math.Sqrt(Math.Pow((garage.GetX(x1, x2, x)), 2) + Math.Pow((garage.GetY(y1, y2, y)), 2));
            return gt;
        }

        public double GetPerimeter(double side, double numofsides)
        {
            return side * numofsides;
        }
    }
}
