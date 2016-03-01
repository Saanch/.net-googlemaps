﻿using GoogleMaps.Net.Places.Response;
using GoogleMaps.Net.Shared.Data;

namespace GoogleMaps.Net.Places.Request
{
    /// <summary>
    /// A Radar Search request to be sent to the PlacesService.
    /// </summary>
    public class RadarSearchRequest
    {
        /// <summary>
        /// Bounds used to bias results when searching for Places (optional). Both location and radius will be ignored if bounds is set. Results will not be restricted to those inside these bounds; but, results inside it will rank higher.
        /// </summary>
        public LatLngBounds Bounds { get; set; }
        /// <summary>
        /// A term to be matched against all available fields, including but not limited to name, type, and address, as well as customer reviews and other third-party content.
        /// </summary>
        public string Keyword { get; set; }
        /// <summary>
        /// The center of the area used to bias results when searching for Places.
        /// </summary>
        public LatLng Location { get; set; }

        /// <summary>
        /// Restricts results to Places that include this text in the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The radius of the area used to bias results when searching for Places, in meters.
        /// </summary>
        public int Radius { get; set; }

        /// <summary>
        /// Searches for places of the given type. The type will be translated to the local language of the request's target location and used as query. If a query is also provided, it will be concatenated to the localized type string. Results of a different type will be dropped from the response. Use this to search for language and region independent categorical search.
        /// </summary>
        public string Type { get; set; }
    }
}