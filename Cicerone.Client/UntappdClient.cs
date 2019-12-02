using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Cicerone.Models;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serialization.Json;

namespace Cicerone.Client
{
	public class UntappdClient : IUntappdClient
	{
		private readonly IRestClient _client;

		public UntappdClient()
		{
			_client = new RestClient(Constants.BaseUrl)
			{
				Authenticator = new SimpleAuthenticator("client_id", Constants.ClientId, "client_secret", Constants.ClientSecret)
			};

			_client.UseSerializer(new JsonDeserializer());
		}

		public async Task<BeerInfo> GetBeerInfo(string beerId)
		{
			if (string.IsNullOrEmpty(beerId))
			{
				throw new ArgumentNullException(nameof(beerId));
			}

			var request = new RestRequest($"beer/info/{beerId}");
			var response = await _client.ExecuteGetTaskAsync(request);

			if (response.StatusCode != HttpStatusCode.OK)
			{
				throw new HttpRequestException(response.ErrorMessage);
			}

			try
			{
				return JsonConvert.DeserializeObject<BaseResponse<BeerInfoResponse>>(response.Content)?.Response?.BeerInfo;
			}
			catch (Exception e)
			{
				Console.WriteLine($"Error occurred when deserializing response: {e.Message}");
			}

			return null;
		}

		public async Task<BeerSearchResponse> SearchBeers(string query)
		{
			var request = new RestRequest($"search/beer");
			request.AddQueryParameter("q", query, encode: true);

			var response = await _client.ExecuteGetTaskAsync(request);

			if (response.StatusCode != HttpStatusCode.OK)
			{
				throw new HttpRequestException(response.ErrorMessage);
			}

			try
			{
				return JsonConvert.DeserializeObject<BaseResponse<BeerSearchResponse>>(response.Content)?.Response;
			}
			catch (Exception e)
			{
				Console.WriteLine($"Error occurred when deserializing response: {e.Message}");
			}

			return null;
		}
	}
}
