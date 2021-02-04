using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            B cake1 = new B("С маком", "Киевская", DateTime.Now);
            B cake2 = new B("С повидлом", "Хмельницкая", DateTime.UtcNow);
            B cake3 = new B("С черникой", "ДНР", DateTime.UtcNow.AddHours(-3));
            B cake4 = new B("С клубникой", "Львовская", DateTime.UtcNow.AddHours(1));
            B cake5 = new B("С м'ясом", "Одеская", DateTime.UtcNow.AddHours(2));
            A a1 = new A(cake1, cake2, cake3);
            a1.Time();
            A a2 = new A(cake4, cake5);
            a2.Time();

            Console.WriteLine("Переопределение метода LongDate:");
            cake1.LongDate();
            B1 c1 = new B1(cake1.stuffing, cake1.region, cake1.regionTime);
            c1.LongDate();

            Console.WriteLine("\nПереопределение метода ShortDate:");
            cake2.ShortDate();
            B2 c2 = new B2(cake2.stuffing, cake2.region, cake2.regionTime);
            c2.ShortDate();

            Console.WriteLine("\nПереопределение метода OnlyTime:");
            cake3.OnlyTime();
            B3 c3 = new B3(cake3.stuffing, cake3.region, cake3.regionTime);
            c3.OnlyTime();
            Console.ReadLine();
        }
    }
}
