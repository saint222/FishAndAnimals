using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishAndAnimals
{
    public class Predator : Mammal, IEatAnimal
    {
        public void EatAnimal(Animal animal)
        {
            Console.WriteLine($"{Name} -  is a predator and eats {animal.Name};");
        }
    }
}
