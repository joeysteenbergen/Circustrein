using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public enum EatType
    {
        Carnivoor,
        Herbivoor
    }
    public enum Size
    {
        One = 1,
        Three = 3,
        Five = 5
    }
    public class Animal
    {
        public EatType EatType;
        public Size Size;

        public Animal(EatType eatType, Size size)
        {
            this.EatType = eatType;
            this.Size = size;
        }
    }
}
