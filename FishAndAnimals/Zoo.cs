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
            flatfish.CanSwim();
            
            Predator cat = new Predator { Name = "cat Njasha", Length = 25, Weight = 5 };
            cat.CanGo();
            cat.EatAnimal(flatfish);

            Predator dog = new Predator { Name = "dog Bobik", Length = 50, Weight = 10};
            dog.CanGo();
            dog.EatAnimal(cat);

            Vegetarian cow = new Vegetarian { Name = "cow Burjonka", Length = 300, Weight = 100};
            cow.CanGo();
            cow.EatGrass();
            
            Vegetarian rabbit = new Vegetarian { Name = "rabbit Roger", Length = 15, Weight = 3 };
            rabbit.CanGo();
            rabbit.EatGrass();

            FishPredators shark = new FishPredators { Name = "shark Sharky", Length = 300, Weight = 150, TypeOfWaterPreference = TypeOfWaterPreference.salty};
            shark.CanSwim();
            shark.EatAnimal(cow);

            BirdPredator eagle = new BirdPredator { Name = "Eagle Fucker", Colour = Color.mixed, Weight = 7, Length = 150};
            eagle.CanFly();
            eagle.EatAnimal(rabbit);

            Bird nightingale = new Bird { Name = "nightingale Singer", Colour = Color.blue, Length = 5, Weight = 0.1 };
            nightingale.CanFly();

            Bird pigeon = new Bird { Name = "pigeon Dove", Colour = Color.black, Length = 7, Weight = 0.3};
            pigeon.CanFly();

            Fish dancer = new Fish { Name = "bird Dancer", TypeOfWaterPreference = TypeOfWaterPreference.salty};
            dancer.CanSwim();
            dancer.CanDance();
            
            
            

            

            

        }        

    }
}
