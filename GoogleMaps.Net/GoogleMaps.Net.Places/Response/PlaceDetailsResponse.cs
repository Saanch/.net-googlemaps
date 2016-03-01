using System.Collections.Generic;

namespace GoogleMaps.Net.Places.Response
{
    public class PlaceDetailsResponse
    {
        public IEnumerable<string> HtmlAttributions { get; set; }

        public PlaceResult Result { get; set; }
        public Shared.Response.PlacesServiceStatus Status { get; set; }

        public string ErrorMessage { get; set; }
    }
}