using System;

namespace GoogleMaps.Net.Shared.Data
{
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
        public LatLngBounds(double east, double north, double south, double west)
        {
            East = east;
            North = north;
            South = south;
            West = west;
        }


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
        /// <param name="other">An object to compare with this object.</param>
        public bool Equals(LatLngBounds other)
        {
            return other != null && East.Equals(other.East) && North.Equals(other.North) && South.Equals(other.South) && West.Equals(other.West);
        }
    }
}