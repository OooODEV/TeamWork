using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;

namespace Eighth
{
    class Invoice
    {
        public int account = 5511;

        public string customer = "Elena Malisheva";

        public string provider = "Valeriy Jmishenko";

        private string article { get; set; }

        private int quantity { get; set; }

        public void GetInfo()
        {
            Console.WriteLine("ID = {1} \nCustomer: {1} \nProvider: {2}",account,customer,provider);
        }

        public void GetArticle()
        {
            Console.WriteLine("Choose your commodity: \n1.TV \n2.Pa4ka Gre4ki \n3.Knife");
        }

        public double GetNDS(double cost,double quantity)
        {
            return (cost * quantity) + (cost * quantity * 0.2);
        }
    }
}
