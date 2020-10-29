using System;

namespace Fourth
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure get = new Figure();
            Point point = new Point();

            point.GetName();
            Console.WriteLine("Enter x1");
            double x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1");
            double y1 = Convert.ToInt32(Console.ReadLine());
            point.GetName();
            Console.WriteLine("Enter x2");           
            double x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2");
            double y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number of sides");
            double numm = Convert.ToDouble(Console.ReadLine());

            double SIDE = get.GetLenght(x1, x2, y1, y2, point.X, point.Y);

            double perimeter = get.GetPerimeter(SIDE,numm);

            switch (numm)
            {
                case 3:
                    Console.WriteLine("Triangle");
                    break;
                case 4:
                    Console.WriteLine("Square");
                    break;
                default:
                    Console.WriteLine("{0} - agon",numm);
                    break;
            }

            Console.WriteLine("Lenght of side: {0},Perimeter: {1}",SIDE,perimeter);
            Console.ReadKey();
        }
    }
}
