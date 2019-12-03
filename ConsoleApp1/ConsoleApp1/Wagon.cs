using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Wagon
    {
        public int capacityLeft { get; set; }
        public List<Animal> animalsForWagon  = new List<Animal>();

        public Wagon(List<Animal> animals)
        {
            this.capacityLeft = 10;
            this.animalsForWagon = animals;
        }
    }
}
