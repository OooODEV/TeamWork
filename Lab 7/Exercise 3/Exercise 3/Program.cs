using System;
using System.Linq;

namespace Exercise_3
{
    class Program
    {
        private static bool _insertMode = true;
        private static Store _store;
        static void Main(string[] args)
        {
            _store = new Store();

            while (_insertMode)
            {
                try
                {
                    Console.Write("Введите название товара:");
                    var name = Console.ReadLine();
                    Console.Write("Введите название магазина:");
                    var storeName = Console.ReadLine();
                    Console.Write("Введите стоимость товара:");
                    var price = decimal.Parse(Console.ReadLine());

                    var good = new Article(name, storeName, price);
                    _store.Add(good);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка ввода");
                }


                var answer = new ConsoleKeyInfo();
                while (answer.Key != ConsoleKey.Y)
                {
                    if (answer.Key == ConsoleKey.N)
                    {
                        _insertMode = false;
                        break;
                    }

                    Console.Write("Добавить еще один товар? (y - да, n - нет):");
                    answer = Console.ReadKey();
                    Console.WriteLine();
                }
            }

            Console.Write("Введите название товара для поиска:");
            var findName = Console.ReadLine();

            var foundGood = _store[findName];
            Console.WriteLine(foundGood == null ? "Такого товара нет" : $"{foundGood.Name}, {foundGood.Price}, {foundGood.StoreName}");

            Console.ReadLine();
        }
    }
}
