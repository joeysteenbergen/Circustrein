using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            AnimalFactory factory = new AnimalFactory();
            Train train = new Train();
            train.SortCargo(factory.CreateRandomAnimals(Convert.ToInt32(Console.ReadLine())));
            train.PrintWagonsList();
            Console.Read();

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

                UnitOneAnimals.Add(new Animal(EatType.Carnivoor, Size.Five));
                UnitOneAnimals.Add(new Animal(EatType.Carnivoor, Size.Three));
                UnitOneAnimals.Add(new Animal(EatType.Herbivoor, Size.Five));
                UnitOneAnimals.Add(new Animal(EatType.Herbivoor, Size.Five));
                UnitOneAnimals.Add(new Animal(EatType.Herbivoor, Size.Five));
                UnitOneAnimals.Add(new Animal(EatType.Herbivoor, Size.Five));

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

                UnitTwoAnimals.Add(new Animal(EatType.Carnivoor, Size.Five));
                UnitTwoAnimals.Add(new Animal(EatType.Carnivoor, Size.Five));
                UnitTwoAnimals.Add(new Animal(EatType.Carnivoor, Size.Three));
                UnitTwoAnimals.Add(new Animal(EatType.Carnivoor, Size.Three));
                UnitTwoAnimals.Add(new Animal(EatType.Carnivoor, Size.One));
                UnitTwoAnimals.Add(new Animal(EatType.Carnivoor, Size.One));
                UnitTwoAnimals.Add(new Animal(EatType.Herbivoor, Size.Five));
                UnitTwoAnimals.Add(new Animal(EatType.Herbivoor, Size.Five));
                UnitTwoAnimals.Add(new Animal(EatType.Herbivoor, Size.Three));
                UnitTwoAnimals.Add(new Animal(EatType.Herbivoor, Size.Three));
                UnitTwoAnimals.Add(new Animal(EatType.Herbivoor, Size.One));
                UnitTwoAnimals.Add(new Animal(EatType.Herbivoor, Size.One));

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

                UnitThreeAnimals.Add(new Animal(EatType.Herbivoor, Size.Five));
                UnitThreeAnimals.Add(new Animal(EatType.Herbivoor, Size.Five));
                UnitThreeAnimals.Add(new Animal(EatType.Herbivoor, Size.Three));
                UnitThreeAnimals.Add(new Animal(EatType.Herbivoor, Size.Three));
                UnitThreeAnimals.Add(new Animal(EatType.Herbivoor, Size.One));
                UnitThreeAnimals.Add(new Animal(EatType.Herbivoor, Size.One));

                return UnitThreeAnimals;
            }
        }
    }
}
