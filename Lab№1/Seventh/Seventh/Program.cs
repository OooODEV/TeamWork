using System;

namespace Seventh
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.GetName();
            string name = Console.ReadLine();
            employee.GetSurname();
            string surname = Console.ReadLine();

            int salary = 10000;
            int salary1 = 20000;
            int salary2 = 15000;

            Console.WriteLine("Choose your degree of disability: \n1.Normal \n2.Disable");
            int degree = Convert.ToInt32(Console.ReadLine());

            switch (degree)
            {
                case 1:
                    Console.WriteLine("Choose your position: \n1.Engineer \n2.Lawyer \n3.Accountant");
                    int choose = Convert.ToInt32(Console.ReadLine());                   

                    switch (choose)
                    {
                        case 1:
                            Console.WriteLine("Your salary: " + employee.Tax(salary));
                            break;
                        case 2:
                            Console.WriteLine("Your salary: " + employee.Tax(salary1));
                            break;
                        case 3:
                            Console.WriteLine("Your salary: " + employee.Tax(salary2));
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Choose your position: \n1.Engineer \n2.Lawyer \n3.Accountant");
                    int choose1 = Convert.ToInt32(Console.ReadLine());

                    switch (choose1) 
                    {
                        case 1:
                            Console.WriteLine("Your salary: " + employee.Tax(employee.Salary(salary)));
                            break;
                        case 2:
                            Console.WriteLine("Your salary: " + employee.Tax(employee.Salary(salary1)));
                            break;
                        case 3:
                            Console.WriteLine("Your salary: " + employee.Tax(employee.Salary(salary2)));
                            break;
                    }
                    break;
            }
            Console.WriteLine("Your name: {0} \nYour surname: {1}",name,surname);
            Console.ReadLine();
        }
    }
}
