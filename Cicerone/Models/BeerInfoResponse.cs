using System;
using Newtonsoft.Json;

namespace Cicerone.Models
{
	public class BeerInfoResponse
	{
		[JsonProperty("beer")]
		public BeerInfo BeerInfo { get; set; }
	}
}
