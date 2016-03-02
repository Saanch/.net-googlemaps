using System.Collections.Generic;
using GoogleMaps.Net.Shared.Data;

namespace GoogleMaps.Net.Directions.Response
{
    public class Leg
    {
        public TextValue Distance { get; set; }
        public TextValue Duration { get; set; }
        public string EndAddress { get; set; }
        public LatLng EndLocation { get; set; }
        public string StartAddress { get; set; }
        public LatLng StartLocation { get; set; }
        public IEnumerable<Step> Steps { get; set; }
        public IEnumerable<Waypoint> ViaWaypoint { get; set; }
    }
}