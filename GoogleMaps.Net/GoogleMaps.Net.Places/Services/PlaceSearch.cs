using System.Collections.Specialized;
using System.Threading.Tasks;
using GoogleMaps.Net.Places.Contracts;
using GoogleMaps.Net.Places.Response;
using GoogleMaps.Net.Shared;
using GoogleMaps.Net.Shared.Contracts;
using GoogleMaps.Net.Shared.Data;

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="placeId">The Place ID of the Place for which details are being requested.</param>
        /// <returns></returns>
        public async Task<PlaceDetailsResponse> Details(string placeId)
        {
            var queryParams = new NameValueCollection {{"placeid", placeId}};
            return await _webApi.GetAsync<PlaceDetailsResponse>(EndPointUris.PlaceSearchDetails, queryParams);
        }


        //https://maps.googleapis.com/maps/api/place/nearbysearch/json?location=-33.8670522,151.1957362&radius=500&type=restaurant&name=cruise&key
        public async Task<PlaceDetailsResponse> NearbySearch(LatLng location, int radius)
        {
            var queryParams = new NameValueCollection {{"location", location.Lat + "," + location.Lng}, {"radius", radius.ToString()} };
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