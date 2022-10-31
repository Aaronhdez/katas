using System;
using System.Collections.Generic;
using System.Text;

namespace JsonSerialization.Model {
    public class Car {

        public string Name { get; set; }
        public string Id { get; set; }
        public string Model { get; set; }
        public List<Extra> Extras { get; set; }
        public ImportingData ImportingData { get; set; }
        public FactoryData FactoryData { get; set; }
        public TechnicalData TechnicalData { get; set; }
        public ChassisData ChassisData { get => TechnicalData.ChassisData; set => TechnicalData.ChassisData = value; }
        public BodyworkData BodyworkData { get => TechnicalData.BodyworkData; set => TechnicalData.BodyworkData = value; }

    }
}
