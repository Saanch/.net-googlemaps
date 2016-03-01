using System.Collections.Generic;

namespace GoogleMaps.Net.Places.Response
{
    public class PlacePhoto
    {
        public int Height { get; set; }
        public IEnumerable<string> HtmlAttributions { get; set; }
        public string PhotoReference { get; set; }
        public int Width { get; set; } 
    }
}