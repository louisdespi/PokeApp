using System.Text.Json.Serialization;

namespace PokeApp.Models
{
    public class PokemonVariety
    {
        [JsonPropertyName("pokemon")]
        public ApiResource PokemonResource { get; set; }
        [JsonIgnore]
        public Pokemon Pokemon { get; set; }
        [JsonPropertyName("is_default")]
        public bool IsDefault { get; set; }
    }
}
