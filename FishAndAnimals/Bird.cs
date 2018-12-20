using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishAndAnimals
{
    public class Bird : Animal
    {
        public Color Colour { get; set; }

        public void CanFly()
        {
            Console.WriteLine($"The bird {Name} of {Colour} color with the length of it's body {Length} cm. and it's {Weight} kg.;");
        }
    }
}
