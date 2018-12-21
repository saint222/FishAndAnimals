using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishAndAnimals
{
    public class Mammal : Animal
    {
        public void CanGo()
        {
            Console.WriteLine($"Here is animal {Name} with the length of it's body {Length} cm. and it's weight {Weight} kg.;");
        }
    }
}
