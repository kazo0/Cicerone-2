using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cicerone.Models;

namespace Cicerone.Services.Untappd
{
	public interface IUntappdService
	{
		Task<List<Beer>> SearchBeer(string searchTerm);
		Task<BeerInfo> GetBeerInfo(string beerId);
	}
}
