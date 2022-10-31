namespace JsonSerialization.Model.TechnicalDataFeatures {
    public class EngineData {
        public string EngineID { get; set; }
        public string ProducerID { get; set; }
        public string FactoryID { get; set; }
        public string FactoryOwner { get; set; }

        public EngineData() {
        }

        public EngineData(string chassisID, string producerID, string factoryID, string factoryOwner) {
            EngineID = chassisID;
            ProducerID = producerID;
            FactoryID = factoryID;
            FactoryOwner = factoryOwner;
        }

        public override bool Equals(object obj) {
            return obj is EngineData data &&
                   EngineID == data.EngineID &&
                   ProducerID == data.ProducerID &&
                   FactoryID == data.FactoryID &&
                   FactoryOwner == data.FactoryOwner;
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }
    }
}