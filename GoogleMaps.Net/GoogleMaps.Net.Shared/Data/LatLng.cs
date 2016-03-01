using System;

namespace GoogleMaps.Net.Shared.Data
{
    public class LatLng : IEquatable<LatLng>
    {
        public double Lat { get; set; }
        public double Lng { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LatLng"/> class.
        /// </summary>
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
        /// <param name="other">An object to compare with this object.</param>
        public bool Equals(LatLng other)
        {
            return other != null && Lat.Equals(other.Lat) && Lng.Equals(other.Lng);
        }
    }
}