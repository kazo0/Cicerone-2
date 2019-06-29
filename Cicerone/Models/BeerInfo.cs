using System;
using Newtonsoft.Json;

namespace Cicerone.Models
{
	public class BeerInfo
	{
		[JsonProperty("bid")]
		public int Bid { get; set; }

		[JsonProperty("beer_name")]
		public string BeerName { get; set; }

		[JsonProperty("beer_label")]
		public string BeerLabel { get; set; }

		[JsonProperty("beer_label_hd")]
		public string BeerLabelHd { get; set; }

		[JsonProperty("beer_abv")]
		public double BeerAbv { get; set; }

		[JsonProperty("beer_ibu")]
		public int BeerIbu { get; set; }

		[JsonProperty("beer_description")]
		public string BeerDescription { get; set; }

		[JsonProperty("beer_style")]
		public string BeerStyle { get; set; }

		[JsonProperty("is_in_production")]
		public int IsInProduction { get; set; }

		[JsonProperty("beer_slug")]
		public string BeerSlug { get; set; }

		[JsonProperty("is_homebrew")]
		public int IsHomebrew { get; set; }

		[JsonProperty("created_at")]
		public string CreatedAt { get; set; }

		[JsonProperty("rating_count")]
		public int RatingCount { get; set; }

		[JsonProperty("rating_score")]
		public double RatingScore { get; set; }

		[JsonProperty("brewery")]
		public Brewery Brewery { get; set; }

		[JsonProperty("auth_rating")]
		public double AuthRating { get; set; }

		[JsonProperty("wish_list")]
		public bool WishList { get; set; }
	}
}
