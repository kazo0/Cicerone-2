using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using Cicerone.Models;
using Cicerone.Services.Untappd;
using System.Windows.Input;

namespace Cicerone.ViewModels
{
	public class BeerSearchViewModel : BaseViewModel
	{
		private readonly IUntappdService _untappdService;

		public ObservableCollection<Beer> Beers { get; set; }
		public Beer SelectedBeer { get; set; }
		public ICommand SearchCommand { get; set; }
		public ICommand SelectBeerCommand { get; set; }

	 	public BeerSearchViewModel()
		{
			Title = "Search";
			Beers = new ObservableCollection<Beer>();

			_untappdService = new UntappdService();

			SearchCommand = new Command<string>(async (query) => await SearchBeer(query));
			SelectBeerCommand = new Command(async () => await NewMethod());
		}

		private async Task NewMethod()
		{
			await Shell.Current.GoToAsync($"beerDetails?beerId={SelectedBeer.Bid}&beerName={SelectedBeer.BeerName}");
		}

		private async Task SearchBeer(string query)
		{
			IsBusy = true;

			Beers.Clear();
			var beers = await _untappdService.SearchBeer(query);
			foreach (var beer in beers)
			{
				Beers.Add(beer);
			}

			IsBusy = false;
		}
	}
}