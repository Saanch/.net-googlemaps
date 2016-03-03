// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlaceResult.cs" company="Sanu Sathyaseelan">
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
//   Defines information about a Place.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GoogleMaps.Net.Places.Response
{
    using System.Collections.Generic;
    using Shared.Data;

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

        /// <summary>
        /// Gets or sets the adr address.
        /// </summary>
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

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string InternationalPhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether permanently closed.
        /// </summary>
        public bool PermanentlyClosed { get; set; }

        /// <summary>
        /// Gets or sets the photos.
        /// </summary>
        public IEnumerable<PlacePhoto> Photos { get; set; }

        /// <summary>
        /// Gets or sets the place id.
        /// </summary>
        public string PlaceId { get; set; }

        /// <summary>
        /// Gets or sets the price level.
        /// </summary>
        public PriceLevel PriceLevel { get; set; }

        /// <summary>
        /// Gets or sets the rating.
        /// </summary>
        public decimal Rating { get; set; }

        /// <summary>
        /// Gets or sets the reference.
        /// </summary>
        public string Reference { get; set; }

        /// <summary>
        /// Gets or sets the reviews.
        /// </summary>
        public IEnumerable<PlaceReview> Reviews { get; set; }

        /// <summary>
        /// Gets or sets the scope.
        /// </summary>
        public string Scope { get; set; }

        /// <summary>
        /// Gets or sets the types.
        /// </summary>
        public IEnumerable<string> Types { get; set; }

        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the user ratings total.
        /// </summary>
        public int UserRatingsTotal { get; set; }

        /// <summary>
        /// Gets or sets the utc offset.
        /// </summary>
        public int UtcOffset { get; set; }

        /// <summary>
        /// Gets or sets the vicinity.
        /// </summary>
        public string Vicinity { get; set; }

        /// <summary>
        /// Gets or sets the website.
        /// </summary>
        public string Website { get; set; }
    }
}