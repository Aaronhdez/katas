using NUnit.Framework;
using JsonSerialization;
using JsonSerialization.Model;
using JsonSerializationTests.DataSamples;
using System;

namespace JsonSerializationTests {
    public class CarSerializerShould {

        private string carAsJSON = CarSamples.carAsJSON;
        private string carAsJSONNoExtras = CarSamples.carAsJSONNoExtras;

        private CarSerializer serializer;
        private Car dummyCar;
        private ImportingData dummyImportingData;
        private FactoryData dummyFactoryData;

        [SetUp]
        public void Setup() {
            serializer = new CarSerializer();
            dummyImportingData = new ImportingData(
                "anImportingID", 
                "anOrigin", 
                "aDestination", 
                "aProvider");
            dummyFactoryData = new FactoryData(
                "aFactoryID",
                "aFactoryOwner",
                "FactoryCountry",
                "aFactoryCountryState",
                1,
                new DateTime(1900 - 01 - 01),
                new DateTime(1900 - 01 - 02)
                );
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
            dummyCar = serializer.Deserialize(carAsJSON);
            Assert.NotNull(dummyCar.ImportingData);
        }

        [Test]
        public void Get_all_the_importing_data_of_a_car_when_JSON_is_passed() {
            dummyCar = serializer.Deserialize(carAsJSON);
            Assert.AreEqual(dummyImportingData, dummyCar.ImportingData);
        }

        [Test]
        public void Get_all_the_factory_data_of_a_car_when_JSON_is_passed() {
            dummyCar = serializer.Deserialize(carAsJSON);
            Assert.AreEqual(dummyFactoryData, dummyCar.FactoryData);
        }
    }
}