using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1
{
    class Mans : Workers
    {
        public string xp { get; set; }
        public Mans() : base() { }
        public Mans(string name, int age, string gender, string type, string xp) : base(name, age, sex, type)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = gender;
            this.Type = type;
            this.xp = xp;

        }
        public void Information()
        {
            Console.WriteLine($"Имя ({this.Name.GetType()}): {this.Name}");
            Console.WriteLine($"Возраст ({this.Age.GetType()}): {this.Age}");
            Console.WriteLine($"Пол ({this.Sex.GetType()}): {this.Sex}");
            Console.WriteLine($"Вид роботы ({this.Type.GetType()}): {this.Type}");
            Console.WriteLine($"Опыт работы ({this.xp.GetType()}): {this.xp}");
            Console.WriteLine($"Класс: {GetType()}\n");
        }
    }
}
