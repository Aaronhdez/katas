using JsonSerialization.Model.DataCategories;
using System.Collections.Generic;

namespace JsonSerialization.Model.DataStructures {
    public class CarImporting {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Model { get; set; }
        public List<Extra> Extras { get; set; }
        public ImportingData ImportingData { get; set; }
    }
}
