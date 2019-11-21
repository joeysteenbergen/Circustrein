using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Wagon
    {
        public int capacityLeft { get; private set; }
        public List<Animal> animalsForWagon  = new List<Animal>();

        public Wagon(List<Animal> animals)
        {
            this.capacityLeft = 10;
            this.animalsForWagon = animals;
        }

        /*public void AddAnimalToWagon(Animal animal)
        {
            this.animalsForWagon.Add(animal);
            this.capacityLeft -= animal.size;
        }*/

        public List<Animal> GetAnimalsInWagon()
        {
            return animalsForWagon;
        }
    }
}
