




using System.Linq.Expressions;

namespace PokeApp.ViewModels
{ 
    public partial class PokemonsViewModel : BaseViewModel
    {
        private PokemonsService pokemonsService;

        public ObservableCollection<PokemonDetail> Pokemons { get; set; } = new();
        [ObservableProperty]
        bool isRefreshing;
        public bool FirstRun { get; set; } = true;
        public PokemonsViewModel(PokemonsService pokemonService)
        {
            Title = "Tous les pokemons";
            this.pokemonsService = pokemonService;
        }

        [RelayCommand]
        async Task GetPokemonsAsync()
        {
            if (IsBusy)
            { 
                return; 
            }
            try
            {
                IsBusy = true;
                IsRefreshing = true;
                Pokemons.Clear();

                for (int i = 0; i < 21; i++)
                {
                    PokemonDetail p = null;
                    do
                    {
                        p = await pokemonsService.GetPokemonDetailAsync(new Random().Next(1, 1010));
                    } while (p == null || Pokemons.Contains(p));
                    Pokemons.Add(p);
                }
            } 
            catch (Exception)
            {
                throw;
            }
            finally
            { 
                IsBusy = false;
                IsRefreshing = false;
            }
        }

        [RelayCommand]
        async Task GoToDetailsAsync(PokemonDetail pokemonDetail)
        {
            if (pokemonDetail is null)
            {
                return;
            }
            await Shell.Current.GoToAsync(nameof(PokemonDetailsPage), true, new Dictionary<string, object>
            {
                {"PokemonDetail", pokemonDetail}
            });
        }
    }
}
