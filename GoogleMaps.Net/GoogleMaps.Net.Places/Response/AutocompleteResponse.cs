using System.Collections.Generic;

namespace GoogleMaps.Net.Places.Response
{
    public class AutocompleteResponse
    {
        public IEnumerable<AutoCompleteResult> Predictions { get; set; }
        public ServiceStatus Status { get; set; } 
    }
}