using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Cicerone.Models
{
	public class Beers
	{
		[JsonProperty("count")]
		public int Count { get; set; }

		[JsonProperty("items")]
		public List<BeerItem> Items { get; set; } = new List<BeerItem>();
	}
}