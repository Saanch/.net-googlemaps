using System;

namespace GoogleMaps.Net.Shared
{
    public static class EndPointUris
    {
        public const string PlaceSearchDetails = "api/place/details/json";
        public const string PlacesNerbySearch = "api/place/nearbysearch/json";
        public const string PlacesTextSearch = "api/place/textsearch/json";
        public const string PlacesRadarSearch = "api/place/radarsearch/json";
        public const string PlacesAutocompleteSearch = "api/place/autocomplete/json";
        public const string Geocode = "api/geocode/json";
        public const string Directions = "api/directions/json";

        public static Uri GetBaseUri()
        {
            return new Uri("https://maps.googleapis.com/maps/");
        }
    }
}   