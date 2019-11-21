using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Train
    {
        private List<Wagon> wagonList = new List<Wagon>();

        public Train(List<Animal> cargoList)
        {
            this.wagonList = SortCargo(cargoList);
        }

        public void GetWagons()
        {
            for(int i = 0; i < wagonList.Count(); i++)
            {
                Wagon wagon = wagonList[i];
                Console.WriteLine("Wagon " + (i + 1));
                for(int x = 0; x < wagon.animalsForWagon.Count(); x++)
                {
                    Console.WriteLine(wagon.animalsForWagon[x].eatType + " " + wagon.animalsForWagon[x].size);
                } 
            }
        }

        public List<Wagon> SortCargo(List<Animal> cargoToSort)
        {
            List<Wagon> FilledWagons = new List<Wagon>();

            foreach (Animal animal in cargoToSort)
            {
                if (animal.eatType != Animal.EatType.Carnivoor && FilledWagons != null && FilledWagons.Count() != 0 && FilledWagons.Count(z => z.capacityLeft != 0) != 0)
                {
                    foreach(Wagon wagon in FilledWagons)
                    {
                        Animal Carnivore = wagon.animalsForWagon.Find(z => z.eatType == Animal.EatType.Carnivoor);
                        if (animal != null && Carnivore != null && animal.size <= wagon.capacityLeft && Carnivore.size < animal.size)
                        {
                            wagon.animalsForWagon.Add(animal);
                        }
                        else if(animal != null && animal.size <= wagon.capacityLeft)
                        {
                            wagon.animalsForWagon.Add(animal);
                        }
                    }
                }
                else
                {
                    Wagon wagon = new Wagon(new List<Animal>());
                    wagon.animalsForWagon.Add(animal);
                    FilledWagons.Add(wagon);
                }
            }

            return FilledWagons;
        }
    }
}
