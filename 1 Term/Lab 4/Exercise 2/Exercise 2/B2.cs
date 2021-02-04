using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_2
{
    class B2 : B
    {
        public B2(string stuffing, string region, DateTime regionTime) : base(stuffing, region, regionTime) { }
        public override void ShortDate()
        {
            Console.WriteLine($"{region}: {regionTime.ToLongDateString()}");
            Console.WriteLine($"{stuffing}, {region}, {regionTime}\n");
        }
    }
}
