using System.Text.Json.Serialization;

namespace PokeApp.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public PokemonSpecie Specie { get; set; }
    }
}
