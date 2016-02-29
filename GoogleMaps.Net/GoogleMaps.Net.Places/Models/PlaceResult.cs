using System.Collections.Generic;
using Newtonsoft.Json;

namespace GoogleMaps.Net.Places.Models
{
    /// <summary>
    /// Defines information about a Place.
    /// </summary>
    public class PlaceResult
    {
        public IEnumerable<GeocoderAddressComponent> AddressComponents { get; set; }

        public IEnumerable<PlaceAspectRating> Aspects { get; set; }

        public string FormattedAddress { get; set; }
        public string FormattedPhoneNumber { get; set; }
        public PlaceGeometry Geometry { get; set; }
       
        /// <summary>
        /// URL to an image resource that can be used to represent this Place's category.
        /// </summary>
        public string Icon { get; set; }

        public string InternationalPhoneNumber { get; set; }
        public string Name { get; set; }
        public bool PermanentlyClosed { get; set; }
        public IEnumerable<PlacePhoto> Photos { get; set; }
        public string PlaceId { get; set; }
        public PriceLevel PriceLevel { get; set; }
        public decimal Rating { get; set; }
        public IEnumerable<PlaceReview> Reviews { get; set; }
        public IEnumerable<string> Types { get; set; }
        public string Url { get; set; }
        public int UtcOffset { get; set; }
        public string Vicinity { get; set; }
        public string Website { get; set; }
    }

}