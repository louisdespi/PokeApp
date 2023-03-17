using System.Text.Json.Serialization;

namespace PokeApp.Models
{
    public class Ability
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonPropertyName("is_main_series")]
        public bool IsMainSeries { get; set; } //Whether or not this ability originated in the main series of the video games.
        [JsonPropertyName("generation")]
        public ApiResource R_Generation { get; set; } //The generation this ability originated in.
        public Translation[] Names { get; set; }
        [JsonPropertyName("effect_entries")]
        public EffectEntry[] EffectEntries { get; set; }
        [JsonPropertyName("pokemon")]
        public EffectEntryPokemon[] Pokemons { get; set; }
    }
}
