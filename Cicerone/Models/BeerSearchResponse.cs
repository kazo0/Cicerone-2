using System;
using Newtonsoft.Json;

namespace Cicerone.Models
{
	public class BeerSearchResponse
	{
		[JsonProperty("message")]
		public string Message { get; set; }

		[JsonProperty("brewery_id")]
		public bool BreweryId { get; set; }

		[JsonProperty("search_type")]
		public string SearchType { get; set; }

		[JsonProperty("type_id")]
		public int TypeId { get; set; }

		[JsonProperty("search_version")]
		public int SearchVersion { get; set; }

		[JsonProperty("found")]
		public int Found { get; set; }

		[JsonProperty("offset")]
		public int Offset { get; set; }

		[JsonProperty("limit")]
		public int Limit { get; set; }

		[JsonProperty("term")]
		public string Term { get; set; }

		[JsonProperty("parsed_term")]
		public string ParsedTerm { get; set; }

		[JsonProperty("beers")]
		public Beers Beers { get; set; }
	}
}
