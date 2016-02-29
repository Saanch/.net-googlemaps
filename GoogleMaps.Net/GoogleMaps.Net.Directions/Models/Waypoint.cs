using System.Collections.Generic;
using System.Security.Permissions;

namespace GoogleMaps.Net.Directions.Models
{
    public class Waypoint
    {
        public ResultStatus GeocoderStatus { get; set; }
        public string PlaceId { get; set; }
        public IEnumerable<string> Types { get; set; }
    }
}