using System.Collections.Generic;

namespace GoogleMaps.Net.Places.Models
{
    public class PlaceReview
    {
        public IEnumerable<PlaceAspectRating> Aspects { get; set; }
        public string AuthorName { get; set; }
        public string AuthorUrl { get; set; }
        public string Language { get; set; }

        public string Text { get; set; }
         
    }
}