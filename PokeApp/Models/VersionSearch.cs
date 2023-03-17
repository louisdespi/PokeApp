using System.Text.Json.Serialization;

namespace PokeApp.Models
{
    public class VersionSearch
    {
        public int Count { get; set; }
        public List<ApiResource> Results { get; set; }
    }
}
