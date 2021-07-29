using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkInterfaces
{
    class Dog: IAnimal, IMakeSoundable
    {
        public void Eat()
        {
            Console.WriteLine("the dog is eating");
        }   
        public void Move()
        {
            Console.WriteLine("the dog is moving");
        }
        public void Sleep()
        {
            Console.WriteLine("the dog is sleep");

        }
        public void MakeSoundBeforeEating()
        {
            Console.WriteLine("ggggg");
        }
    }
}
