using System;
using System.Collections.Generic;

namespace GoogleMaps.Net.Places.Response
{
    public class PlaceReview
    {
        public IEnumerable<PlaceAspectRating> Aspects { get; set; }
        public string AuthorName { get; set; }
        public string AuthorUrl { get; set; }
        public string Language { get; set; }
        public string ProfilePhotoUrl { get; set; }
        public decimal Rating { get; set; }

        public string Text { get; set; }
        public string Time { get; set; }
         
    }
}