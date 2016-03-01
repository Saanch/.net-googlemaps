using System;

namespace GoogleMaps.Net.Shared
{
    public static class EndPointUris
    {
        public const string PlaceSearchDetails = "api/place/details/json";
        public const string PlacesNerbySearch = "api/place/nearbysearch/json";
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