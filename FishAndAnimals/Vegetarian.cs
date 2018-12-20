using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishAndAnimals
{
    public class Vegetarian : Mammal, IEatGrass
    {
        public void EatGrass()
        {
            Console.WriteLine($"Animal {Name} is a vegetarian and eats grass;");
        }
    }
}
