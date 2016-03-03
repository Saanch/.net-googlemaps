// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AutoCompleteResult.cs" company="Sanu Sathyaseelan">
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
//   The auto complete result.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GoogleMaps.Net.Places.Response
{
    using System.Collections.Generic;

    /// <summary>
    /// The auto complete result.
    /// </summary>
    public class AutoCompleteResult
    {
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the matched substrings.
        /// </summary>
        public IEnumerable<MatchedSubstring> MatchedSubstrings { get; set; }

        /// <summary>
        /// Gets or sets the place id.
        /// </summary>
        public string PlaceId { get; set; }

        /// <summary>
        /// Gets or sets the reference.
        /// </summary>
        public string Reference { get; set; }

        /// <summary>
        /// Gets or sets the terms.
        /// </summary>
        public IEnumerable<AutocompleteTerm> Terms { get; set; }

        /// <summary>
        /// Gets or sets the types.
        /// </summary>
        public IEnumerable<string> Types { get; set; }
    }
}