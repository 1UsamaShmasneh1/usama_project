using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ref_and_out
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 5;
            Pluse(ref y);

            int z;
            Pluse2(out z);


            string s;
            int res;
            do
            {
                Console.WriteLine("enter number");
                s = Console.ReadLine();
            }
            while (int.TryParse(s, out res));


            PrintNumbers(3, 5, 8);
        }
        static void Pluse(ref int x)
        {
            x++;
        }


        static void Pluse2(out int b)
        {
            b = 7;
            b++;
        }

        static bool InsertToDB(string name, int age, out string errorMessage)
        {
            errorMessage = "";
            if (string.IsNullOrEmpty(name))
            {
                errorMessage += "name is null or empty";
            }
            if(age == 0)
            {
                errorMessage += "\nage is 0";
            }
            return string.IsNullOrEmpty(name);
        }


        static void PrintNumbers(params int[] numbers)
        {

        }

        static void PrintNumber(in int numbers)
        {

        }


        static void PrintNumber2(string error, bool printMessage = true)
        {
            if(printMessage)
                Console.WriteLine("");
        }


        static string BuildSentence(params string[] str)
        {
            string str2 = "";
            for (int i = 0; i < str.Length; i++)
            {
                str2 += str[i] + " ";
            }
            return str2;
        }


        static void PrintNameAndIncreaseAge(params Person[] persons)
        {
            Person person = new Person();
            string str2 = "";
            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine(persons[i].name);
                person.IncreasAge(persons[i]);
            }
        }
    }
    class Person
    {
        public int age;
        public string name;
        public void IncreasAge(in Person person)
        {
            person.age += 1;
        }
    }
}
