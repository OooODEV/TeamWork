using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_3
{
    class DCaptain
    {
        public string Name { get; set; }
        public string FirmName { get; set; }
        public string Rank { get; set; }
        public DCaptain() { }
        public DCaptain(string name, string FirmName, string Rank)
        {
            this.Name = name;
            this.FirmName = FirmName;
            this.Rank = Rank;
        }

        public virtual void Information()
        {
            Console.WriteLine($"Имя: {this.Name}");
            Console.WriteLine($"Название компании: {this.FirmName}");
            Console.WriteLine($"Должность: {this.Rank}");
            Console.WriteLine($"Класс DeputyCaptain: имя {this.Name}, компания '{this.FirmName}', должность '{this.Rank}'\n");
        }
    }
}
