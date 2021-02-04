using System;
using System.Collections.Generic;
using System.Text;

namespace Fifth
{
    class User
    {
        public string login { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }

        public void DATA()
        {
            DateTime data1 = DateTime.Now;
            Console.WriteLine(data1);
        }


    }
}
