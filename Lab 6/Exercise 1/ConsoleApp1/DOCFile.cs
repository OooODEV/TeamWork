using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class DOCFile : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open DOC"); ;
        }
        public override void Create()
        {
            Console.WriteLine("Create DOC"); ;
        }
        public override void Edit()
        {
            Console.WriteLine("Edit DOC"); ;
        }
    }
}
