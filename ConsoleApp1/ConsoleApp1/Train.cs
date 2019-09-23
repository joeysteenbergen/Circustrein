using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Train
    {
        List<Wagon> wagonList = new List<Wagon>();

        public void GetWagons(List<Animal> animalsToAdd)
        {
            Dock dock = new Dock();
            this.wagonList = dock.FillWagons(animalsToAdd);
        }
    }
}
