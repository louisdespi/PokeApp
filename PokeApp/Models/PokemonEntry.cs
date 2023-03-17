﻿using System.Text.Json.Serialization;

namespace PokeApp.Models
{
    public class PokemonEntry
    {
        [JsonPropertyName("entry_number")]
        public int EntryNumber { get; set; }
        [JsonPropertyName("pokemon_species")]
        public ApiResource PokemonSpecieResource { get; set; }
        [JsonIgnore]
        public PokemonSpecie PokemonSpecie { get; set; }
    }
}
