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
                Console.WriteLine("\n Select an option: \n 1. Add a new person \n 2. Add a new product  \n 3. Shop \n 4. Change the job of someone \n 5. See all reciepts \n 6. See all the people  \n 7. See all the products left \n 9. Get out");
                string menu = Console.ReadLine();
                if (menu == "1") //Add new person
                {
                    string name, lastName, rut, birthDay, nacionality, position;
                    int salary, hours;
                    Console.WriteLine("\n Enter the person´s Name");
                    name = Console.ReadLine();
                    Console.WriteLine("\n Enter Last Name");
                    lastName = Console.ReadLine();
                    Console.WriteLine("\n Enter Rut (nnnnnnnn-n)");
                    rut = Console.ReadLine();
                    Console.WriteLine("\n Enter Birth Day (dd-mm-yyyy)");
                    birthDay = Console.ReadLine();
                    Console.WriteLine("\n Enter Nationality");
                    nacionality = Console.ReadLine();
                    Console.WriteLine("\n Please select a possition: \n Client \n Boss \n Supervisor \n Cashier \n Guard \n Cleaning");
                    position = Console.ReadLine();
                    
                    if (position == "Client")
                    {
                        Client person = new Client(name, lastName, rut, birthDay, nacionality);
                        clients.Add(person);
                        Console.WriteLine("\n" + person.Show()); 
                    }
                    else if (position == "Boss" ^ position == "Supervisor" ^ position == "Cashier")
                    {
                        Console.WriteLine("\n Please enter the salary");
                        salary = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\n Please enter the amount of hours a week");
                        hours = Int32.Parse(Console.ReadLine());
                        Employee person = new Employee(name, lastName, rut, birthDay, nacionality, position, salary, hours);
                        employee.Add(person);
                        Console.WriteLine("\n" + person.Show());
                    }
                    else if (position == "Guard" ^ position == "Cleaning")
                    {
                        Console.WriteLine("\n Please enter the salary");
                        salary = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\n Please enter the amount of hours a week");
                        hours = Int32.Parse(Console.ReadLine());
                        Service person = new Service(name, lastName, rut, birthDay, nacionality, position, salary, hours);
                        service.Add(person);
                        Console.WriteLine("\n" + person.Show());
                    }
                    else
                    {
                        Console.WriteLine("\n Enter a valid option");
                    }
                    n = 1;
                }
                else if (menu == "2") // Add new product
                {
                    string thing, brand;
                    int price, stock;
                    Console.WriteLine("\n Please enter a thing");
                    thing = Console.ReadLine();
                    Console.WriteLine("\n Please enter a brand");
                    brand = Console.ReadLine();
                    Console.WriteLine("\n Please enter the price");
                    price = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("\n Please enter the stock");
                    stock = Int32.Parse(Console.ReadLine());
                    Products product = new Products(thing, brand, price, stock);
                    products.Add(product);
                    Console.WriteLine("\n" + product.InfoProduct());
                    n = 1;
                }
                else if (menu == "3") // Shop
                {
                    Console.WriteLine("\n You want to enter as Supervisor (add stock of a product) or Client (buy products)");
                    string j = Console.ReadLine();
                    if (j == "Supervisor")
                    {
                        Console.WriteLine("\n Enter the product that you want to add stock of");
                        string p = Console.ReadLine();
                        Console.WriteLine("\n Enter the amount you want to add");
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
                        Console.WriteLine("\n Please enter your rut");
                        string rut = Console.ReadLine();
                        Client cli = new Client();
                        foreach (Client c1 in clients)
                        {
                            if (c1.Rut1 == rut)
                            {
                                cli = c1;
                            }
                        }
                        Console.WriteLine("\n This are the products available");
                        foreach (Products p2 in products)
                        {
                            Console.WriteLine("\n" + p2.InfoProduct());
                        }
                        int m = 1;
                        while( m == 1)
                        {
                            Console.WriteLine("\n Please enter a product");
                            string thing = Console.ReadLine();
                            Console.WriteLine("\n Please enter the brand of the product");
                            string brand = Console.ReadLine();
                            Console.WriteLine("\n Please enter the amount of product that you want to add to your cart");
                            int cant = Int32.Parse(Console.ReadLine());
                            foreach (Products p3 in products)
                            {
                                if (p3.Thing1 == thing && p3.Brand1 == brand)
                                {
                                    cli.AddtoCart(p3, cant);
                                }
                            }
                            Console.WriteLine("\n Do you want to continue shopping? 1.Yes, 0. No");
                            m = Int32.Parse(Console.ReadLine());
                        }
                        string l = cli.MakeReciept(employee);
                        recipts.Add(l);
                        Console.WriteLine("\n" + l);
                        
                        

                    }
                    else
                    {
                        Console.WriteLine("\n Please enter a valid anwser");
                    }
                    
                    n = 1;
                }

                else if (menu == "4") // Upgrade
                {
                    Console.WriteLine("\n Enter the person rut");
                    string rut = Console.ReadLine();
                    Console.WriteLine("\n This person is an Employee or Service?");
                    string cla = Console.ReadLine();
                    if (cla == "Employee")
                    {
                        Employee per = new Employee();
                        foreach (Employee e in employee)
                        {
                            if (e.Rut1 == rut)
                            {
                                per = e;
                            }
                        }
                        Console.WriteLine("\n You want to change the Position, Hours or Salary?");
                        string change = Console.ReadLine();
                        if (change == "Position")
                        {
                            Console.WriteLine("\n The position of this person is {0}", per.Position1);
                            Console.WriteLine("\n Enter the new Position: Boss, Supervisor or Cashier");
                            string position = Console.ReadLine();
                            per.ChangePosition(position);
                            Console.WriteLine("\n The new position of this person is {0}", per.Position1);
                        }
                        else if (change == "Hours")
                        {
                            Console.WriteLine("\n The hours per week of this person is {0}", per.Hours1);
                            Console.WriteLine("\n Enter the change of hours (if you want less hours enter -#)");
                            int hours = Int32.Parse(Console.ReadLine());
                            per.EChangeHours(hours);
                            Console.WriteLine("\n The new hours per week of this person is {0}", per.Hours1);
                        }
                        else if (change == "Salary")
                        {
                            Console.WriteLine("\n The salary of this person is {0}", per.Salary1);
                            Console.WriteLine("\n Enter the change of salary (if you want less salary enter -#)");
                            int salary = Int32.Parse(Console.ReadLine());
                            per.EChangeSalary(salary);
                            Console.WriteLine("\n The new salary of this person is {0}", per.Salary1);
                        }
                        else
                        {
                            Console.WriteLine("\n Enter a valid option");
                        }

                    }
                    else if (cla == "Service")
                    {
                        Service per = new Service();
                        foreach (Service s in service)
                        {
                            if (s.Rut1 == rut)
                            {
                                per = s;
                            }
                        }
                        Console.WriteLine("\n You want to change the Hours or Salary?");
                        string change = Console.ReadLine();
                        if (change == "Hours")
                        {
                            Console.WriteLine("\n The hours per week of this person is {0}", per.Hours1);
                            Console.WriteLine("\n Enter the change of hours (if you want less hours enter -#)");
                            int hours = Int32.Parse(Console.ReadLine());
                            per.SChangeHours(hours);
                            Console.WriteLine("\n The new hours per week of this person is {0}", per.Hours1);
                        }
                        else if (change == "Salary")
                        {
                            Console.WriteLine("\n The salary of this person is {0}", per.Salary1);
                            Console.WriteLine("\n Enter the change of salary (if you want less salary enter -#)");
                            int salary = Int32.Parse(Console.ReadLine());
                            per.SChangeSalary(salary);
                            Console.WriteLine("\n The new salary of this person is {0}", per.Salary1);
                        }
                        else
                        {
                            Console.WriteLine("\n Enter a valid option");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n Enter a valid option");
                    }

                    n = 1;
                }

                else if (menu == "5") // All reciepts
                {
                    foreach (String r in recipts)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine(r);
                    }
                    n = 1;
                }
                
                else if (menu == "6") // All people
                {
                    Console.WriteLine("\n Employee");
                    foreach (Employee e in employee)
                    {
                        Console.WriteLine(e.Show());
                    }
                    
                    Console.WriteLine("\n Service");
                    foreach (Service s in service)
                    {
                        Console.WriteLine(s.Show());
                    }
                    
                    Console.WriteLine("\n Client");
                    foreach (Client c in clients)
                    {
                        Console.WriteLine(c.Show());
                    }
                    n = 1;
                }

                else if (menu == "7")
                {
                    foreach (Products pro in products)
                    {
                        Console.WriteLine("\n" + pro.StockProduct());
                    }
                }
                
                
                else if (menu == "9")
                {
                    Console.WriteLine("\n Thank you for coming");
                    n = 0;
                }
                else
                {
                    Console.WriteLine("\n Please enter a valid number");
                    n = 1;

                }

            }
            Console.ReadLine();
        }
    }
}
