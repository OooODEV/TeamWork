using System;
using System.Collections.Generic;
using System.Text;

namespace First
{
    class Address
    {
        public int index { get; set; }
        public int house { get; set; }
        public int apartament { get; set; }
        public string country { get; set; }
        public string city { get; set; }

        public void GetInfo(int Index, int House, int Apartament, string Country, string City)
        {
            Console.WriteLine("Index: {0} \nHouse: {1} \nApartament: {2} \nCountry: {3} \nCity: {4}", Index, House, Apartament, Country, City);
        }
    }
}
