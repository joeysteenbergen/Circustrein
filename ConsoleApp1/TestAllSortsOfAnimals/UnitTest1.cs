using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System.Collections.Generic;

namespace TestAllSortsOfAnimals
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            List<Animal> allAnimals = new List<Animal>();
            allAnimals.Add(new Animal(EatType.Carnivoor, Size.Five));
            allAnimals.Add(new Animal(EatType.Carnivoor, Size.Three));
            allAnimals.Add(new Animal(EatType.Carnivoor, Size.One));
            allAnimals.Add(new Animal(EatType.Herbivoor, Size.Five));
            allAnimals.Add(new Animal(EatType.Herbivoor, Size.Three));
            allAnimals.Add(new Animal(EatType.Herbivoor, Size.One));

            Train Train = new Train();
            Train.SortCargo(allAnimals);
            List<Wagon> actual = Train.GetAllWagons();

            Train.wagonList.Clear();

            Train.wagonList.Add(new Wagon(new List<Animal>() { allAnimals[0] }));
            Train.wagonList.Add(new Wagon(new List<Animal>() { allAnimals[1], allAnimals[3] }));
            Train.wagonList.Add(new Wagon(new List<Animal>() { allAnimals[2], allAnimals[4] }));
            Train.wagonList.Add(new Wagon(new List<Animal>() { allAnimals[5] }));
            List<Wagon> expected = Train.wagonList;


            CollectionAssert.AreEqual(expected, actual);
            //CollectionAssert.Equals(expectedTrain.wagonList, resultTrain.GetAllWagons());
        }
    }
}
