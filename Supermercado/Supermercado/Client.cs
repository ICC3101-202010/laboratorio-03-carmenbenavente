using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    public class Client : Person
    {
        public Client(string name, string lastName, string rut, string birthDay, string nacionality) : base(name, lastName, rut, birthDay, nacionality)
        {
        }
        List<string> Cart = new List<string>();
        public void AddtoCart(Products p, int n)
        {
            if (p.Stock1 != 0)
            {
                if (p.Stock1 > n)
                {
                    int v = p.Stock1 - n;
                    p.Stock1 = v;
                    while (n != 0)
                    {
                        Cart.Add(p.InfoProduct());
                        n -= 1;
                    }
                }
                else
                {
                    Console.WriteLine("There is not enough of this product, the amount left is {0}", p.Stock1);
                }
            }
            else
            {
                Console.WriteLine("We ran out of this product");
            }
        }

        public void MakeReciept()
        {
            // info client
            Show();
            //ramdom cashier
            
            // date and time
           
            // Cart 
            foreach (string c in Cart)
                {
                Console.WriteLine(c);
                }
        }
    }
}
