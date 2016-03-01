using System.Collections.Generic;

namespace GoogleMaps.Net.Directions.Response
{
    public class Leg
    {
        public IEnumerable<Step> Steps { get; set; }
        public string StartAddress { get; set; }
        public string EndAddress { get; set; } 
    }
}