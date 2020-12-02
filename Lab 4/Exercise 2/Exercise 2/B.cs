using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_2
{
    class B
    {
        public B() { }
        public B(string stuffing, string region, DateTime regionTime)
        {
            this.region = region;

            this.stuffing = stuffing;

            this.regionTime = regionTime;

        }
        public string region { get; set; }
        public DateTime regionTime { get; set; }
        public string stuffing { get; set; }


        public virtual void OnlyTime()
        {
            Console.WriteLine($"{region}: {regionTime.ToShortTimeString()}");
        }
        public virtual void ShortDate()
        {
            Console.WriteLine($"{region}: {regionTime.ToShortDateString()}");
        }
        public virtual void LongDate()
        {
            Console.WriteLine($"{region}: {regionTime.ToLongDateString()}");
        }
    }
}
