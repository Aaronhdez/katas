using JsonSerialization.Model.DataCategories;
using JsonSerialization.Model.TechnicalDataFeatures;

namespace JsonSerialization.Model.DataStructures {
    public class CarTechnical {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Model { get; set; }
        public TechnicalData TechnicalData { get; set; }
        public ChassisData ChassisData { get => TechnicalData.ChassisData; set => TechnicalData.ChassisData = value; }
        public BodyworkData BodyworkData { get => TechnicalData.BodyworkData; set => TechnicalData.BodyworkData = value; }
        public EngineData EngineData { get => TechnicalData.EngineData; set => TechnicalData.EngineData = value; }
    }
}
