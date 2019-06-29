using System;
using Newtonsoft.Json;

namespace Cicerone.Models
{
	public class Brewery
	{
		[JsonProperty("brewery_id")]
		public int BreweryId { get; set; }

		[JsonProperty("brewery_name")]
		public string BreweryName { get; set; }

		[JsonProperty("brewery_slug")]
		public string BrewerySlug { get; set; }

		[JsonProperty("brewery_label")]
		public string BreweryLabel { get; set; }

		[JsonProperty("country_name")]
		public string CountryName { get; set; }

		[JsonProperty("contact")]
		public Contact Contact { get; set; }

		[JsonProperty("location")]
		public Location Location { get; set; }

		[JsonProperty("brewery_active")]
		public int BreweryActive { get; set; }
	}
}
