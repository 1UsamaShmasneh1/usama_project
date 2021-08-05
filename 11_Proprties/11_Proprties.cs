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
            Plane plane = new Plane();
            Crow crow = new Crow();
            if (plane is IFlyable)
                Fly(plane);
        }
        public static void Fly(IFlyable flyable)
        {

        }
        public static void GetAltitude(IFlyable flyable)
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
