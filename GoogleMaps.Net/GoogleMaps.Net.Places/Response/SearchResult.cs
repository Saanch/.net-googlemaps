using System.Collections.Generic;
using System.Data.Common;
using GoogleMaps.Net.Shared.Data;

namespace GoogleMaps.Net.Places.Response
{
    public class SearchResult
    {
        public Geometry Geometry { get; set; }
        public string Icon { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public OpeningHours OpeningHours { get; set; }
        public IEnumerable<PlacePhoto> Photos { get; set; }
        public string PlaceId { get; set; }
        public decimal Rating { get; set; }
        public string Reference { get; set; }
        public IEnumerable<string> Types { get; set; }
    }
}