// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceStatus.cs" company="Sanu Sathyaseelan">
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
//   The status returned by the PlacesService on the completion of its searches.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

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

        /// <summary>
        /// The no t_ found.
        /// </summary>
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