using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkAccessModifiers1
{
    class ClientsManagment
    {
        private string[] _customers;
        private int[] _ages;
        private bool[] _isVegetarian;
        public int _counter;
        public ClientsManagment(string[] customers, int[] ages, bool[] isVegetarian, int counter)
        {
            _customers = customers;
            _ages = ages;
            _isVegetarian = isVegetarian;
            _counter = counter;
        }
        private void AddNewNameToList(string newName)
        {
            if (!string.IsNullOrEmpty(newName))
            {
                _customers[_counter] = newName;
            }
            else
            {
                Console.WriteLine("enter valid name");
            }
        }
        private void AddNewAgeToList(int newAge)
        {
            if(newAge > 18)
            {
                _ages[_counter] = newAge;
            }
            else
            {
                Console.WriteLine("you must be bigg than 18 old");
            }
        }
        private void AddNewBoolToList(bool newBool)
        {
            _isVegetarian[_counter] = newBool;
        }
        public void AddNewClint(string newName, int newAge, bool newBool)
        {
            AddNewNameToList(newName);
            AddNewAgeToList(newAge);
            AddNewBoolToList(newBool);
        }
        public bool GetIfIsVeg(int index, ClientsManagment c)
        {
            return c._isVegetarian[index];
        }
        public int GetAge(int index, ClientsManagment c)
        {
            return c._ages[index];
        }
        public string GetName(int index, ClientsManagment c)
        {
            return c._customers[index];
        }
    }
}
