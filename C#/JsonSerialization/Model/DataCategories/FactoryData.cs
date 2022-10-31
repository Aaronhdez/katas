using System;

namespace JsonSerialization.Model.DataCategories {
    public class FactoryData {
        public string FactoryID { get; set; }
        public string FactoryOwner { get; set; }
        public string Country { get; set; }
        public string CountryState { get; set; }
        public string ProductionLane { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime ReleaseDate { get; set; }

        public FactoryData() {
        }

        public FactoryData(string factoryID, string factoryOwner, string country, string countryState, string productionLane, DateTime startingDate, DateTime releaseDate) {
            FactoryID = factoryID;
            FactoryOwner = factoryOwner;
            Country = country;
            CountryState = countryState;
            ProductionLane = productionLane;
            StartingDate = startingDate;
            ReleaseDate = releaseDate;
        }

        public override bool Equals(object obj) {
            return obj is FactoryData data &&
                   FactoryID == data.FactoryID &&
                   FactoryOwner == data.FactoryOwner &&
                   Country == data.Country &&
                   CountryState == data.CountryState &&
                   ProductionLane == data.ProductionLane &&
                   StartingDate == data.StartingDate &&
                   ReleaseDate == data.ReleaseDate;
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }
    }
}