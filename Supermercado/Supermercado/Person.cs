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
        public Person()
        {

        }

        public string Name1 { get => Name; set => Name = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public string Rut1 { get => Rut; set => Rut = value; }
        public string BirthDay1 { get => BirthDay; set => BirthDay = value; }
        public string Nacionality1 { get => Nacionality; set => Nacionality = value; }

        public string Show()
        {
            string v = "\n";
            return (Name1 + v + LastName1 + v + Rut1 + v + BirthDay1 + v + Nacionality1);
        }

    }
}
