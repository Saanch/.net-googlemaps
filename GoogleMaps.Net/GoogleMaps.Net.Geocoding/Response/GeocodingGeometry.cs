using GoogleMaps.Net.Shared.Data;

namespace GoogleMaps.Net.Geocoding.Response
{
    public class GeocodingGeometry
    {
        public LatLng Location { get; set; }
        public string LocationType { get; set; }
        public Viewport Viewport { get; set; }
    }
}