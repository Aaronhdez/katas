using System;
using NUnit.Framework;
using JsonSerializationTests.DataSamples;
using JsonSerialization.Model;
using JsonSerialization.Model.DataCategories;
using JsonSerialization.Model.TechnicalDataFeatures;
using JsonSerialization.Model.Controllers;

namespace JsonSerializationTests {
    public class CarSerializerShould {

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

        [Test]
        public void Get_all_the_chassis_data_of_a_car_when_JSON_is_passed() {
            dummyCar = serializer.Deserialize(carAsJSON);
            Assert.AreEqual(dummyChassisData, dummyCar.ChassisData);
        }

        [Test]
        public void Get_all_the_bodywork_data_of_a_car_when_JSON_is_passed() {
            dummyCar = serializer.Deserialize(carAsJSON);
            Assert.AreEqual(dummyBodyworkData, dummyCar.BodyworkData);
        }

        [Test]
        public void Get_all_the_engine_data_of_a_car_when_JSON_is_passed() {
            dummyCar = serializer.Deserialize(carAsJSON);
            Assert.AreEqual(dummyEngineData, dummyCar.EngineData);
        }
    }
}