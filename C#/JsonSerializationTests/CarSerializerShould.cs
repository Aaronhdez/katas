using NUnit.Framework;
using JsonSerialization;
using JsonSerialization.Model;

namespace JsonSerializationTests {
    public class CarSerializerShould {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void Get_the_name_of_a_car_when_JSON_is_passed() {
            string carAsJSON = @"{""Name"":""aCarName""}";
            CarSerializer serializer = new CarSerializer();
            Car dummyCar = serializer.Deserialize(carAsJSON);
            Assert.AreEqual("aCarName", dummyCar.Name);
        }
    }
}