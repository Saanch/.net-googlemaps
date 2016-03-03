// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LatLng.cs" company="Sanu Sathyaseelan">
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
//   The lat lng.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GoogleMaps.Net.Shared.Data
{
    using System;

    /// <summary>
    /// The lat lng.
    /// </summary>
    public class LatLng : IEquatable<LatLng>
    {
        /// <summary>
        /// Gets or sets the lat.
        /// </summary>
        public double Lat { get; set; }

        /// <summary>
        /// Gets or sets the lng.
        /// </summary>
        public double Lng { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LatLng"/> class.
        /// </summary>
        /// <param name="lat">
        /// The lat.
        /// </param>
        /// <param name="lng">
        /// The lng.
        /// </param>
        public LatLng(double lat, double lng)
        {
            Lat = lat;
            Lng = lng;
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        public override string ToString()
        {
            return Lat + "," + Lng;
        }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">
        /// An object to compare with this object.
        /// </param>
        public bool Equals(LatLng other)
        {
            return other != null && Lat.Equals(other.Lat) && Lng.Equals(other.Lng);
        }
    }
}