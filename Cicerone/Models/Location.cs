using System;
using Newtonsoft.Json;

namespace Cicerone.Models
{
	public class Location
	{
		[JsonProperty("brewery_city")]
		public string BreweryCity { get; set; }

		[JsonProperty("brewery_state")]
		public string BreweryState { get; set; }

		[JsonProperty("lat")]
		public double Lat { get; set; }

		[JsonProperty("lng")]
		public double Lng { get; set; }
	}
}
