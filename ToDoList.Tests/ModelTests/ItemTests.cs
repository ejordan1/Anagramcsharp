using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ToDoList.Tests
{

    [TestClass]
    public class ItemTest : IDisposable
    {
        public string printStringList(List<string> list)
        {
            string str = "";
            for (int i = 0; i < list.Count - 1; i++)
            {
                str += list[i] + ", ";
            }
            str += list[list.Count - 1];
            return str;
        }
        public void Dispose()
        {
            Allergies.ClearAll();
        }

        [TestMethod]
        public void TestTest_CompareNums_Int()
        {
            Assert.AreEqual(2, 2);
        }

        [TestMethod]
        public void TestConstruct_ConstructionHas_Int()
        {
            Allergies cat = new Allergies("Cat", 2);
            Assert.AreEqual(cat._value, 2);
        }

        [TestMethod]
        public void TestConstruct_ListHas_NumberOfConstructs()
        {
            Allergies eggs = new Allergies("Eggs", 1);
            Allergies peanuts = new Allergies("Peanuts", 2);
            Allergies shellfish = new Allergies("Shellfish", 4);
            Allergies strawberries = new Allergies("Strawberries", 8);
            Allergies tomatoes = new Allergies("Tomatoes", 16);
            Allergies chocolate = new Allergies("Chocolate", 32);
            Allergies pollen = new Allergies("Pollen", 64);
            Allergies cats = new Allergies("Cats", 128);
            List<Allergies> allergies = new List<Allergies>() { eggs, peanuts, shellfish, strawberries, tomatoes, chocolate, pollen, cats };
            Allergies.allergens = Allergies.allergens.Concat(allergies).ToList();
            Assert.AreEqual(Allergies.allergens.Count, 8);
        }

        [TestMethod]
        public void TestConstruct_DisposableCalled_0()
        {
            Assert.AreEqual(Allergies.allergens.Count, 0);
        }


        [TestMethod]
        public void FindAllergensTest_MethodCallSuccess_List()
        {
            Allergies eggs = new Allergies("Eggs", 1);
            Allergies peanuts = new Allergies("Peanuts", 2);
            Allergies shellfish = new Allergies("Shellfish", 4);
            Allergies strawberries = new Allergies("Strawberries", 8);
            Allergies tomatoes = new Allergies("Tomatoes", 16);
            Allergies chocolate = new Allergies("Chocolate", 32);
            Allergies pollen = new Allergies("Pollen", 64);
            Allergies cats = new Allergies("Cats", 128);
            List<Allergies> allergies = new List<Allergies>() { eggs, peanuts, shellfish, strawberries, tomatoes, chocolate, pollen, cats };
            List<string> testListAllergens = new List<string>() { "Chocolate", "Strawberries" };
            Allergies.allergens = Allergies.allergens.Concat(allergies).ToList();
            Console.WriteLine(Allergies.FindAllergens(allergies, 40)[0]);
            Console.WriteLine(testListAllergens[0]);
            Console.WriteLine("List: " + printStringList(Allergies.FindAllergens(allergies, 40)));
            Console.WriteLine("List: " + printStringList(testListAllergens));
            Assert.AreEqual(printStringList(Allergies.FindAllergens(allergies, 40)), printStringList(testListAllergens));


        }
        // Test methods will go here.

    }
}