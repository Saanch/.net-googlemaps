﻿using System.Collections.Generic;

namespace GoogleMaps.Net.Directions.Response
{
    public class Route
    {
        public string Summary { get; set; }
        public IEnumerable<Leg> Legs { get; set; }
        public string Copyrights { get; set; }
        public Polyline OverviewPolyline { get; set; }
        public IEnumerable<string> Warnings { get; set; }
        public IEnumerable<int> WaypointOrder { get; set; }
        public Bound Bounds { get; set; }
    }
}