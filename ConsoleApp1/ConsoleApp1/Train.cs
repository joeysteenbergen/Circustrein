using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Train
    {
        public List<Wagon> wagonList = new List<Wagon>();

        public Train()
        {
            
        }

        public void PrintWagonsList()
        {
            for(int i = 0; i < wagonList.Count(); i++)
            {
                Wagon wagon = wagonList[i];
                Console.WriteLine("Wagon " + (i + 1));
                for(int x = 0; x < wagon.animalsForWagon.Count(); x++)
                {
                    Console.WriteLine(wagon.animalsForWagon[x].EatType + " " + wagon.animalsForWagon[x].Size);
                } 
            }
        }

        public void SortCargo(List<Animal> cargoToSort)
        {
            List<Animal> sortedCargo = cargoToSort.OrderBy(x => x.EatType).ThenByDescending(x => x.Size).ToList();
            foreach (Animal animal in sortedCargo)
            {
                if (animal.EatType != EatType.Carnivoor && this.wagonList != null && this.wagonList.Count() != 0 && this.wagonList.Count(z => z.capacityLeft != 0) != 0)
                {
                    Wagon availableWagon = this.wagonList.Find(x => x.animalsForWagon.Exists(z => (int)z.Size < (int)animal.Size) && (int)animal.Size <= x.capacityLeft);
                    Wagon wagonWithoutCarnivores = this.wagonList.Find(x => !x.animalsForWagon.Exists(z => z.EatType == EatType.Carnivoor) && (int)animal.Size <= x.capacityLeft);

                    if (availableWagon != null)
                    {
                        availableWagon.animalsForWagon.Add(animal);
                        availableWagon.capacityLeft -= (int)animal.Size;
                    }

                    else if(wagonWithoutCarnivores != null)
                    {
                        wagonWithoutCarnivores.animalsForWagon.Add(animal);
                        wagonWithoutCarnivores.capacityLeft -= (int)animal.Size;
                    }

                    else
                    {
                        Wagon wagon = new Wagon(new List<Animal>());
                        wagon.animalsForWagon.Add(animal);
                        wagon.capacityLeft -= (int)animal.Size;
                        this.wagonList.Add(wagon);
                    }
                }
                else
                {
                    Wagon wagon = new Wagon(new List<Animal>());
                    wagon.animalsForWagon.Add(animal);
                    wagon.capacityLeft -= (int)animal.Size;
                    this.wagonList.Add(wagon);
                }
            }
        }
        public List<Wagon> GetAllWagons()
        {
            return wagonList;
        }
    }
}
