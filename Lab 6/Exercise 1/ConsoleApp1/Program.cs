using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DOCFile doc = new DOCFile();
            TXTFile txt = new TXTFile();

            Console.WriteLine("Enter file format");
            string DOCFormat = Console.ReadLine();

            if (DOCFormat.Equals("DOC"))
            {
                doc.Open();
                doc.Create();
                doc.Edit();
            }
            else if (DOCFormat.Equals("TXT"))
            {
                txt.Open();
                txt.Create();
                txt.Edit();
            }
            else
            {
                Console.WriteLine("Wrong file format");
            }
            Console.ReadKey();
        }
    }
}
