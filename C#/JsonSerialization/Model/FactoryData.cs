using System;

namespace JsonSerialization.Model {
    public class FactoryData {
        public string FactoryID { get; set; }
        public string FactoryOwner { get; set; }
        public string Country { get; set; }
        public string CountryState { get; set; }
        public int ProductionLane { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime ReleaseDate { get; set; }

        public FactoryData(string factoryID, string factoryOwner, string country, string countryState, int productionLane, DateTime startingDate, DateTime releaseDate) {
            FactoryID = factoryID;
            FactoryOwner = factoryOwner;
            Country = country;
            CountryState = countryState;
            ProductionLane = productionLane;
            StartingDate = startingDate;
            ReleaseDate = releaseDate;
        }
    }
}