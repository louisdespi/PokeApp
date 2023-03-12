namespace PokeApp.ViewModels
{
    [QueryProperty("PokemonDetail", "PokemonDetail")]
    public partial class PokemonDetailsViewModel : BaseViewModel
    {
        [ObservableProperty]
        PokemonDetail pokemonDetail;
    }
}
