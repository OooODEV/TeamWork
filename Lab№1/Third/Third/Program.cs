using System;
using System.Security.Cryptography.X509Certificates;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        {
            Title NewTitle = new Title();
            Author NewAuthor = new Author();
            Content NewContent = new Content();
            Book NewBook = new Book();

            Console.WriteLine("Enter a title of book");
            string tit = Console.ReadLine();
            Console.WriteLine("Enter an author");
            string aut = Console.ReadLine();
            Console.WriteLine("Enter a content");
            string cont = Console.ReadLine();

            NewTitle.title = tit;
            NewAuthor.author = aut;
            NewContent.content = cont;

            NewBook.GetBook(NewTitle.title, NewAuthor.author, NewContent.content);

        }

       /* static void BookArr(string[] arr)
        {
            BookArr(new string[5]);
        }*/
    }
}
