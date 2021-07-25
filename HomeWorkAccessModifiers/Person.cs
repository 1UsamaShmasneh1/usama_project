using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkAccessModifiers1
{
    class Person
    {
        private readonly string _id;
        private string _phone;
        private string _name;
        private static int numperOfPersons = 0;
        public Person(string name, string phone)
        {
            _phone = phone;
            _name = name;
            numperOfPersons++;
            _id = Convert.ToString(numperOfPersons);
        }
        public static void ChangeName(Person person, string name)
        {
            person._name = name;
        }
        public static void ChangePhone(Person person, string phone)
        {
            person._phone = phone;
        }
        public static int GetNumberOfPersons()
        {
            return numperOfPersons;
        }
    }
}
