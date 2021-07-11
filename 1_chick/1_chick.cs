using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_chick
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            Person[] persons = new Person[size];
            string[] personNames = new string[size];
            int[] personAges = new int[size];
            string name;
            int age;
            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine("enter name");
                name = Console.ReadLine();
                Console.WriteLine("enter age");
                age = Convert.ToInt32(Console.ReadLine());
                persons[i] = new Person(name, age);
                personNames[i] = persons[i]._name;
                personAges[i] = persons[i]._age;
            }
            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine($"Name: {persons[i]._name}. Age: {persons[i]}");
            }
        }
    }
    class Person
    {
        public string _name;
        public int _age;
        public Person(string name)
        {
            _name = name;
        }
        public Person(string name, int age) : this(name)
        {
            _age = age;
        }
    }
}
