// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DirectionRequest.cs" company="Sanu Sathyaseelan">
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
//   The direction request.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GoogleMaps.Net.Directions.Request
{
    using Response;

    /// <summary>
    /// The direction request.
    /// </summary>
    public class DirectionRequest
    {
        /// <summary>
        /// Gets or sets the orgigin.
        /// </summary>
        public string Orgigin { get; set; }

        /// <summary>
        /// Gets or sets the destination.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Gets or sets the mode.
        /// </summary>
        public TravelMode? Mode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether alternatives.
        /// </summary>
        public bool Alternatives { get; set; }
    }
}