using System;
using Newtonsoft.Json;

namespace Cicerone.Models
{
	public class BeerItem
	{
		[JsonProperty("checkin_count")]
		public int CheckinCount { get; set; }

		[JsonProperty("have_had")]
		public bool HaveHad { get; set; }

		[JsonProperty("your_count")]
		public int YourCount { get; set; }

		[JsonProperty("beer")]
		public Beer Beer { get; set; }

		[JsonProperty("brewery")]
		public Brewery Brewery { get; set; }
	}
}
