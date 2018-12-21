using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishAndAnimals
{
   public class Fish : Animal, ICanSwim
    {
        public TypeOfWaterPreference TypeOfWaterPreference { get; set; }

        public void CanSwim()
        {
            Console.WriteLine($"Here is fish {Name} with the length of it's body {Length} cm. and it's {Weight} kg. lives in {TypeOfWaterPreference} water;");
        }
    }
}
