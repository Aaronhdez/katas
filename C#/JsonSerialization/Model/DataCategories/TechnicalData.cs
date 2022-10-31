using JsonSerialization.Model.TechnicalDataFeatures;

namespace JsonSerialization.Model.DataCategories {
    public class TechnicalData {
        public ChassisData ChassisData { get; set; }
        public BodyworkData BodyworkData { get; set; }
        public EngineData EngineData { get; set; }
    }
}