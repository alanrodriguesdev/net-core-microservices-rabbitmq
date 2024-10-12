using Newtonsoft.Json;

namespace Domain.Models
{
    public class Operations
    {
        [JsonProperty("operation")]
        public string? Operation { get; set; }
        [JsonProperty("unit-cost")]
        public decimal UnitCost { get; set; }
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}
