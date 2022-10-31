using JsonSerialization.Model;
using JsonSerialization.Model.Controllers;
using JsonSerialization.Model.DataCategories;
using JsonSerialization.Model.TechnicalDataFeatures;
using JsonSerializationTests.DataSamples;
using NUnit.Framework;

namespace JsonSerializationTests {
    class CarSerializerToTypeShould {
        private readonly string carAsJSON = CarSamples.carAsJSON;
        private readonly string carAsJSONNoExtras = CarSamples.carAsJSONNoExtras;
        private readonly ImportingData dummyImportingData = CarSamples.dummyImportingData;
        private readonly FactoryData dummyFactoryData = CarSamples.dummyFactoryData;
        private readonly ChassisData dummyChassisData = CarSamples.dummyChassisData;
        private readonly BodyworkData dummyBodyworkData = CarSamples.dummyBodyworkData;
        private readonly EngineData dummyEngineData = CarSamples.dummyEngineData;

        private CarSerializer serializer;
        private Car dummyCar;

        [SetUp]
        public void Setup() {
            serializer = new CarSerializer();
        }

        [Test]
        public void Deserialize_to_car_basic_type_when_specified() {
            Car dummyCar = (Car) serializer.DeserializeToType(carAsJSON, typeof(Car));
            Assert.AreEqual(dummyImportingData, dummyCar.ImportingData);
            Assert.AreEqual(dummyFactoryData, dummyCar.FactoryData);
            Assert.AreEqual(dummyChassisData, dummyCar.ChassisData);
            Assert.AreEqual(dummyBodyworkData, dummyCar.BodyworkData);
            Assert.AreEqual(dummyEngineData, dummyCar.EngineData);
        }
    }
}
