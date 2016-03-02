using System;

namespace GoogleMaps.Net.Shared
{
    public static class EndPointUris
    {
        public const string PlaceSearchDetails = "api/place/details/json";
        public const string PlacesNerbySearch = "api/place/nearbysearch/json";
        public const string PlacesTextSearch = "api/place/textsearch/json";
        public const string PlacesRadarSearch = "api/place/radarsearch/json";
        public static Uri Directions()
        {
            return new Uri(@"/maps/api/directions/json", UriKind.Relative);
        }

        public static Uri GetBaseUri()
        {
            return new Uri("https://maps.googleapis.com/maps/");
        }
    }
}   