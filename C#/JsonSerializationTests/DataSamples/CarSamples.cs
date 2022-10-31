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
    }
}
