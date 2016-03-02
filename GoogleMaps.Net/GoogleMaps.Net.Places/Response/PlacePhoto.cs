using System.Collections.Generic;

namespace GoogleMaps.Net.Places.Response
{
    /// <summary>
    /// Represents a photo element of a Place.
    /// </summary>
    public class PlacePhoto
    {
        /// <summary>
        /// The height of the photo in pixels.
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Attribution text to be displayed for this photo.
        /// </summary>
        public IEnumerable<string> HtmlAttributions { get; set; }

        public string PhotoReference { get; set; }

        /// <summary>
        /// The width of the photo in pixels.
        /// </summary>
        public int Width { get; set; }
    }
}