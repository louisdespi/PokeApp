using System.Text.Json.Serialization;

namespace PokeApp.Models
{
    public class EffectEntryPokemon
    {
        [JsonPropertyName("is_hidden")]
        public bool IsHidden { get; set; }
        public ApiResource Pokemon { get; set; }
        public int Slot { get; set; }
    }
}
