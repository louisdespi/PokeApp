using System.Text.Json.Serialization;

namespace PokeApp.Models
{
    public class Pokedex
    {
        public Description Description { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public Translation[] Names { get; set; }
        [JsonPropertyName("pokemon_entries")]
        public PokemonEntry[] PokemonEntries { get; set; }  
    }
}
