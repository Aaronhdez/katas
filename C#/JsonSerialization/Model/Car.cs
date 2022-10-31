using System;
using System.Collections.Generic;
using System.Text;

namespace JsonSerialization.Model {
    public class Car {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Model { get; set; }
        public List<Extra> Extras { get; set; }

        public object ImportingData = null;
    }
}
