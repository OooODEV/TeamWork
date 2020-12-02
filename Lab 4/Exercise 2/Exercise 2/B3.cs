using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_2
{
    class B3 : B
    {
        public B3(string stuffing, string region, DateTime regionTime) : base(stuffing, region, regionTime) { }
        public override void OnlyTime()
        {
            Console.WriteLine($"{region}: {regionTime.ToLongTimeString()}");
            Console.WriteLine($"{stuffing}, {region}, {regionTime}\n");
        }
    }
}
