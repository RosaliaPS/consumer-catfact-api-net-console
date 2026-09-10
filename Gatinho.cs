using System.Text.Json.Serialization;

namespace ConsumerCatFactApi
{
    public class Gatinho
    {
        [JsonPropertyName("fact")]
        public string Fact { get; set; } = "";
    }
}