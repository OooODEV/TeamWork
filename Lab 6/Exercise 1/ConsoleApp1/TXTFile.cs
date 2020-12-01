using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TXTFile : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open TXT"); ;
        }
        public override void Create()
        {
            Console.WriteLine("Create TXT"); ;
        }
        public override void Edit()
        {
            Console.WriteLine("Edit TXT"); ;
        }

    }
}
