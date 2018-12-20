using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishAndAnimals
{
    public class Animal
    {
        public string Name { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }

        public void CanGo ()
        {
            Console.WriteLine($"The animal {Name} with the length of it's body {Length} cm. and it's {Weight} kg.;");
        }
    }
}
