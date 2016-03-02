using GoogleMaps.Net.Shared.Data;

namespace GoogleMaps.Net.Places.Response
{
    public class RadarSearchResult
    {
        public Geometry Geometry { get; set; }
        public string Id { get; set; }
        public string PlaceId { get; set; }
        public string Reference { get; set; }
    }
}