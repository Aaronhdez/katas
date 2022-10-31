using JsonSerialization.Model.DataCategories;
using JsonSerialization.Model.TechnicalDataFeatures;
using System;
using System.Collections.Generic;
using System.Text;

namespace JsonSerializationTests.DataSamples {
    public static class CarSamples {
        public static string carAsJSON = @"{""Name"":""aCarName"",
                            ""Id"":""aCarId"",
                            ""Model"":""aCarModel"",
                            ""Extras"": [
                                { ""Name"":""RadioCD"" },
                                { ""Name"":""USBPort"" }
                            ],
                            ""ImportingData"":{
                                ""ImportingID"":""anImportingID"",
                                ""Origin"":""anOrigin"",
                                ""Destination"":""aDestination"",
                                ""Provider"":""aProvider""
                            },
                            ""FactoryData"":{
                                ""FactoryID"":""aFactoryID"",
                                ""FactoryOwner"":""aFactoryOwner"",
                                ""Country"":""aFactoryCountry"",
                                ""CountryState"":""aFactoryCountryState"",
                                ""ProductionLane"":""1"",
                                ""StartingDate"":""1900-01-01"",
                                ""ReleaseDate"":""1900-01-02""
                            },
                            ""TechnicalData"":{
                                ""ChassisData"":{
                                    ""ChassisID"":""aChassisID"",
                                    ""ProducerID"":""aProducerID"",
                                    ""FactoryID"":""aFactoryID"",
                                    ""FactoryOwner"":""aFactoryOwner""
                                },
                                ""BodyworkData"":{
                                    ""BodyworkID"":""aBodyworkID"",
                                    ""ProducerID"":""aProducerID"",
                                    ""FactoryID"":""aFactoryID"",
                                    ""FactoryOwner"":""aFactoryOwner""
                                },
                                ""EngineData"":{
                                    ""EngineID"":""aEngineID"",
                                    ""ProducerID"":""aProducerID"",
                                    ""FactoryID"":""aFactoryID"",
                                    ""FactoryOwner"":""aFactoryOwner""
                                }
                            }
                        }";
        public static string carAsJSONNoExtras = @"{""Name"":""aCarName"",
                            ""Id"":""aCarId"",
                            ""Model"":""aCarModel"",
                            ""Extras"": [],
                            ""ImportingData"":{},
                            ""FactoryData"":{}
                        }";

        public static ImportingData dummyImportingData = new ImportingData(
                "anImportingID",
                "anOrigin",
                "aDestination",
                "aProvider");
        public static FactoryData dummyFactoryData = new FactoryData(
                "aFactoryID",
                "aFactoryOwner",
                "aFactoryCountry",
                "aFactoryCountryState",
                "1",
                new DateTime(1900,01,01),
                new DateTime(1900,01,02));
        public static ChassisData dummyChassisData = new ChassisData(
                "aChassisID",
                "aProducerID",
                "aFactoryID",
                "aFactoryOwner");
        public static BodyworkData dummyBodyworkData = new BodyworkData(
                "aBodyworkID",
                "aProducerID",
                "aFactoryID",
                "aFactoryOwner");
        public static EngineData dummyEngineData = new EngineData(
                "aEngineID",
                "aProducerID",
                "aFactoryID",
                "aFactoryOwner");
    }
}
