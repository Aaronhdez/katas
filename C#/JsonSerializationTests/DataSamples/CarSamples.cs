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
                            }
                        }";
        public static string carAsJSONNoExtras = @"{""Name"":""aCarName"",
                            ""Id"":""aCarId"",
                            ""Model"":""aCarModel"",
                            ""Extras"": []
                        }";
    }
}
