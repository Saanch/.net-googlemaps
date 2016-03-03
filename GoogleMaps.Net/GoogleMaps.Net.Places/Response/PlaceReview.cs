// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlaceReview.cs" company="Sanu Sathyaseelan">
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
//   The place review.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GoogleMaps.Net.Places.Response
{
    using System.Collections.Generic;

    /// <summary>
    /// The place review.
    /// </summary>
    public class PlaceReview
    {
        /// <summary>
        /// Gets or sets the aspects.
        /// </summary>
        public IEnumerable<PlaceAspectRating> Aspects { get; set; }

        /// <summary>
        /// Gets or sets the author name.
        /// </summary>
        public string AuthorName { get; set; }

        /// <summary>
        /// Gets or sets the author url.
        /// </summary>
        public string AuthorUrl { get; set; }

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets the profile photo url.
        /// </summary>
        public string ProfilePhotoUrl { get; set; }

        /// <summary>
        /// Gets or sets the rating.
        /// </summary>
        public decimal Rating { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        public string Time { get; set; }
    }
}