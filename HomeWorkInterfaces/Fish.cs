using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkInterfaces
{
    class Fish: IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("the fish is eating");
        }
        public void Move()
        {
            Console.WriteLine("the fish is moving");
        }
        public void Sleep()
        {
            Console.WriteLine("the fish is sleeping");
        }
    }
}
