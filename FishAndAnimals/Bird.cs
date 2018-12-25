using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishAndAnimals
{
    public class Bird : Animal, ICanFly
    {
        public Color Colour { get; set; }

        public void CanFly()
        {
            Console.WriteLine($"Here is {Name} of {Colour} color with the length of it's body {Length} cm., it's {Weight} kg. who can fly;");
        }
    }
}
