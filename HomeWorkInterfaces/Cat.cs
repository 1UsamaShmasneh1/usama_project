using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkInterfaces
{
    class Cat: IAnimal, IMakeSoundable
    {
        public void Eat()
        {
            Console.WriteLine("the cat is eating");
        }
        public void Move()
        {
            Console.WriteLine("the cat is moving");
        }
        public void Sleep()
        {
            Console.WriteLine("the cat is sleeping");

        }
        public void MakeSoundBeforeEating()
        {
            Console.WriteLine("rrrrr");
        }
    }
}
