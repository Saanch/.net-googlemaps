using System.Collections.Generic;

namespace GoogleMaps.Net.Places.Models
{
    public class PlacePhoto
    {
        public int Height { get; set; }
        public IEnumerable<string> HtmlAttributions { get; set; }
        public int Width { get; set; } 
    }
}