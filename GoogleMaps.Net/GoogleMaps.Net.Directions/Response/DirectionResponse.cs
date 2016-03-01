using System.Collections.Generic;

namespace GoogleMaps.Net.Directions.Response
{
    public class DirectionResponse
    {
        public ResultStatus Status { get; set; }
        public IEnumerable<Waypoint> GeocoderWaypoints { get; set; }

    }
}