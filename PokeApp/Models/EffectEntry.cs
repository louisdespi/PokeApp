using System.Text.Json.Serialization;

namespace PokeApp.Models
{
    public class EffectEntry
    {
        public string Effect { get; set; }
        public ApiResource Language { get; set; }
        [JsonPropertyName("short_effect")]
        public string ShortEffect { get; set; }
    }
}
