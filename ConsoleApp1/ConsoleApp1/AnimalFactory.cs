using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class AnimalFactory
    {
        public List<Animal> animals = new List<Animal>();
        
        private int[] sizes = { 1, 3, 5 };
        private Array allEatTypes = Enum.GetValues(typeof(Animal.EatTypes));

        public List<Animal> CreateAnimals(int number)
        {
            Random rnd = new Random();

            for (int i = 0; i < number; i++)
            {
                Animal animal = new Animal((Animal.EatTypes)allEatTypes.GetValue(rnd.Next(allEatTypes.Length)), sizes[rnd.Next(sizes.Count())]);
                animals.Add(animal);
            }

            return animals;
        }     
    }
}
