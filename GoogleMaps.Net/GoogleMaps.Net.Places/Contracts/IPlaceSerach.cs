using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GoogleMaps.Net.Places.Request;
using GoogleMaps.Net.Places.Response;
using GoogleMaps.Net.Shared.Data;

namespace GoogleMaps.Net.Places.Contracts
{
    public interface IPlaceSerach : IDisposable
    {
        Task<PlaceDetailsResponse> Details(string placeId);
        Task<SearchResponse<NearbySearchResult>> NearbySearch(LatLng location, int radius);
        Task<SearchResponse<NearbySearchResult>> NearbySearch(NearbySearchRequest request);
        Task<SearchResponse<TextSearchResult>> TextSearch(string query);
        Task<RadarSearchResponse> RadarSearchByKeyword(LatLng location, int radius, string keyword);
        Task<RadarSearchResponse> RadarSearchByName(LatLng location, int radius, string name);
        Task<RadarSearchResponse> RadarSearchByNames(LatLng location, int radius, IEnumerable<string> names);
        Task<RadarSearchResponse> RadarSearchByType(LatLng location, int radius, string type);
        Task<RadarSearchResponse> RadarSearch(RadarSearchRequest request);
        Task<AutocompleteResponse> Autocomplete(string input);
    }
}