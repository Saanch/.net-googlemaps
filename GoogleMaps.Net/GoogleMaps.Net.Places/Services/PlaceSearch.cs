using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using GoogleMaps.Net.Places.Contracts;
using GoogleMaps.Net.Places.Request;
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


        private NameValueCollection PrepareSearchRequestQuery(SearchRequest request)
        {
            var queryParams = new NameValueCollection { { "location", request.Location.ToString() } };
            if (request.Rankby == null || request.Rankby != PlacesRankby.DISTANCE)
            {
                queryParams.Add("radius", request.Radius.ToString());
            }
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                queryParams.Add("keyword", request.Keyword);
            }
            if (!string.IsNullOrEmpty(request.Language))
            {
                queryParams.Add("language", request.Language);
            }
            if (!string.IsNullOrEmpty(request.Name))
            {
                queryParams.Add("name", request.Name);
            }
            if (!string.IsNullOrEmpty(request.Type))
            {
                queryParams.Add("type", request.Type);
            }
            if (request.OpenNow != null && request.OpenNow.Value)
            {
                queryParams.Add("open_now", "true");
            }
            return queryParams;
        }

        //https://maps.googleapis.com/maps/api/place/nearbysearch/json?location=-33.8670522,151.1957362&radius=500&type=restaurant&name=cruise&key
        public async Task<SearchResponse<NearbySearchResult>> NearbySearch(LatLng location, int radius)
        {
            var queryParams = new NameValueCollection {{"location", location.ToString()}, {"radius", radius.ToString()}};
            return await _webApi.GetAsync<SearchResponse<NearbySearchResult>>(EndPointUris.PlacesNerbySearch, queryParams);
        }

        public async Task<SearchResponse<NearbySearchResult>> NearbySearch(NearbySearchRequest request)
        {
            var queryParams = PrepareSearchRequestQuery(request);
            return await _webApi.GetAsync<SearchResponse<NearbySearchResult>>(EndPointUris.PlacesNerbySearch, queryParams);
        }

        //https://maps.googleapis.com/maps/api/place/textsearch/xml?query=restaurants+in+Sydney&key=YOUR_API_KEY
        public async Task<SearchResponse<TextSearchResult>> TextSearch(string query)
        {
            var queryParams = new NameValueCollection { { "query", query } };
            return await _webApi.GetAsync<SearchResponse<TextSearchResult>>(EndPointUris.PlacesTextSearch, queryParams);
        }

        public async Task<RadarSearchResponse> RadarSearchByKeyword(LatLng location, int radius, string keyword)
        {
            var queryParams = new NameValueCollection { { "location", location.ToString() }, { "radius", radius.ToString() }, { "keyword", keyword } };
            return await _webApi.GetAsync<RadarSearchResponse>(EndPointUris.PlacesRadarSearch, queryParams);
        }

        public async Task<RadarSearchResponse> RadarSearchByName(LatLng location, int radius, string name)
        {
            var queryParams = new NameValueCollection { { "location", location.ToString() }, { "radius", radius.ToString() }, { "name", name } };
            return await _webApi.GetAsync<RadarSearchResponse>(EndPointUris.PlacesRadarSearch, queryParams);
        }

        public async Task<RadarSearchResponse> RadarSearchByNames(LatLng location, int radius, IEnumerable<string> names)
        {
            var pipednames = string.Join("|", names);
            var queryParams = new NameValueCollection { { "location", location.ToString() }, { "radius", radius.ToString() }, { "name", pipednames } };
            return await _webApi.GetAsync<RadarSearchResponse>(EndPointUris.PlacesRadarSearch, queryParams);
        }

        public async Task<RadarSearchResponse> RadarSearchByType(LatLng location, int radius, string type)
        {
            var queryParams = new NameValueCollection { { "location", location.ToString() }, { "radius", radius.ToString() }, { "type", type } };
            return await _webApi.GetAsync<RadarSearchResponse>(EndPointUris.PlacesRadarSearch, queryParams);
        }

        //https://maps.googleapis.com/maps/api/place/textsearch/xml?query=restaurants+in+Sydney&key=YOUR_API_KEY
        public async Task<RadarSearchResponse> RadarSearch(LatLng location, int radius, string keyword)   
        {
            var queryParams = new NameValueCollection { { "location", location.ToString() }, { "radius", radius.ToString() }, { "keyword", keyword } };
            return await _webApi.GetAsync<RadarSearchResponse>(EndPointUris.PlacesRadarSearch, queryParams);
        }

        public async Task<RadarSearchResponse> RadarSearch(RadarSearchRequest request)
        {
            var queryParams = PrepareSearchRequestQuery(request);
            return await _webApi.GetAsync<RadarSearchResponse>(EndPointUris.PlacesRadarSearch, queryParams);
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