using System;

namespace Sixth
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter();

            Console.WriteLine("Введите сумму, которую хотите конвертировать: ");
            double sum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Что вы хотитие конвертировать: \n1.UAH \n2.USD \n3.EUR \n4.RUB \n");
            int choose = Convert.ToInt32(Console.ReadLine());

            double USD = 28.3310;
            double EUR = 33.1130;
            double RUB = 0.3263;

            switch (choose)
            {
                case 1:
                    Console.WriteLine(converter.ConvertUSD(sum, USD) + " $");
                    Console.WriteLine(converter.ConvertUSD(sum, EUR) + " евро");
                    Console.WriteLine(converter.ConvertUSD(sum, RUB) + " р.");
                    break;
                case 2:
                    Console.WriteLine(converter.UAHtoUSD(sum) + " грн.");
                    break;
                case 3:
                    Console.WriteLine(converter.UAHtoEUR(sum) + " грн.");
                    break;
                case 4:
                    Console.WriteLine(converter.UAHtoRUB(sum) + " грн.");
                    break;
                default:
                    Console.WriteLine("Выбрана не корpектная валюта!");
                    return;
            }
            Console.ReadLine();
        }
    }
}
