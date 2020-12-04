using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Week4_Challenge
{
    [TestClass]
    public class Week4Tests
    {
        [TestMethod]
        public void AnimalTests()
        {
            var animal = new FarmAnimals(true, 1000, "Cow", true, 4, 500);
            var duck = new FarmAnimals();
            duck.FarmWork = true;
            duck.AvgWeight = 20;
            duck.IsMammal = false;
            duck.NumLegs = 2;
            duck.Name = "Duck";
            
        }

        public void WildTest()
        {
            var wanimal = new WildAnimals(true, "Namibia", "Snake", false, 0, 5);
            var tiger = new WildAnimals();
            tiger.Name = "Tiger";
            tiger.IsMammal = true;
            tiger.NumLegs = 4;
            tiger.WillKillYou = true;
            tiger.CountryOfOrigin = "India";
            tiger.AvgWeight = 450;

        }
    }
}
