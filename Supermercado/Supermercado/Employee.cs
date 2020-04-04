using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    public class Employee : Person
    {
        private string Position; // Boss, Supervisor, Cashier
        private int Salary;
        private int Hours;

        public Employee(string name, string lastName, string rut, string birthDay, string nacionality, string position, int salary, int hours) : base(name, lastName, rut, birthDay, nacionality)
        {
            Position1 = position;
            Salary1 = salary;
            Hours1 = hours;
        }

        public string Position1 { get => Position; set => Position = value; }
        public int Salary1 { get => Salary; set => Salary = value; }
        public int Hours1 { get => Hours; set => Hours = value; }
        // Aumentar position
    }
}
