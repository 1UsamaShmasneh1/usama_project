using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkInterfaces
{
    class HomeWorkInterfaces
    {
        static void Main(string[] args)
        {
        }
        public static void AnimallsHungry(IAnimal animal)
        {
            if(animal is IMakeSoundable)
            {
                IMakeSoundable animal2 = animal as IMakeSoundable;
                if (animal2 != null)
                    animal2.MakeSoundBeforeEating();
            }
            animal.Eat();
        }
        public static void AnimallsTired(IAnimal animal)
        {
            animal.Sleep();
        }
    }
}
