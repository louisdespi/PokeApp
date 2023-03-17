using System.Text.Json.Serialization;

namespace PokeApp.Models
{
    public class Description
    {
        [JsonPropertyName("description")]
        public string Value { get; set; }
        [JsonPropertyName("language")]
        public ApiResource LanguageResource { get; set; }
    }
}
