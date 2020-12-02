using System;

namespace Exercise_2
{

    class Program
    {
        static void Main(string[] args)
        {
            MyMatrix matrix = new MyMatrix(2, 2);

            matrix.RanMatrix();
            matrix.ShowMatrix();

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Число столбцов - {0}\nЧисло строк - {1}", matrix.NumberOfCols, matrix.NumberOfRows);
            Console.WriteLine(new string('-', 30));

            matrix.ChangeMatrix(4, 4);
            matrix.RanMatrix();
            matrix.ShowMatrix();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Число столбцов - {0}\nЧисло строк - {1}", matrix.NumberOfCols, matrix.NumberOfRows);
            Console.WriteLine(new string('-', 30));
        }
    }
}
