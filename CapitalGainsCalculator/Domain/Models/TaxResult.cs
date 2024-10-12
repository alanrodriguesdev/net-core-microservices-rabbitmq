using Newtonsoft.Json;

namespace Domain.Models
{
    public class TaxResult
    {
        [JsonProperty("tax")]
        public decimal Tax { get; set; } = 0.00m;
    }
}
