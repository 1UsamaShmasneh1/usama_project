using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c;
        }
    }
    struct Car
    {
        string model;
        string color;
        int numOfDoors;
        public Car(string model, string color, int numOfDoors)
        {
            this.model = model;
            this.color = color;
            this.numOfDoors = numOfDoors;
        }
    }
}
