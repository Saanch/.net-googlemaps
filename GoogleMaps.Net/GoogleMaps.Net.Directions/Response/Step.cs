// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Sanu Sathyaseelan">
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
//   The step.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GoogleMaps.Net.Directions.Response
{
    using Shared.Data;

    /// <summary>
    /// The step.
    /// </summary>
    public class Step
    {
        /// <summary>
        /// Gets or sets the distance.
        /// </summary>
        public TextValue Distance { get; set; }

        /// <summary>
        /// Gets or sets the duration.
        /// </summary>
        public TextValue Duration { get; set; }

        /// <summary>
        /// Gets or sets the end location.
        /// </summary>
        public LatLng EndLocation { get; set; }

        /// <summary>
        /// Gets or sets the html instructions.
        /// </summary>
        public string HtmlInstructions { get; set; }

        /// <summary>
        /// Gets or sets the polyline.
        /// </summary>
        public Polyline Polyline { get; set; }

        /// <summary>
        /// Gets or sets the start location.
        /// </summary>
        public LatLng StartLocation { get; set; }

        /// <summary>
        /// Gets or sets the travel mode.
        /// </summary>
        public TravelMode TravelMode { get; set; }
    }
}