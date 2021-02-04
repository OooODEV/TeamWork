using System;

namespace Fifth
{
    class Program
    {
        static void Main(string[] args)
        {
            User person = new User();
            Console.WriteLine("Enter your name");
            person.name = Console.ReadLine();
            Console.WriteLine("Enter your surname");
            person.surname = Console.ReadLine();
            Console.WriteLine("Enter your age");
            person.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your login");
            person.login = Console.ReadLine();

            Console.WriteLine("\nYour name: {0} \nYour surname: {1} \nYour age: {2} \nYour login: {3}",person.name, person.surname, person.age,person.login);
            person.DATA();
            Console.ReadLine();
        }
    }
}
