using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Animal
    {
        public enum EatType
        {
            Carnivoor,
            Herbivoor
        }
        public EatType eatType;
        public int size;

        public Animal(EatType eatType, int size)
        {
            this.eatType = eatType;
            this.size = size;
        }
    }
}
