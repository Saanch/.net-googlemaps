using GoogleMaps.Net.Places.Response;
using GoogleMaps.Net.Shared.Data;

namespace GoogleMaps.Net.Places.Request
{
    public class NearbySearchRequest
    {
        public LatLng Location { get; set; }
        public int Radius { get; set; } 
    }
}