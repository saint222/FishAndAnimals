using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishAndAnimals
{
    public class Zoo
    {
        public void ZooDeals()
        {
            Fish flatfish = new Fish { Name = "Flipper", Length = 10, Weight = 0.5};
            Predator cat = new Predator { Name = "Njasha", Length = 25, Weight = 5 };
            cat.CanGo();
            cat.EatAnimal(flatfish);
            Vegetarian rabbit = new Vegetarian { Name = "Roger", Length = 15, Weight = 3 };

            

        }        

    }
}
