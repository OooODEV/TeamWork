using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_2
{
    class A
    {
        B b1;
        B b2;
        B b3;
        public A() { }
        public A(B b1, B b2, B b3)
        {
            this.b1 = b1;
            this.b2 = b2;
            this.b3 = b3;
        }
        public A(B b1, B b2) : this(b1, b2, null) { }
        public void Time()
        {
            if (b3 == null)
            {
                Console.WriteLine($"{b1.stuffing}, {b1.region}: {b1.regionTime}");
                Console.WriteLine($"{b2.stuffing}, {b2.region}: {b2.regionTime}\n");
            }
            else
            {
                Console.WriteLine($"{b1.stuffing}, {b1.region}: {b1.regionTime}");
                Console.WriteLine($"{b2.stuffing}, {b2.region}: {b2.regionTime}");
                Console.WriteLine($"{b3.stuffing}, {b3.region}: {b3.regionTime}\n");

            }
        }
    }
}
