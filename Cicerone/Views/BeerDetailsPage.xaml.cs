using System;
using System.Collections.Generic;
using Cicerone.ViewModels;
using Xamarin.Forms;

namespace Cicerone.Views
{
	[QueryProperty("BeerId", "beerId")]
	[QueryProperty("BeerName", "beerName")]

	public partial class BeerDetailsPage : ContentPage
	{
		private BeerDetailViewModel _viewModel;

		public string BeerId { get; set; }

		private string _beerName;
		public string BeerName
		{
			get => _beerName;
			set => _beerName = Title = Uri.UnescapeDataString(value);
		}

		public BeerDetailsPage()
		{
			InitializeComponent();
			BindingContext = _viewModel = new BeerDetailViewModel();
		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();

			await _viewModel.Init(BeerId);
		}
	}
}
