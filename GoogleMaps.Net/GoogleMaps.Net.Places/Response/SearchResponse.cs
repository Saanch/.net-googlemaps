using System.Collections.Generic;

namespace GoogleMaps.Net.Places.Response
{
    public class SearchResponse<T>  where T : SearchResult
    {
        public IEnumerable<string> HtmlAttributions { get; set; }
        public IEnumerable<T> Results { get; set; }
        public PlacesServiceStatus Status { get; set; }
    }
}