using NUnit.Framework;
using JsonSerialization;
using JsonSerialization.Model;

namespace JsonSerializationTests {
    public class CarSerializerShould {
        private CarSerializer serializer;
        private string carAsJSON;
        private Car dummyCar;

        [SetUp]
        public void Setup() {
            serializer = new CarSerializer();
        }

        [Test]
        public void Get_null_when_empty_JSON_is_passed() {
            carAsJSON = @"{}";
            dummyCar = serializer.Deserialize(carAsJSON);
            Assert.AreEqual(null, dummyCar);
        }

        [Test]
        public void Get_the_name_of_a_car_when_JSON_is_passed() {
            carAsJSON = @"{""Name"":""aCarName""}";
            dummyCar = serializer.Deserialize(carAsJSON);
            Assert.AreEqual("aCarName", dummyCar.Name);
        }

        [Test]
        public void Get_the_id_of_a_car_when_JSON_is_passed() {
            carAsJSON = @"{""Name"":""aCarName"",
                            ""Id"":""aCarId""}";
            dummyCar = serializer.Deserialize(carAsJSON);
            Assert.AreEqual("aCarName", dummyCar.Id);
        }
    }
}