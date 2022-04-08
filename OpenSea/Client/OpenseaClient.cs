using FloorTracker.OpenSea.Models;
using Newtonsoft.Json;
using RestSharp;

namespace FloorTracker.OpenSea.Client
{
    /// <summary>
    /// Class that implements OpenSea APIs to obtain collections stats.
    /// https://docs.opensea.io/reference/api-overview
    /// </summary>
    public class OpenseaClient
    {
        /// <summary>
        /// OpenSea API endpoint.
        /// </summary>
        private readonly string _apiEndpoint = "https://api.opensea.io/api/v1";
        private string _apiKey = String.Empty;

        /// <summary>
        /// Default <see cref="OpenseaClient"/> constructor.
        /// </summary>
        /// <param name="requestUrl"></param>
        public OpenseaClient() { }
        /// <summary>
        /// <see cref="OpenseaClient"/> constructor.
        /// </summary>
        /// <param name="apiKey">OpenSea API key.</param>
        public OpenseaClient(string apiKey) => _apiKey = apiKey;

        /// <summary>
        /// Gets all given collection stats asynchronously as a JSON object.
        /// </summary>
        /// <param name="collectionSlug">The collection slug (ID).</param>
        /// <returns><see cref="RestResponse"/> containing the JSON object.</returns>
        private async Task<RestResponse> _GetCollectionStatsAsync(string collectionSlug)
        {
            using var client = new RestClient($"{_apiEndpoint}/collection/{collectionSlug}/stats");
            var request = new RestRequest();
            request.AddHeader("Accept", "application/json");
            return await client.ExecuteAsync(request);
        }

        /// <summary>
        /// Gets all given collection stats asynchronously.
        /// </summary>
        /// <param name="collectionSlug">The collection slug (ID).</param>
        /// <returns><see cref="CollectionStats"/> object.</returns>
        public async Task<CollectionStats.RootObject> GetCollectionStatsAsync(string collectionSlug)
        {
            RestResponse response = await _GetCollectionStatsAsync(collectionSlug);
            return JsonConvert.DeserializeObject<CollectionStats.RootObject>(response.Content);
        }
    }
}