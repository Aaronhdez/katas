using JsonSerialization.Model;
using System.Text.Json;
using System;

namespace JsonSerialization {
    public class CarSerializer {
        public Car Deserialize(string jsonObject) {
            return JsonSerializer.Deserialize<Car>(jsonObject);
        }
    }
}
