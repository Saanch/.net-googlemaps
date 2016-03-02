using System.Collections.Generic;

namespace GoogleMaps.Net.Directions.Response
{
    public class Waypoint
    {
        public GeocoderStatus GeocoderStatus { get; set; }
        public string PlaceId { get; set; }
        public IEnumerable<string> Types { get; set; }
    }
}