using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Wagon
    {
        public int PointsLeft { get; set; }
        public List<Animal> AnimalsForWagon  = new List<Animal>();

        public Wagon(List<Animal> animals)
        {
            PointsLeft = 10;
            this.AnimalsForWagon = animals;
        }
    }
}
