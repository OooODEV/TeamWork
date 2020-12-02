using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_3
{
    class IT : DCaptain
    {
        public IT() { }
        public IT(string Name, string FirmName, string Rank) : base(Name, FirmName, Rank)
        {
        }
        public override void Information()
        {
            Console.WriteLine($"\nИмя {this.Name}\nКомпания '{this.FirmName}'\nДолжность '{this.Rank}'\n");
            Console.WriteLine($"Класс Carpenter: имя {this.Name}\nКомпания '{this.FirmName}'\nдолжность '{this.Rank}'\n");
        }
    }
}
