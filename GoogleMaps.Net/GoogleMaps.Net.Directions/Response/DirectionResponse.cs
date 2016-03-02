using System.Collections.Generic;

namespace GoogleMaps.Net.Directions.Response
{
    public class DirectionResponse
    {
        public GeocoderStatus Status { get; set; }
        public IEnumerable<Waypoint> GeocoderWaypoints { get; set; }

    }
}