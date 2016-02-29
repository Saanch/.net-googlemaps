using System.Collections.Generic;

namespace GoogleMaps.Net.Directions.Models
{
    public class DirectionResponse
    {
        public ResultStatus Status { get; set; }
        public IEnumerable<Waypoint> GeocoderWaypoints { get; set; }

    }
}