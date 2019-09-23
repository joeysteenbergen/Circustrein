using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Animal
    {
        public enum EatTypes
        {
            Carnivoor,
            Herbivoor
        }
        public EatTypes EatType;
        public int Size;

        public Animal(EatTypes eatType, int size)
        {
            this.EatType = eatType;
            this.Size = size;
        }
    }
}
