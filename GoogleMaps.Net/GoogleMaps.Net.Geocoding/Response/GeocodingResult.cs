// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GeocodingResult.cs" company="Sanu Sathyaseelan">
//   The MIT License (MIT)
//   
//   Copyright (c) 2016 Sanu Sathyaseelan
//   
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//   of this software and associated documentation files (the "Software"), to deal
//   in the Software without restriction, including without limitation the rights
//   to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//   copies of the Software, and to permit persons to whom the Software is
//   furnished to do so, subject to the following conditions:
//   
//   The above copyright notice and this permission notice shall be included in all
//   copies or substantial portions of the Software.
//   
//   THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//   IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//   FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//   AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//   LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//   OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//   SOFTWARE.
// </copyright>
// <summary>
//   The geocoding result.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GoogleMaps.Net.Geocoding.Response
{
    using System.Collections.Generic;
    using Shared.Data;

    /// <summary>
    /// The geocoding result.
    /// </summary>
    public class GeocodingResult
    {
        /// <summary>
        /// The collection of address components for this Place's location.
        /// </summary>
        public IEnumerable<GeocoderAddressComponent> AddressComponents { get; set; }

        /// <summary>
        /// Gets or sets the formatted address.
        /// </summary>
        public string FormattedAddress { get; set; }

        /// <summary>
        /// Gets or sets the geometry.
        /// </summary>
        public GeocodingGeometry Geometry { get; set; }

        /// <summary>
        /// Gets or sets the place id.
        /// </summary>
        public string PlaceId { get; set; }

        /// <summary>
        /// Gets or sets the types.
        /// </summary>
        public IEnumerable<string> Types { get; set; }
    }
}