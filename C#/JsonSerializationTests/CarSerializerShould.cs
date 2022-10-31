using NUnit.Framework;
using JsonSerialization;
using JsonSerialization.Model;

namespace JsonSerializationTests {
    public class CarSerializerShould {

        private CarSerializer serializer;
        private Car dummyCar;

        const string carAsJSON = @"{""Name"":""aCarName"",
                            ""Id"":""aCarId"",
                            ""Model"":""aCarModel"",
                            ""Extras"": [
                                { ""Name"":""RadioCD"" },
                                { ""Name"":""USBPort"" }
                            ],
                            ""ImportingData"":{
                                ""ImportingID"":""anImportingID"",
                                ""Origin"":""anOrigin"",
                                ""Destination"":""anOrigin"",
                                ""Provider"":""aProvider""
                            }
                        }";
        const string carAsJSONNoExtras = @"{""Name"":""aCarName"",
                            ""Id"":""aCarId"",
                            ""Model"":""aCarModel"",
                            ""Extras"": []
                        }";

        [SetUp]
        public void Setup() {
            serializer = new CarSerializer();
        }

        [Test]
        public void Get_null_when_empty_JSON_is_passed() {
            string emptyCar = @"{}";
            dummyCar = serializer.Deserialize(emptyCar);
            Assert.AreEqual(null, dummyCar);
        }

        [Test]
        public void Get_the_name_of_a_car_when_JSON_is_passed() {
            dummyCar = serializer.Deserialize(carAsJSON);
            Assert.AreEqual("aCarName", dummyCar.Name);
        }

        [Test]
        public void Get_the_id_of_a_car_when_JSON_is_passed() {
            dummyCar = serializer.Deserialize(carAsJSON);
            Assert.AreEqual("aCarId", dummyCar.Id);
        }

        [Test]
        public void Get_the_model_of_a_car_when_JSON_is_passed() {
            dummyCar = serializer.Deserialize(carAsJSON);
            Assert.AreEqual("aCarModel", dummyCar.Model);
        }

        [Test]
        public void Get_the_extras_of_a_car_when_JSON_is_passed() {
            dummyCar = serializer.Deserialize(carAsJSON);
            Assert.AreEqual("USBPort", dummyCar.Extras[1].Name);
        }

        [Test]
        public void Get_no_extras_of_a_car_when_JSON_is_passed_without_extras() {
            dummyCar = serializer.Deserialize(carAsJSONNoExtras);
            Assert.AreEqual(0, dummyCar.Extras.Count);
        }

        [Test]
        public void Get_the_ImportingData_of_a_car_when_JSON_is_passed() {
            dummyCar = serializer.Deserialize(carAsJSONNoExtras);
            Assert.NotNull(dummyCar.ImportingData);
        }
    }
}