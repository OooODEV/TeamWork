using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exercise_3
{
    class Store
    {

        private List<Article> goods;
        public Article this[int index] => goods[index];
        public Article this[string name] => goods.FirstOrDefault(g => g.Name.Equals(name));

        public Store()
        {
            goods = new List<Article>();
        }

        public void Add(Article article)
        {
            goods.Add(article);
        }

        public void Print()
        {
            foreach (var m in goods)
                Console.WriteLine(m.ToString());
        }
        public void SortByPrice()
        {
            goods = goods.OrderBy(g => g.Price).ToList();
        }

        public void SortByName()
        {
            goods = goods.OrderBy(g => g.Name).ToList();
        }

        public void SortByStoreName()
        {
            goods = goods.OrderBy(g => g.StoreName).ToList();
        }
    }
}
