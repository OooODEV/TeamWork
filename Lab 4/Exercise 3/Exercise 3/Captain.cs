using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_3
{
    class Captain : DCaptain
    {
        public int Experience { get; set; }
        public Captain() { }
        public Captain(string Name, string FirmName, string Rank, int Experience) : base(Name, FirmName, Rank)
        {
            this.Experience = Experience;
        }
        public override void Information()
        {
            Console.WriteLine($"\n{this.Rank} компания '{this.FirmName}' {this.Name}");
            Console.WriteLine($"Стаж: {this.Experience}");
            Console.WriteLine($"Класс Captain: имя {this.Name}\nКомпания '{this.FirmName}'\nДолжность '{this.Rank}'\n" + $"Стаж: {this.Experience}");

        }
    }
}
