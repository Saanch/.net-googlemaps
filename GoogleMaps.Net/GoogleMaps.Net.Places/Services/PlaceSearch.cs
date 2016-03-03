namespace GoogleMaps.Net.Places.Services
{
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Threading.Tasks;
    using Contracts;
    using Request;
    using Response;
    using Shared;
    using Shared.Contracts;
    using Shared.Data;

    /// <summary>
    /// The place search.
    /// </summary>
    public class PlaceSearch : DisposableObject, IPlaceSearch
    {
        /// <summary>
        /// The _web api.
        /// </summary>
        private readonly IWebApi _webApi;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaceSearch"/> class.
        /// </summary>
        /// <param name="webApi">
        /// The web api.
        /// </param>
        public PlaceSearch(IWebApi webApi)
        {
            _webApi = webApi;
        }

        /// <summary>
        /// The nearby.
        /// </summary>
        /// <param name="location">
        /// The location.
        /// </param>
        public void Nearby(LatLng location)
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="placeId">
        /// The Place ID of the Place for which details are being requested.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<PlaceDetailsResponse> Details(string placeId)
        {
            var queryParams = new NameValueCollection {{"placeid", placeId}};
            return await _webApi.GetAsync<PlaceDetailsResponse>(EndPointUris.PlaceSearchDetails, queryParams);
        }


        /// <summary>
        /// The prepare search request query.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="NameValueCollection"/>.
        /// </returns>
        private NameValueCollection PrepareSearchRequestQuery(SearchRequest request)
        {
            var queryParams = new NameValueCollection {{"location", request.Location.ToString()}};
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

        // https://maps.googleapis.com/maps/api/place/nearbysearch/json?location=-33.8670522,151.1957362&radius=500&type=restaurant&name=cruise&key
        /// <summary>
        /// The nearby search.
        /// </summary>
        /// <param name="location">
        /// The location.
        /// </param>
        /// <param name="radius">
        /// The radius.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<SearchResponse<NearbySearchResult>> NearbySearch(LatLng location, int radius)
        {
            var queryParams = new NameValueCollection {{"location", location.ToString()}, {"radius", radius.ToString()}};
            return await _webApi.GetAsync<SearchResponse<NearbySearchResult>>(EndPointUris.PlacesNerbySearch, queryParams);
        }

        /// <summary>
        /// The nearby search.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<SearchResponse<NearbySearchResult>> NearbySearch(NearbySearchRequest request)
        {
            var queryParams = PrepareSearchRequestQuery(request);
            return await _webApi.GetAsync<SearchResponse<NearbySearchResult>>(EndPointUris.PlacesNerbySearch, queryParams);
        }

        // https://maps.googleapis.com/maps/api/place/textsearch/xml?query=restaurants+in+Sydney&key=YOUR_API_KEY
        /// <summary>
        /// The text search.
        /// </summary>
        /// <param name="query">
        /// The query.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<SearchResponse<TextSearchResult>> TextSearch(string query)
        {
            var queryParams = new NameValueCollection {{"query", query}};
            return await _webApi.GetAsync<SearchResponse<TextSearchResult>>(EndPointUris.PlacesTextSearch, queryParams);
        }

        /// <summary>
        /// The radar search by keyword.
        /// </summary>
        /// <param name="location">
        /// The location.
        /// </param>
        /// <param name="radius">
        /// The radius.
        /// </param>
        /// <param name="keyword">
        /// The keyword.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<RadarSearchResponse> RadarSearchByKeyword(LatLng location, int radius, string keyword)
        {
            var queryParams = new NameValueCollection {{"location", location.ToString()}, {"radius", radius.ToString()}, {"keyword", keyword}};
            return await _webApi.GetAsync<RadarSearchResponse>(EndPointUris.PlacesRadarSearch, queryParams);
        }

        /// <summary>
        /// The radar search by name.
        /// </summary>
        /// <param name="location">
        /// The location.
        /// </param>
        /// <param name="radius">
        /// The radius.
        /// </param>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<RadarSearchResponse> RadarSearchByName(LatLng location, int radius, string name)
        {
            var queryParams = new NameValueCollection {{"location", location.ToString()}, {"radius", radius.ToString()}, {"name", name}};
            return await _webApi.GetAsync<RadarSearchResponse>(EndPointUris.PlacesRadarSearch, queryParams);
        }

        /// <summary>
        /// The radar search by names.
        /// </summary>
        /// <param name="location">
        /// The location.
        /// </param>
        /// <param name="radius">
        /// The radius.
        /// </param>
        /// <param name="names">
        /// The names.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<RadarSearchResponse> RadarSearchByNames(LatLng location, int radius, IEnumerable<string> names)
        {
            var pipednames = string.Join("|", names);
            var queryParams = new NameValueCollection {{"location", location.ToString()}, {"radius", radius.ToString()}, {"name", pipednames}};
            return await _webApi.GetAsync<RadarSearchResponse>(EndPointUris.PlacesRadarSearch, queryParams);
        }

        /// <summary>
        /// The radar search by type.
        /// </summary>
        /// <param name="location">
        /// The location.
        /// </param>
        /// <param name="radius">
        /// The radius.
        /// </param>
        /// <param name="type">
        /// The type.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<RadarSearchResponse> RadarSearchByType(LatLng location, int radius, string type)
        {
            var queryParams = new NameValueCollection {{"location", location.ToString()}, {"radius", radius.ToString()}, {"type", type}};
            return await _webApi.GetAsync<RadarSearchResponse>(EndPointUris.PlacesRadarSearch, queryParams);
        }

        // https://maps.googleapis.com/maps/api/place/textsearch/xml?query=restaurants+in+Sydney&key=YOUR_API_KEY
        /// <summary>
        /// The radar search.
        /// </summary>
        /// <param name="location">
        /// The location.
        /// </param>
        /// <param name="radius">
        /// The radius.
        /// </param>
        /// <param name="keyword">
        /// The keyword.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<RadarSearchResponse> RadarSearch(LatLng location, int radius, string keyword)
        {
            var queryParams = new NameValueCollection {{"location", location.ToString()}, {"radius", radius.ToString()}, {"keyword", keyword}};
            return await _webApi.GetAsync<RadarSearchResponse>(EndPointUris.PlacesRadarSearch, queryParams);
        }

        /// <summary>
        /// The radar search.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<RadarSearchResponse> RadarSearch(RadarSearchRequest request)
        {
            var queryParams = PrepareSearchRequestQuery(request);
            return await _webApi.GetAsync<RadarSearchResponse>(EndPointUris.PlacesRadarSearch, queryParams);
        }

        /// <summary>
        /// The autocomplete.
        /// </summary>
        /// <param name="input">
        /// The input.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<AutocompleteResponse> Autocomplete(string input)
        {
            var queryParams = new NameValueCollection {{"input", input}};
            return await _webApi.GetAsync<AutocompleteResponse>(EndPointUris.PlacesAutocompleteSearch, queryParams);
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