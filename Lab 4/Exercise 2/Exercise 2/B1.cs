using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_2
{
    class B1 : B
    {
        public B1(string stuffing, string region, DateTime regionTime) : base(stuffing, region, regionTime) { }
        public override void LongDate()
        {
            Console.WriteLine($"{region}: {regionTime.ToUniversalTime()}");
            Console.WriteLine($"{stuffing}, {region}, {regionTime}\n");
        }
    }
}
