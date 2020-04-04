using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Client> clients = new List<Client>();
            List<Products> products = new List<Products>();
            List<Employee> employee = new List<Employee>();
            List<Service> service = new List<Service>();
            List<string> recipts = new List<string>();

            Console.WriteLine("Welcome to the supermarket");
            int n = 1;
            while (n == 1)
            {
                Console.WriteLine("Select an option: \n 1.Add a new person \n 2. Add a new product  \n 3. Shop \n 4. Change the job of someone \n 5. See all reciepts \n 6. Seeall the people  \n 9. Get out");
                string menu = Console.ReadLine();
                if (menu == "1") //Add new person
                {
                    string name, lastName, rut, birthDay, nacionality, position;
                    int salary, hours;
                    Console.WriteLine("Enter de person´s Name");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter de person´s Last Name");
                    lastName = Console.ReadLine();
                    Console.WriteLine("Enter de person´s Rut");
                    rut = Console.ReadLine();
                    Console.WriteLine("Enter de person´s Birth Day (dd,mm,yyyy)");
                    birthDay = Console.ReadLine();
                    Console.WriteLine("Enter de person´s Nationality");
                    nacionality = Console.ReadLine();
                    Console.WriteLine("Please select a possition: \n Client \n Boss \n Supervisor \n Cashier \n Guard \n Cleaning");
                    position = Console.ReadLine();
                    Console.WriteLine("Please enter the salary");
                    salary = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the amount of hours a week");
                    hours = Int32.Parse(Console.ReadLine());
                    if (position == "Client")
                    {
                        Client person = new Client(name, lastName, rut, birthDay, nacionality);
                        clients.Add(person);
                        Console.WriteLine(person.Show()); 
                    }
                    else if (position == "Boss" ^ position == "Supervisor" ^ position == "Cashier")
                    {
                        Employee person = new Employee(name, lastName, rut, birthDay, nacionality, position, salary, hours);
                        employee.Add(person);
                        Console.WriteLine(person.Show());
                    }
                    else if (position == "Guard" ^ position == "Cleaning")
                    {
                        Service person = new Service(name, lastName, rut, birthDay, nacionality, position, salary, hours);
                        service.Add(person);
                        Console.WriteLine(person.Show());
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid option");
                    }
                    n = 1;
                }
                else if (menu == "2") // Add new product
                {
                    string thing, brand;
                    int price, stock;
                    Console.WriteLine("Please enter a thing");
                    thing = Console.ReadLine();
                    Console.WriteLine("Please enter a brand");
                    brand = Console.ReadLine();
                    Console.WriteLine("Please enter the price");
                    price = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the stock");
                    stock = Int32.Parse(Console.ReadLine());
                    Products product = new Products(thing, brand, price, stock);
                    products.Add(product);
                    product.InfoProduct();
                    n = 1;
                }
                else if (menu == "3") // Shop
                {
                    Console.WriteLine("You want to enter as Supervisor (add stock of a product) or Client (buy products)");
                    string j = Console.ReadLine();
                    if (j == "Supervisor")
                    {
                        Console.WriteLine("Enter the product that you want to add stock of");
                        string p = Console.ReadLine();
                        Console.WriteLine("Enter the amount you want to add");
                        int num = Int32.Parse(Console.ReadLine());
                        foreach (Products p1 in products)
                        {
                            if (p1.Thing1 == p)
                            {
                                p1.AddStock(num);
                            }
                        }
                        
                    }
                    else if (j == "Client")
                    {
                        Console.WriteLine("Please enter your rut");
                        string rut = Console.ReadLine();
                        Client cli;
                        foreach (Client c1 in clients)
                        {
                            if (c1.Rut1 == rut)
                            {
                                cli = c1;
                            }
                        }
                        Console.WriteLine("This are the products aveilable");
                        foreach (Products p2 in products)
                        {
                            Console.WriteLine(p2.Thing1);
                        }
                        int m = 1;
                        while( m == 1)
                        {
                            Console.WriteLine("Please enter a product");
                            string thing = Console.ReadLine();
                            Console.WriteLine("Please enter the amount of product that you want to add to your cart");
                            int cant = Int32.Parse(Console.ReadLine());
                            foreach (Products p3 in products)
                            {
                                if (p3.Thing1 == thing)
                                {
                                    cli.AddtoCart(p3, cant);
                                }
                            }
                            Console.WriteLine("Do you want to continue shopping? 1.Yes, 0. No");
                            m = Int32.Parse(Console.ReadLine());
                        }
                        recipts.Add(cli.MakeReciept(employee));
                        Console.WriteLine(cli.MakeReciept(employee));
                        
                        

                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid anwser");
                    }
                    
                    n = 1;
                }

                else if (menu == "4") // Upgrade
                {
                    n = 1;
                }

                else if (menu == "5") // All reciepts
                {
                    foreach (String r in recipts)
                    {
                        Console.WriteLine(r);
                    }
                    n = 1;
                }
                
                else if (menu == "6") // All people
                {
                    Console.WriteLine("Employee");
                    foreach (Employee e in employee)
                    {
                        Console.WriteLine(e.Show());
                    }
                    
                    Console.WriteLine("Service");
                    foreach (Service s in service)
                    {
                        Console.WriteLine(s.Show());
                    }
                    
                    Console.WriteLine("Client");
                    foreach (Client c in clients)
                    {
                        Console.WriteLine(c.Show());
                    }
                    n = 1;
                }

                else if (menu == "9")
                {
                    Console.WriteLine("Thank you for coming");
                    n = 0;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                    n = 1;

                }

            }
            Console.ReadLine();
        }
    }
}
