namespace GoogleMaps.Net.Shared.Data
{
    /// <summary>
    /// The status returned by the PlacesService on the completion of its searches.
    /// </summary>
    public enum ServiceStatus
    {
        /// <summary>
        /// Error.
        /// </summary>
        ERROR,

        /// <summary>
        /// This request was invalid.
        /// </summary>
        INVALID_REQUEST,

        /// <summary>
        /// The response contains a valid result.
        /// </summary>
        OK,

        /// <summary>
        /// The application has gone over its request quota.
        /// </summary>
        OVER_QUERY_LIMIT,
        NOT_FOUND,

        /// <summary>
        /// The application is not allowed to use the PlacesService.
        /// </summary>
        REQUEST_DENIED,

        /// <summary>
        /// The PlacesService request could not be processed due to a server error. The request may succeed if you try again.
        /// </summary>
        UNKNOWN_ERROR,

        /// <summary>
        /// No result was found for this request.
        /// </summary>
        ZERO_RESULTS
    }
}