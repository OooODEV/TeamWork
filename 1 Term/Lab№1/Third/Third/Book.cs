using System;
using System.Collections.Generic;
using System.Text;

namespace Third
{
    class Book
    {
        public void GetBook(string name, string author, string content)
        {
            Console.WriteLine("Title:\"{0}\" \nAuthor: {1} \nContent: {2}  ", name, author, content);
        }
    }

    class Title
    {
        public string title { get; set; }

        
        public string GetTitle(string name)
        {
            return name;
        }
    }

    class Author
    {
        public string author { get; set; }

        public string GetAuthor(string author)
        {
            return author;
        }
    }

    class Content
    {
        public string content { get; set; }

        public string GetContent(string content)
        {
            return content;
        }
    }

}
