using System;
using System.Threading.Tasks;
using Cicerone.Models;
using Cicerone.Services.Untappd;

namespace Cicerone.ViewModels
{
	public class BeerDetailViewModel : BaseViewModel
	{
		private string _beerId;
		private IUntappdService _untappdService;

		private BeerInfo _beerInfo;

		private string _labelUrl;
		public string LabelUrl {
			get => _labelUrl;
			set => SetProperty(ref _labelUrl, value);
		}

		private string _description;
		public string Description
		{
			get => _description;
			set => SetProperty(ref _description, value);
		}

		public BeerDetailViewModel()
		{
			_untappdService = new UntappdService();
		}

		public async Task Init(string beerId)
		{
			_beerId = beerId;

			IsBusy = true;
			_beerInfo = await _untappdService.GetBeerInfo(_beerId);
			IsBusy = false;

			LabelUrl = _beerInfo.BeerLabelHd ?? _beerInfo.BeerLabel;
			Description = _beerInfo.BeerDescription;
		}
	}
}
