using System.Text.Json.Serialization;

namespace PokeApp.Models
{
    public class Sprites
    {
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
    }
}
