using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class AnimalFactory
    {
        private Array sizes = Enum.GetValues(typeof(Size));
        private Array allEatTypes = Enum.GetValues(typeof(EatType));

        public List<Animal> CreateRandomAnimals(int number)
        {
            Random rnd = new Random();
            List<Animal> animals = new List<Animal>();

            for (int i = 0; i < number; i++)
            {
                Animal animal = new Animal((EatType)allEatTypes.GetValue(rnd.Next(allEatTypes.Length)), (Size)sizes.GetValue(rnd.Next(sizes.Length)));
                animals.Add(animal);
            }

            return animals;
        }     
    }
}
