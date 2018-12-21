using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishAndAnimals
{
    public class BirdPredator : Bird, IEatAnimal
    {
        public void EatAnimal(Animal animal)
        {
            Console.WriteLine($"{Name} -  is a predator and ... fucks {animal.Name}...alone...without SubZero...;");
        }
    }
}
