﻿

namespace PokeApp.View;

public partial class MainPage : ContentPage
{
	PokemonsViewModel viewModel;
	public MainPage(PokemonsViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		BindingContext = viewModel;
	}

    protected override async void OnAppearing()
    {
		pokemonCollection.ItemsSource = viewModel.Pokemons;
		if (viewModel.FirstRun && viewModel.GetPokemonsCommand.CanExecute(null))
		{
			await viewModel.GetPokemonsCommand.ExecuteAsync(null);
			viewModel.FirstRun = false;
		}
        base.OnAppearing();
    }
}

