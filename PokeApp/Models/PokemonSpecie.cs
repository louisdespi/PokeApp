using System.Text.Json.Serialization;

namespace PokeApp.Models
{
    public class PokemonSpecie
    {
        [JsonPropertyName("evolution_chain")]
        public ApiResource EvolutionChainResource { get; set; }
        [JsonIgnore]
        public EvolutionChain EvolutionChain { get; set; }
        public Translation[] Names { get; set; }
        public 
    }
}
