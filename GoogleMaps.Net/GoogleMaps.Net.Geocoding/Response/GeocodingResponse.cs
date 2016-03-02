using System.Collections.Generic;
using GoogleMaps.Net.Shared.Data;

namespace GoogleMaps.Net.Geocoding.Response
{
    public class GeocodingResponse
    {
        public IEnumerable<GeocodingResult> Results { get; set; }
        public ServiceStatus Status { get; set; } 
    }
}