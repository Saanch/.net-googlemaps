using System.Collections.Generic;

namespace GoogleMaps.Net.Places.Response
{
    /// <summary>
    /// Defines information about a Place.
    /// </summary>
    public class PlaceResult
    {
        /// <summary>
        /// The collection of address components for this Place's location.
        /// </summary>
        public IEnumerable<GeocoderAddressComponent> AddressComponents { get; set; }
        /// <summary>
        /// The rated aspects of this Place, based on Google and Zagat user reviews. The ratings are on a scale of 0 to 30.
        /// </summary>
        public IEnumerable<PlaceAspectRating> Aspects { get; set; }
        public string AdrAddress { get; set; }
        /// <summary>
        /// The Place's full address.
        /// </summary>
        public string FormattedAddress { get; set; }
        /// <summary>
        /// The Place's phone number, formatted according to the number's regional convention.
        /// </summary>
        public string FormattedPhoneNumber { get; set; }
        /// <summary>
        /// The Place's geometry-related information.
        /// </summary>
        public PlaceGeometry Geometry { get; set; }
       
        /// <summary>
        /// URL to an image resource that can be used to represent this Place's category.
        /// </summary>
        public string Icon { get; set; }

        public string Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
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