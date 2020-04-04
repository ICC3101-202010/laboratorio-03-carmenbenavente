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
            Console.WriteLine("Welcome to the supermarket");
            int n = 1;
            while (n == 1)
            {
                Console.WriteLine("Select an option: \n 1.Add a new person \n 2. Add a new product  \n 3. Shop \n 4. Upgrade the job of someone \n 5. See all reciepts  \n 9. Get out");
                string menu = Console.ReadLine();
                if (menu == "1") //Add new person
                {
                    string name, lastName, rut, birthDay, nacionality, position;
                    int salary, hours;
                    Console.WriteLine("Name");
                    name = Console.ReadLine();
                    Console.WriteLine("Last Name");
                    lastName = Console.ReadLine();
                    Console.WriteLine("Rut");
                    rut = Console.ReadLine();
                    Console.WriteLine("Birth Day (dd,mm,yyyy)");
                    birthDay = Console.ReadLine();
                    Console.WriteLine("Nationality");
                    nacionality = Console.ReadLine();
                    Console.WriteLine("Please select a possition: \n 1. Client \n 2. Boss \n 3. Supervisor \n 4. Cashier \n 5. Guard \n 6. Cleaning ");
                    position = Console.ReadLine();
                    Console.WriteLine("Please enter the salary");
                    salary = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the amount of hours a week");
                    hours = Int32.Parse(Console.ReadLine());
                    if (position == "1")
                    {
                        Person person = new Person(name, lastName, rut, birthDay, nacionality);
                    }
                    else if (position == "2" ^ position == "3" ^ position == "4")
                    {
                        Employee person = new Employee(name, lastName, rut, birthDay, nacionality, position, salary, hours);
                    }
                    else if (position == "5" ^ position == "6")
                    {
                        Service person = new Service(name, lastName, rut, birthDay, nacionality, position, salary, hours);
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
                    n = 1;
                }
                else if (menu == "3") // Shop
                {
                    n = 1;
                }

                else if (menu == "4") // Upgrade
                {
                    n = 1;
                }

                else if (menu == "5") // All reciepts
                {
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
