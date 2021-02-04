using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_3
{
    class Article
    {
        private string _Name{get; }
        private string _ShopName { get; }
        private decimal _Price { get; }

        public string Name => _Name;
        public string StoreName => _ShopName;
        public decimal Price => _Price;


        public Article(string name, string shopname, decimal price)
        {
            _Name = name;
            _ShopName = shopname;
            _Price = price;
        }
    }
}
