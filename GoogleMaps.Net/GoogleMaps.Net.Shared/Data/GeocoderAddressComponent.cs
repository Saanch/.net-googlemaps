// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GeocoderAddressComponent.cs" company="Sanu Sathyaseelan">
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
//   The geocoder address component.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GoogleMaps.Net.Shared.Data
{
    using System.Collections.Generic;

    /// <summary>
    /// The geocoder address component.
    /// </summary>
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