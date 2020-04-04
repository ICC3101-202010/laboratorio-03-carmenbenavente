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

        public string MakeReciept(List<Employee> list)
        {
            string reciept;
            string v = "\n";
            string cli = "Client:";
            string cas = "Cashier:";
            string car = "All products:";

            reciept = cli + Show() + v;

            List<Employee> Cashiers = new List<Employee>();
            foreach (Employee em in list)
            {
                if (em.Position1 == "Cashier")
                {
                    Cashiers.Add(em);
                }
            }
            var random = new Random();
            int index = random.Next(Cashiers.Count);
            Employee cashier = Cashiers[index];
            reciept = cas + cashier.Show() + v;

            DateTime dateTime = DateTime.Now;
            reciept += dateTime + v;

            reciept += car + v;
            foreach (string c in Cart)
                {
                reciept += c;
                reciept += v;
                }
            return reciept;
        }
    }
}
