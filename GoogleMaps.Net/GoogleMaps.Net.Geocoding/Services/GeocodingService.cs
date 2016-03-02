using System.Collections.Specialized;
using System.Threading.Tasks;
using GoogleMaps.Net.Geocoding.Response;
using GoogleMaps.Net.Geocoding.Services.Contracts;
using GoogleMaps.Net.Shared;
using GoogleMaps.Net.Shared.Contracts;

namespace GoogleMaps.Net.Geocoding.Services
{
    public class GeocodingService : IGeocodingService
    {
        private readonly IWebApi _webApi;

        public GeocodingService(IWebApi webApi)
        {
            _webApi = webApi;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="address">The Place ID of the Place for which details are being requested.</param>
        /// <returns></returns>
        public async Task<GeocodingResponse> Geocode(string address)
        {
            var queryParams = new NameValueCollection { { "address", address } };
            return await _webApi.GetAsync<GeocodingResponse>(EndPointUris.Geocode, queryParams);
        }
    }
}