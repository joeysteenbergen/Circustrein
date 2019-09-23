using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalFactory factory = new AnimalFactory();
            Train train = new Train();
            train.GetWagons(factory.CreateAnimals(Convert.ToInt32(Console.ReadLine())));

            //Call for Unit Tests
            //train.GetWagons(MoreBigHerbivore());

            /*Unit Tests*/
            List<Animal> MoreBigHerbivores()
            {
                /*
                    Uitkomst:
                    Wagon 1: Carnivoor 5;
                    Wagon 2: Carnivoor 3, Herbivoor 5;
                    Wagon 3: Herbivoor 5, Herbivoor 5;
                    Wagon 4: Herbivoor 5;
                 */

                List<Animal> UnitOneAnimals = new List<Animal>();

                UnitOneAnimals.Add(new Animal(Animal.EatTypes.Carnivoor, 5));
                UnitOneAnimals.Add(new Animal(Animal.EatTypes.Carnivoor, 3));
                UnitOneAnimals.Add(new Animal(Animal.EatTypes.Herbivoor, 5));
                UnitOneAnimals.Add(new Animal(Animal.EatTypes.Herbivoor, 5));
                UnitOneAnimals.Add(new Animal(Animal.EatTypes.Herbivoor, 5));
                UnitOneAnimals.Add(new Animal(Animal.EatTypes.Herbivoor, 5));

                return UnitOneAnimals;
            }

            List<Animal> EveryTypeAndEverySize()
            {
                /*
                    Uitkomst:
                    Wagon 1: Carnivoor 5;
                    Wagon 2: Carnivoor 5;
                    Wagon 3: Carnivoor 3, Herbivoor 5;
                    Wagon 4: Carnivoor 3, Herbivoor 5;
                    Wagon 5: Carnivoor 1, Herbivoor 3, Herbivoor 3;
                    Wagon 6: Carnivoor 1;
                    Wagon 7: Herbivoor 1, Herbivoor 1;
                 */

                List<Animal> UnitTwoAnimals = new List<Animal>();

                UnitTwoAnimals.Add(new Animal(Animal.EatTypes.Carnivoor, 5));
                UnitTwoAnimals.Add(new Animal(Animal.EatTypes.Carnivoor, 5));
                UnitTwoAnimals.Add(new Animal(Animal.EatTypes.Carnivoor, 3));
                UnitTwoAnimals.Add(new Animal(Animal.EatTypes.Carnivoor, 3));
                UnitTwoAnimals.Add(new Animal(Animal.EatTypes.Carnivoor, 1));
                UnitTwoAnimals.Add(new Animal(Animal.EatTypes.Carnivoor, 1));
                UnitTwoAnimals.Add(new Animal(Animal.EatTypes.Herbivoor, 5));
                UnitTwoAnimals.Add(new Animal(Animal.EatTypes.Herbivoor, 5));
                UnitTwoAnimals.Add(new Animal(Animal.EatTypes.Herbivoor, 3));
                UnitTwoAnimals.Add(new Animal(Animal.EatTypes.Herbivoor, 3));
                UnitTwoAnimals.Add(new Animal(Animal.EatTypes.Herbivoor, 1));
                UnitTwoAnimals.Add(new Animal(Animal.EatTypes.Herbivoor, 1));

                return UnitTwoAnimals;
            }

            List<Animal> OnlyHerbivores()
            {
                /*
                    Uitkomst:
                    Wagon 1: Herbivoor 5, Herbivoor 5;
                    Wagon 2: Herbivoor 3, Herbivoor 3, Herbivoor 1, Herbivoor 1;
                 */

                List<Animal> UnitThreeAnimals = new List<Animal>();

                UnitThreeAnimals.Add(new Animal(Animal.EatTypes.Herbivoor, 5));
                UnitThreeAnimals.Add(new Animal(Animal.EatTypes.Herbivoor, 5));
                UnitThreeAnimals.Add(new Animal(Animal.EatTypes.Herbivoor, 3));
                UnitThreeAnimals.Add(new Animal(Animal.EatTypes.Herbivoor, 3));
                UnitThreeAnimals.Add(new Animal(Animal.EatTypes.Herbivoor, 1));
                UnitThreeAnimals.Add(new Animal(Animal.EatTypes.Herbivoor, 1));

                return UnitThreeAnimals;
            }
        }
    }
}
