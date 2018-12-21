using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishAndAnimals
{
    public class FishPredators : Fish, IEatAnimal
    {
        public void EatAnimal(Animal animal)
        {
            Console.WriteLine($"Fish {Name} -  is a predator and ... fucks {animal.Name} together with SubZero;");
        }
    }
}
