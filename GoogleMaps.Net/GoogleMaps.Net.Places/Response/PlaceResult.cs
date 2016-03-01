using System.Collections.Generic;

namespace GoogleMaps.Net.Places.Response
{
    /// <summary>
    /// Defines information about a Place.
    /// </summary>
    public class PlaceResult
    {
        public IEnumerable<GeocoderAddressComponent> AddressComponents { get; set; }

        public IEnumerable<PlaceAspectRating> Aspects { get; set; }
        public string AdrAddress { get; set; }
        public string FormattedAddress { get; set; }
        public string FormattedPhoneNumber { get; set; }
        public PlaceGeometry Geometry { get; set; }
       
        /// <summary>
        /// URL to an image resource that can be used to represent this Place's category.
        /// </summary>
        public string Icon { get; set; }

        public string Id { get; set; }

        public string InternationalPhoneNumber { get; set; }
        public string Name { get; set; }
        public bool PermanentlyClosed { get; set; }
        public IEnumerable<PlacePhoto> Photos { get; set; }
        public string PlaceId { get; set; }
        public PriceLevel PriceLevel { get; set; }
        public decimal Rating { get; set; }
        public string Reference { get; set; }
        public IEnumerable<PlaceReview> Reviews { get; set; }
        public string Scope { get; set; }
        public IEnumerable<string> Types { get; set; }
        public string Url { get; set; }
        public int UserRatingsTotal { get; set; }
        public int UtcOffset { get; set; }
        public string Vicinity { get; set; }
        public string Website { get; set; }
    }

}