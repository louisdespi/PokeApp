namespace PokeApp.View;

public partial class PokemonDetailsPage : ContentPage
{
	public PokemonDetailsPage(PokemonDetailsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}