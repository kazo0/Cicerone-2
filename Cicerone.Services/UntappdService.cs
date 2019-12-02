using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cicerone.Client;
using Cicerone.Models;

namespace Cicerone.Services.Untappd
{
	public interface IUntappdService
	{
		Task<List<Beer>> SearchBeer(string searchTerm);
		Task<BeerInfo> GetBeerInfo(string beerId);
	}

	public class UntappdService : IUntappdService
	{
		private readonly IUntappdClient _untappedClient;

		public UntappdService()
		{
			_untappedClient = new UntappdClient();
		}

		public async Task<List<Beer>> SearchBeer(string searchTerm)
		{
			var searchResponse = await _untappedClient.SearchBeers(searchTerm);

			return searchResponse?.Beers?.Items
				.Select(b => b.Beer)
				.ToList() ?? Enumerable.Empty<Beer>().ToList();
		}

		public async Task<BeerInfo> GetBeerInfo(string beerId)
		{
			return await _untappedClient.GetBeerInfo(beerId);
		}
	}
}
