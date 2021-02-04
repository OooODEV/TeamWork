using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DCaptain Terminator = new DCaptain("Терминатор", "Даймонд", "№4");
            Terminator.Information();

            Captain JohnSnow = new Captain("Джон Сноу", "Даймонд", "Начальник", 25);
            JohnSnow.Information();

            IT Voldemort = new IT("Волан де морт", "Даймонд", "Айтишник");
            Voldemort.Information();

            Console.ReadLine();
        }
    }
}
