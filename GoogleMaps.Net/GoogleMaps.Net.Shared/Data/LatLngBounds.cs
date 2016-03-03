// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LatLngBounds.cs" company="Sanu Sathyaseelan">
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
//   The lat lng bounds.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GoogleMaps.Net.Shared.Data
{
    using System;

    /// <summary>
    /// The lat lng bounds.
    /// </summary>
    public class LatLngBounds : IEquatable<LatLngBounds>
    {
        /// <summary>
        /// East longitude in degrees. Values outside the range [-180, 180] will be wrapped to the range [-180, 180). For example, a value of -190 will be converted to 170. A value of 190 will be converted to -170. This reflects the fact that longitudes wrap around the globe.
        /// </summary>
        public double East { get; set; }

        /// <summary>
        /// North latitude in degrees. Values will be clamped to the range [-90, 90]. This means that if the value specified is less than -90, it will be set to -90. And if the value is greater than 90, it will be set to 90.
        /// </summary>
        public double North { get; set; }

        /// <summary>
        /// South latitude in degrees. Values will be clamped to the range [-90, 90]. This means that if the value specified is less than -90, it will be set to -90. And if the value is greater than 90, it will be set to 90.
        /// </summary>
        public double South { get; set; }

        /// <summary>
        /// West longitude in degrees. Values outside the range [-180, 180] will be wrapped to the range [-180, 180). For example, a value of -190 will be converted to 170. A value of 190 will be converted to -170. This reflects the fact that longitudes wrap around the globe.
        /// </summary>
        public double West { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LatLngBounds"/> class.
        /// </summary>
        /// <param name="east">
        /// The east.
        /// </param>
        /// <param name="north">
        /// The north.
        /// </param>
        /// <param name="south">
        /// The south.
        /// </param>
        /// <param name="west">
        /// The west.
        /// </param>
        public LatLngBounds(double east, double north, double south, double west)
        {
            East = east;
            North = north;
            South = south;
            West = west;
        }


        /// <summary>
        /// The to url string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string ToUrlString()
        {
            return $"{North},{East}|{South},{West}";
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
        public bool Equals(LatLngBounds other)
        {
            return other != null && East.Equals(other.East) && North.Equals(other.North) && South.Equals(other.South) && West.Equals(other.West);
        }
    }
}