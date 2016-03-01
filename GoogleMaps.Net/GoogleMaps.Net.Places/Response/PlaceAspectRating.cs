namespace GoogleMaps.Net.Places.Response
{
    /// <summary>
    /// Defines information about an aspect of the place that users have reviewed.
    /// </summary>
    public class PlaceAspectRating
    {
        /// <summary>
        /// The rating of this aspect. For individual reviews this is an integer from 0 to 3. For aggregated ratings of a place this is an integer from 0 to 30.
        /// </summary>
        public int Rating { get; set; }

        /// <summary>
        /// The aspect type, e.g. "food", "decor", "service", "overall".
        /// </summary>
        public string Type { get; set; }
    }
}