




using System.Linq.Expressions;

namespace PokeApp.ViewModels
{ 
    public partial class VersionViewModel : BaseViewModel
    {
        private PokemonsService pokemonsService;

        public ObservableCollection<PokeApp.Models.Version> Versions { get; set; } = new();
        [ObservableProperty]
        bool isRefreshing;
        public bool FirstRun { get; set; } = true;
        public VersionViewModel(PokemonsService pokemonService)
        {
            Title = "Toutes les versions";
            this.pokemonsService = pokemonService;
        }

        [RelayCommand]
        async Task GetVersionsAsync()
        {
            if (IsBusy)
            { 
                return; 
            }
            try
            {
                IsBusy = true;
                IsRefreshing = true;
                Versions.Clear();
                List<PokeApp.Models.Version> versions = await pokemonsService.GetAllVersionsAsync();
                foreach (var version in versions)
                {
                    Versions.Add(version);
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

        /*[RelayCommand]
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
        }*/
    }
}
