using System;
using System.Dynamic;
using System.Threading.Channels;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle newRectangle = new Rectangle();

            Console.WriteLine("Enter length");
            double len = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter width");
            double wid = Convert.ToDouble(Console.ReadLine());

            newRectangle.side1 = len;
            newRectangle.side2 = wid;

            double resultPer = newRectangle.CalculatePerimeter(len, wid, newRectangle.Perimeter);
            double resultArea = newRectangle.CalculateArea(len, wid, newRectangle.Area);

            Console.WriteLine($"Perimeter: {resultPer} \nArea: {resultArea}");
        }
    }
}
