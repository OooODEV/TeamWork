using System;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            Address addressInfo = new Address();

            addressInfo.index = 5;
            addressInfo.house = 2;
            addressInfo.apartament = 43;
            addressInfo.country = "Ukraine";
            addressInfo.city = "Kyiv";

            addressInfo.GetInfo(addressInfo.index, addressInfo.house, addressInfo.apartament, addressInfo.country, addressInfo.city);
        }
    }
}
