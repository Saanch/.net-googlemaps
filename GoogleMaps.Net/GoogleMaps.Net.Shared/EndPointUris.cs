// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EndPointUris.cs" company="Sanu Sathyaseelan">
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
//   The end point uris.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GoogleMaps.Net.Shared
{
    using System;

    /// <summary>
    /// The end point uris.
    /// </summary>
    public static class EndPointUris
    {
        /// <summary>
        /// The place search details.
        /// </summary>
        public const string PlaceSearchDetails = "api/place/details/json";

        /// <summary>
        /// The places nerby search.
        /// </summary>
        public const string PlacesNerbySearch = "api/place/nearbysearch/json";

        /// <summary>
        /// The places text search.
        /// </summary>
        public const string PlacesTextSearch = "api/place/textsearch/json";

        /// <summary>
        /// The places radar search.
        /// </summary>
        public const string PlacesRadarSearch = "api/place/radarsearch/json";

        /// <summary>
        /// The places autocomplete search.
        /// </summary>
        public const string PlacesAutocompleteSearch = "api/place/autocomplete/json";

        /// <summary>
        /// The geocode.
        /// </summary>
        public const string Geocode = "api/geocode/json";

        /// <summary>
        /// The directions.
        /// </summary>
        public const string Directions = "api/directions/json";

        /// <summary>
        /// The get base uri.
        /// </summary>
        /// <returns>
        /// The <see cref="Uri"/>.
        /// </returns>
        public static Uri GetBaseUri()
        {
            return new Uri("https://maps.googleapis.com/maps/");
        }
    }
}