using System;
using System.Collections.Generic;
using System.Text;

namespace Sixth
{
    class Converter
    {
        public double EUR { get; set; }
        public double USD { get; set; }
        public double RUB { get; set; }

        public double ConvertEUR(double UAH, double EUR)
        {
            return UAH / EUR;
        }

        public double ConvertUSD(double UAH, double USD)
        {
            return UAH / USD;
        }
        public double ConvertRUB(double UAH, double RUB)
        {
            return UAH / RUB;
        }
        public double UAHtoUSD(double USD)
        {
            return USD / 0.035;
        }
        public double UAHtoEUR(double EUR)
        {
            return EUR / 0.030;
        }
        public double UAHtoRUB(double RUB)
        {
            return RUB / 2.80;
        }
    }
}
