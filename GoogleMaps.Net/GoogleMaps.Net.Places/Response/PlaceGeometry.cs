using GoogleMaps.Net.Shared.Data;

namespace GoogleMaps.Net.Places.Response
{
    /// <summary>
    /// Defines information about the geometry of a Place.
    /// </summary>
    public class PlaceGeometry
    {
        /// <summary>
        /// The Place's position.
        /// </summary>
        public LatLng Location { get; set; }

        /// <summary>
        /// The preferred viewport when displaying this Place on a map. This property will be null if the preferred viewport for the Place is not known.
        /// </summary>
        public LatLngBounds Viewport { get; set; }
    }
}