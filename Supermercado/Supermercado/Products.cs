using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    public class Products
    {
        private string Thing;
        private string Brand;
        private int Price;
        private int Stock;

        public Products(string thing, string brand, int price, int stock)
        {
            Thing1 = thing;
            Brand1 = brand;
            Price1 = price;
            Stock1 = stock;
        }

        public string Thing1 { get => Thing; set => Thing = value; }
        public string Brand1 { get => Brand; set => Brand = value; }
        public int Price1 { get => Price; set => Price = value; }
        public int Stock1 { get => Stock; set => Stock = value; }

        public void AddStock(int n)
        {
            int v = Stock1 + n;
            Stock1 = v;
        }

        public string InfoProduct()
        {
            return (Thing + Brand + Price.ToString());
        }
    }
}
