using Org.Apache.Http.Protocol;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;

namespace PokeApp.Services
{
    public class PokemonsService
    {
        const string BASE_SEARCH_URL = "https://pokeapi.co/api/v2/";
        HttpClient client;
        public PokemonsService()
        {
            this.client = new();
        }
        public async Task<List<PokeApp.Models.Version>> GetAllVersionsAsync()
        {
            HttpResponseMessage initResponse = await client.GetAsync($"{BASE_SEARCH_URL}/Version");
            if (initResponse.IsSuccessStatusCode)
            {
                VersionSearch initMessage = (await initResponse.Content.ReadFromJsonAsync<VersionSearch>());
                HttpResponseMessage response = await client.GetAsync($"{BASE_SEARCH_URL}/Version?offset=0&limit={initMessage.Count}");
                if (response.IsSuccessStatusCode)
                {
                    VersionSearch allVersionsMessage = (await initResponse.Content.ReadFromJsonAsync<VersionSearch>());
                    List<PokeApp.Models.Version> versions = new List<PokeApp.Models.Version>();
                    for (int i = 0; i < allVersionsMessage.Results.Count; i++)
                    { 
                        HttpResponseMessage targetResponse = await client.GetAsync(allVersionsMessage.Results[i].Url);
                        versions.Add(await targetResponse.Content.ReadFromJsonAsync<PokeApp.Models.Version>());
                    }
                    return versions;
                }
            }
            return null;
        }
        /*public async Task<List<PokemonDetail>> GetRandomPokemonsAsync()
        {
            var offset = new Random().Next(1, 900);
            var url = $"{BASE_SEARCH_URL}?limit=10&offset={offset}";
            var response = await client.GetAsync(url);
            var pokemons = await GetPokemonsAsync(response);
            return pokemons;
        }
        public async Task<PokemonDetail> GetPokemonDetailAsync(int id)
        {
            var response = await client.GetAsync($"{BASE_SEARCH_URL}/pokemon/{id}");
            PokemonDetail details = null;
            if (response.IsSuccessStatusCode)
            {
                details = (await response.Content.ReadFromJsonAsync<PokemonDetail>());
                PokemonSpecieDetail sD = await GetPokemonSpecieDetailAsync(details.Species.Url);
                details.FrenchName = sD.Names[4].Name;
            }
            return details;
        }

        private async Task<List<PokemonDetail>> GetPokemonsAsync(HttpResponseMessage response)
        {
            List<PokemonDetail> ret = new();

            if (response.IsSuccessStatusCode)
            {
                List<Pokemon> pokemons = (await response.Content.ReadFromJsonAsync<Pokemons>()).Results;
                for (int i = 0; i < pokemons.Count - 1; i++)
                {
                    var pokemonDetails = await GetPokemonDetailAsync(pokemons[i].Url);
                    if (pokemonDetails != null)
                    {
                        ret.Add(pokemonDetails);
                    }
                }
            }
            return ret;
        }

        private async Task<PokemonDetail> GetPokemonDetailAsync(string url)
        {
            var response = await client.GetAsync(url);
            PokemonDetail details = null;
            if (response.IsSuccessStatusCode)
            {
                details = (await response.Content.ReadFromJsonAsync<PokemonDetail>());
            }
            return details;
        }
        private async Task<PokemonSpecieDetail> GetPokemonSpecieDetailAsync(string url)
        {
            var response = await client.GetAsync(url);
            PokemonSpecieDetail details = null;
            if (response.IsSuccessStatusCode)
            {
                details = (await response.Content.ReadFromJsonAsync<PokemonSpecieDetail>());
            }
            return details;
        }*/
    }
}
