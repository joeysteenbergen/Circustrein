using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Dock
    {
        public List<Animal> Sort(List<Animal> animals)
        {
            List<Animal> sortedAnimals = animals.OrderBy(x => x.EatType).ThenByDescending(x => x.Size).ToList();
            return sortedAnimals;
        }

        public List<Wagon> FillWagons(List<Animal> animals)
        {
            List<Wagon> allWagons = new List<Wagon>();
            List<Animal> manifest = Sort(animals);

           foreach(Animal animal in manifest)
           {
                if(allWagons != null && animal.EatType != Animal.EatTypes.Carnivoor && Fits(allWagons, animal))
                {
                    FitAnimalIntoWagon(allWagons, animal);
                }
                else
                {
                    Wagon wagon = new Wagon(new List<Animal>());
                    wagon.AnimalsForWagon.Add(animal);
                    wagon.PointsLeft -= animal.Size;
                    allWagons.Add(wagon);
                }
           }

           return allWagons;
        }

        public bool Fits(List<Wagon> wagons, Animal animal)
        {
            bool Fits = false;

            foreach (Wagon wagon in wagons)
            {
                Animal Carnivore = wagon.AnimalsForWagon.Find(z => z.EatType == Animal.EatTypes.Carnivoor);
                if (animal != null && Carnivore != null && Carnivore.Size < animal.Size && wagon.PointsLeft >= animal.Size)
                {
                    Fits = true;
                }
                else if (animal != null && Carnivore == null && wagon.PointsLeft >= animal.Size)
                {
                    Fits = true;
                }
                else
                {
                    Fits = false;
                }
            }

            return Fits;
        }

        public void FitAnimalIntoWagon(List<Wagon> wagons, Animal selectedAnimal)
        {
            foreach (Wagon wagon in wagons)
            {
                Animal Carnivore = wagon.AnimalsForWagon.Find(z => z.EatType == Animal.EatTypes.Carnivoor);
                if (selectedAnimal != null && Carnivore != null  && selectedAnimal.Size <= wagon.PointsLeft && Carnivore.Size < selectedAnimal.Size)
                {
                    wagon.AnimalsForWagon.Add(selectedAnimal);
                    wagon.PointsLeft -= selectedAnimal.Size;
                    selectedAnimal = null;
                }
                else if(Carnivore == null && selectedAnimal.Size <= wagon.PointsLeft)
                {
                    wagon.AnimalsForWagon.Add(selectedAnimal);
                    wagon.PointsLeft -= selectedAnimal.Size;
                    selectedAnimal = null;
                }
            }
        }
    }
}
