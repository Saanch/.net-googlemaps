using System.Collections.Specialized;
using System.Threading.Tasks;
using GoogleMaps.Net.Places.Contracts;
using GoogleMaps.Net.Places.Response;
using GoogleMaps.Net.Shared;
using GoogleMaps.Net.Shared.Contracts;

namespace GoogleMaps.Net.Places.Services
{
    public class PlaceSearch : DisposableObject, IPlaceSerach
    {
        private readonly IWebApi _webApi;

        public PlaceSearch(IWebApi webApi)
        {
            _webApi = webApi;
        }

        public void Nearby(LatLng location)
        {
        }

        public async Task<PlaceDetailsResponse> Details(string placeId)
        {
            var queryParams = new NameValueCollection {{"placeid", placeId}};
            return await _webApi.GetAsync<PlaceDetailsResponse>(EndPointUris.PlaceSearchDetails, queryParams);
        }

        /// <summary>
        /// Dispose of resources being used by the disposable object.
        /// </summary>
        /// <param name="disposing">
        /// Explicit disposal?
        /// </param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _webApi?.Dispose();
            }
        }
    }
}