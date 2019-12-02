using System;
using System.Threading.Tasks;
using Cicerone.Models;

namespace Cicerone.Client
{
	public interface IUntappdClient
	{
		Task<BeerSearchResponse> SearchBeers(string query);

		Task<BeerInfo> GetBeerInfo(string beerId);
	}
}
