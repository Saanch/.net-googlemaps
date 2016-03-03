// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlaceSearchRequest.cs" company="Sanu Sathyaseelan">
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
//   A Place search query to be sent to the PlacesService.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GoogleMaps.Net.Places.Request
{
    using Shared.Data;

    /// <summary>
    /// A Place search query to be sent to the PlacesService.
    /// </summary>
    public class PlaceSearchRequest
    {
        /// <summary>
        /// Bounds used to bias results when searching for Places (optional). Both location and radius will be ignored if bounds is set. Results will not be restricted to those inside these bounds; but, results inside it will rank higher.
        /// </summary>
        public LatLngBounds Bounds { get; set; }

        /// <summary>
        /// A term to be matched against all available fields, including but not limited to name, type, and address, as well as customer reviews and other third-party content.
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// The center of the area used to bias results when searching for Places.
        /// </summary>
        public LatLng Location { get; set; }

        /// <summary>
        /// Restricts results to only those places at the specified price level or lower. Valid values are in the range from 0 (most affordable) to 4 (most expensive), inclusive. Must be greater than or equal to minPrice , if specified.
        /// </summary>
        public decimal MaxPriceLevel { get; set; }

        /// <summary>
        /// Restricts results to only those places at the specified price level or higher. Valid values are in the range from 0 (most affordable) to 4 (most expensive), inclusive. Must be less than or equal to maxPrice, if specified.
        /// </summary>
        public decimal MinPriceLevel { get; set; }

        /// <summary>
        /// Restricts results to Places that include this text in the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Restricts results to only those places that are open right now.
        /// </summary>
        public bool OpenNow { get; set; }

        /// <summary>
        /// The distance from the given location within which to search for Places, in meters. The maximum allowed value is 50 000.
        /// </summary>
        public int Radius { get; set; }

        /// <summary>
        /// Specifies the ranking method to use when returning results. Defaults to PROMINENCE.
        /// </summary>
        public PlacesRankby Rankby { get; set; }

        /// <summary>
        /// Searches for places of the given type. The type will be translated to the local language of the request's target location and used as query. If a query is also provided, it will be concatenated to the localized type string. Results of a different type will be dropped from the response. Use this to search for language and region independent categorical search.
        /// </summary>
        public string Type { get; set; }
    }
}