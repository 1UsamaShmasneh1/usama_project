using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Proprties
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Table
    {
        private int price;
        private string color;
        private string manufacturer = "some";
        public int Price { get; set; }
        public string Color { get; private set; }
        public string Manufacturer { get; }
    }
}
