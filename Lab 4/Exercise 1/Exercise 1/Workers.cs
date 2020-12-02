using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1
{
    class Workers
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Type { get; set; }

        public Workers() { }
        public Workers(string name, int age, string sex, string type)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
            this.Type = type;
        }

        public void Information()
        {
            Console.WriteLine($"Имя ({this.Name.GetType()}): {this.Name}");
            Console.WriteLine($"Возраст ({this.Age.GetType()}): {this.Age}");
            Console.WriteLine($"Пол ({this.Sex.GetType()}): {this.Sex}");
            Console.WriteLine($"Вид работы ({this.Type.GetType()}): {this.Type}");
            Console.WriteLine($"Класс: {GetType()}\n");
        }
    }
}
