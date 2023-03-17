namespace PokeApp.Models
{
    public class VersionGroup
    {
        public int Id { get; set; }
        public Pokedex[] Pokedexes { get; set; }
        public string Name { get; set; }
    }
}
