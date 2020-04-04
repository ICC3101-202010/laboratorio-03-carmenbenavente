using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    public class Person
    {
        private string Name;
        private string LastName;
        private string Rut;
        private string BirthDay;
        private string Nacionality;

        public Person(string name, string lastName, string rut, string birthDay, string nacionality)
        {
            Name1 = name;
            LastName1 = lastName;
            Rut1 = rut;
            BirthDay1 = birthDay;
            Nacionality1 = nacionality;
        }

        public string Name1 { get => Name; set => Name = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public string Rut1 { get => Rut; set => Rut = value; }
        public string BirthDay1 { get => BirthDay; set => BirthDay = value; }
        public string Nacionality1 { get => Nacionality; set => Nacionality = value; }

        public void Show()
        {
            Console.WriteLine("Name: {0} \n Last Name: {1} \n Rut: {2} \n Birthday: {3} \n Nacionality: {4} ", Name1, LastName1, Rut1, BirthDay1, Nacionality1);
        }

    }
}
