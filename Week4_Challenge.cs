using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Challenge
{
    abstract class Animals
    {
        public string Name { get; set; }
        public bool IsMammal { get; set; }
        public int NumLegs { get; set; }
        public int AvgWeight { get; set; }
        public Animals() { }
        public Animals(string name, bool isMammal, int numLegs, int avgWeight)
        {
            Name = name;
            IsMammal = isMammal;
            NumLegs = numLegs;
            AvgWeight = avgWeight;
        }
    }

    class FarmAnimals : Animals
    {
        public bool FarmWork { get; set; }
        public int YearDomesticated { get; set; }
        public FarmAnimals() { }
        public FarmAnimals(bool farmWork, int yearDomesticated, string name, bool isMammal, int numLegs, int avgWeight) : base (name, isMammal, numLegs, avgWeight)
        {
            FarmWork = farmWork;
            YearDomesticated = yearDomesticated;
        }
    }

    class WildAnimals : Animals
    {
        public bool WillKillYou { get; set; }
        public string CountryOfOrigin { get; set; }

        public WildAnimals() { }
        public WildAnimals(bool willKillYou, string countryOfOrigin, string name, bool isMammal, int numLegs, int avgWeight) : base (name, isMammal, numLegs, avgWeight)
        {
            WillKillYou = willKillYou;
            CountryOfOrigin = countryOfOrigin;
        }
    }
}
