using System;
using Newtonsoft.Json;

namespace Cicerone.Models
{
	public class Contact
	{
		[JsonProperty("twitter")]
		public string Twitter { get; set; }

		[JsonProperty("facebook")]
		public string Facebook { get; set; }

		[JsonProperty("instagram")]
		public string Instagram { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }
	}
}
