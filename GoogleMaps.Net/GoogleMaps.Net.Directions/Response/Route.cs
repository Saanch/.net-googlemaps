// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Route.cs" company="Sanu Sathyaseelan">
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
//   The route.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GoogleMaps.Net.Directions.Response
{
    using System.Collections.Generic;
    using Shared.Data;

    /// <summary>
    /// The route.
    /// </summary>
    public class Route
    {
        /// <summary>
        /// Gets or sets the bounds.
        /// </summary>
        public Viewport Bounds { get; set; }

        /// <summary>
        /// Gets or sets the copyrights.
        /// </summary>
        public string Copyrights { get; set; }

        /// <summary>
        /// Gets or sets the legs.
        /// </summary>
        public IEnumerable<Leg> Legs { get; set; }

        /// <summary>
        /// Gets or sets the overview polyline.
        /// </summary>
        public Polyline OverviewPolyline { get; set; }

        /// <summary>
        /// Gets or sets the summary.
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Gets or sets the warnings.
        /// </summary>
        public IEnumerable<string> Warnings { get; set; }

        /// <summary>
        /// Gets or sets the waypoint order.
        /// </summary>
        public IEnumerable<int> WaypointOrder { get; set; }
    }
}