using System.Collections.Generic;

namespace GoogleMaps.Net.Directions.Response
{
    public class Waypoint
    {
        public ResultStatus GeocoderStatus { get; set; }
        public string PlaceId { get; set; }
        public IEnumerable<string> Types { get; set; }
    }
}