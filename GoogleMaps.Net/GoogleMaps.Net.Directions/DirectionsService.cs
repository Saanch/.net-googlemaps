using System.Collections.Specialized;
using System.Threading.Tasks;
using GoogleMaps.Net.Directions.Response;
using GoogleMaps.Net.Shared;
using GoogleMaps.Net.Shared.Contracts;

namespace GoogleMaps.Net.Directions
{
    public class DirectionsService : IDirectionsService
    {
        private readonly IWebApi _webApi;

        public DirectionsService(IWebApi webApi)
        {
            _webApi = webApi;
        }

        public async Task<DirectionResponse> GetDirection(string origin, string destination)
        {
            var queryParams = new NameValueCollection { { "origin", origin }, { "destination", destination } };
            return await _webApi.GetAsync<DirectionResponse>(EndPointUris.Directions, queryParams);
        } 
    }
}