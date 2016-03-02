using System.Collections.Generic;

namespace GoogleMaps.Net.Places.Response
{
    public class AutoCompleteResult
    {
        public string Description { get; set; }
        public string Id { get; set; }
        public IEnumerable<MatchedSubstring> MatchedSubstrings { get; set; }
        public string PlaceId { get; set; }
        public string Reference { get; set; }
        public IEnumerable<AutocompleteTerm> Terms { get; set; }
        public IEnumerable<string> Types { get; set; }
    }
}