using System.Collections.Generic;

namespace GoogleMaps.Net.Places.Response
{
    public class RadarSearchResponse
    {
        public IEnumerable<string> HtmlAttributions { get; set; }
        public IEnumerable<RadarSearchResult> Results { get; set; }
        public Shared.Response.PlacesServiceStatus Status { get; set; }

        public string ErrorMessage { get; set; }
    }
}