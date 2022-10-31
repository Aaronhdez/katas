using JsonSerialization.Model;
using System;
using System.Text.Json;

namespace JsonSerialization.Model.Controllers {
    public class CarSerializer {
        public Car Deserialize(string jsonObject) {
            if (jsonObject.Equals("{}")) return null;
            return JsonSerializer.Deserialize<Car>(jsonObject);
        }
        public object DeserializeToType(string jsonObject, Type typeToDeseralize) {
            if (jsonObject.Equals("{}")) return null;
            return JsonSerializer.Deserialize(jsonObject, typeToDeseralize);
        }
    }
}
