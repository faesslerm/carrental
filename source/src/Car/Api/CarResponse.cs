using System.Text.Json.Serialization;

namespace CarRent.Car.Api
{
    public class CarResponse
    {
        [JsonPropertyOrder(100)]
        public Guid Id { get; set; }

        [JsonPropertyOrder(200)]
        [JsonPropertyName("car-number")]
        public string CarNumber { get; set; }

        [JsonPropertyOrder(300)]
        public string Brand { get; set; }

        [JsonPropertyOrder(400)]
        public string CarClass { get; set; }

        [JsonPropertyOrder(500)]
        public string Type { get; set; }
    }
}
