namespace JsonSerialization.Model {
    public class ImportingData {
        public string ImportingID { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string Provider { get; set; }

        public ImportingData() {
        }

        public ImportingData(string importingID, string origin, string destination, string provider) {
            ImportingID = importingID;
            Origin = origin;
            Destination = destination;
            Provider = provider;
        }

        public override bool Equals(object obj) {
            return obj is ImportingData data &&
                   ImportingID == data.ImportingID &&
                   Origin == data.Origin &&
                   Destination == data.Destination &&
                   Provider == data.Provider;
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }
    }
}