using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishAndAnimals
{
    public static class FishCanDance
    {
        public static void CanDance(this Fish fish)
        {
            Console.WriteLine($"Here is fish-dancer {fish.Name}, which lives in {fish.TypeOfWaterPreference} water and is able to dance;");
        }
    }
}
