using System.Collections.Generic;
using GoogleMaps.Net.Shared.Data;

namespace GoogleMaps.Net.Directions.Response
{
    public class Route
    {
        public Viewport Bounds { get; set; }
        public string Copyrights { get; set; }
        public IEnumerable<Leg> Legs { get; set; }
        public Polyline OverviewPolyline { get; set; }
        public string Summary { get; set; }
        public IEnumerable<string> Warnings { get; set; }
        public IEnumerable<int> WaypointOrder { get; set; }
    }
}