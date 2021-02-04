using System;

namespace Eighth
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice();

            int tv = 10000;
            int gre4ka = 20;
            int knife = 70;

            invoice.GetInfo();
            Console.WriteLine("Write a quantity");
            int quantity = Convert.ToInt32(Console.ReadLine());
            invoice.GetArticle();
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Console.WriteLine("Without NDS = " + tv * quantity);
                    Console.WriteLine("With NDS = " + invoice.GetNDS(tv,quantity));
                    break;
                case 2:
                    Console.WriteLine("Without NDS = " + gre4ka * quantity);
                    Console.WriteLine("With NDS = " + invoice.GetNDS(gre4ka,quantity));
                    break;
                case 3:
                    Console.WriteLine("Without NDS =" + knife * quantity);
                    Console.WriteLine("With NDS = " + invoice.GetNDS(knife,quantity));
                    break;
            }
        }
    }
}
