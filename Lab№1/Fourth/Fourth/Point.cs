using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Fourth
{
    class Point
    {

        public string name { get; }
        public int X { get; }
        public int Y { get; }


        public void GetName()
        {
            Console.WriteLine("Enter name of point");
            string str = Console.ReadLine();
        }
        public double GetX(double x1, double x2, double x)
        {
            x = x2 - x1;
            return x;
        }
        public double GetY(double y1, double y2, double y)
        {
            y = y2 - y1;
            return y;
        }
    }
}
