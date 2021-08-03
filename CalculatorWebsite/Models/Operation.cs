
namespace CalculatorWebSite.Models
{
    using System.Text.Json.Serialization;
    using System.Text.Json;

    public class Operation
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        public override string ToString() =>  JsonSerializer.Serialize<Operation>(this);
        
    }
}