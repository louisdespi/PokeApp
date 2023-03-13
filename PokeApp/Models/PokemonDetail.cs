using System.Text.Json.Serialization;

namespace PokeApp.Models
{
    public class PokemonDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Sprites Sprites { get; set; }
        public PokemonSpecie Species { get; set; }
        //[JsonIgnore]
        public TypeContainer[] Types { get; set; }
        [JsonIgnore]
        public string FrenchName { get; set; }
    }
}
