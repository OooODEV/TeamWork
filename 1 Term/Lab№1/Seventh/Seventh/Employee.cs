using System;
using System.Collections.Generic;
using System.Text;

namespace Seventh
{
    class Employee
    {
        private string name { get; }
        private string surname { get; }

        public void GetName()
        {
            Console.WriteLine("Enter your name");
        }
        public void GetSurname()
        {
            Console.WriteLine("Enter your surname");
        }

        public double Salary(double money)
        {
            return money + (money * 0.08);
        }

        public double Tax(double money)
        {
            return money - (money * 0.18);
        }
    }
}
