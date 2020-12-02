using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Workers worker = new Workers("Василь", 37, "мужской", "фотограф");
            worker.Information();

            Mans man = new Mans("Володимир", 45, "мужской", "фотограф", "стажор");
            man.Information();

            Workers worker1 = (Workers)man;
            worker1.Information();

            Mans man1 = (Mans)worker1;
            man1.Information();

            Console.ReadLine();
        }
    }
}
