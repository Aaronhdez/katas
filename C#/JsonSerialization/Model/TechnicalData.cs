namespace JsonSerialization.Model {
    public class TechnicalData {
        public ChassisData ChassisData { get; set; }
        public BodyworkData BodyworkData { get; set; }
    }

    public class ChassisData {
        public string ChassisID { get; set; }
        public string ProducerID { get; set; }
        public string FactoryID { get; set; }
        public string FactoryOwner { get; set; }

        public ChassisData() {
        }

        public ChassisData(string chassisID, string producerID, string factoryID, string factoryOwner) {
            ChassisID = chassisID;
            ProducerID = producerID;
            FactoryID = factoryID;
            FactoryOwner = factoryOwner;
        }

        public override bool Equals(object obj) {
            return obj is ChassisData data &&
                   ChassisID == data.ChassisID &&
                   ProducerID == data.ProducerID &&
                   FactoryID == data.FactoryID &&
                   FactoryOwner == data.FactoryOwner;
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }
    }

    public class BodyworkData {
        public string BodyworkID { get; set; }
        public string ProducerID { get; set; }
        public string FactoryID { get; set; }
        public string FactoryOwner { get; set; }

        public BodyworkData() {
        }

        public BodyworkData(string chassisID, string producerID, string factoryID, string factoryOwner) {
            BodyworkID = chassisID;
            ProducerID = producerID;
            FactoryID = factoryID;
            FactoryOwner = factoryOwner;
        }

        public override bool Equals(object obj) {
            return obj is BodyworkData data &&
                   BodyworkID == data.BodyworkID &&
                   ProducerID == data.ProducerID &&
                   FactoryID == data.FactoryID &&
                   FactoryOwner == data.FactoryOwner;
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }
    }
}