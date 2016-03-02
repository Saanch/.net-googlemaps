using System.Collections.Generic;
using GoogleMaps.Net.Shared.Data;

namespace GoogleMaps.Net.Geocoding.Response
{
    public class GeocodingResult
    {
        /// <summary>
        /// The collection of address components for this Place's location.
        /// </summary>
        public IEnumerable<GeocoderAddressComponent> AddressComponents { get; set; }

        public string FormattedAddress { get; set; }
        public GeocodingGeometry Geometry { get; set; }
        public string PlaceId { get; set; }
        public IEnumerable<string> Types { get; set; }
    }
}