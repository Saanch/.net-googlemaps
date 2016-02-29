using System.Collections.Generic;

namespace GoogleMaps.Net.Places.Models
{
    public class GeocoderAddressComponent
    {
        /// <summary>
        /// The full text of the address component
        /// </summary>
        public string LongName { get; set; }
        /// <summary>
        /// The abbreviated, short text of the given address component
        /// </summary>
        public string ShortName { get; set; }
        /// <summary>
        /// An array of strings denoting the type of this address component. A list of valid types can be found https://developers.google.com/maps/documentation/geocoding/intro#Types
        /// </summary>
        public IEnumerable<string> Types { get; set; } 
    }
}