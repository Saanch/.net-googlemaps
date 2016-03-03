// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GoogleMapsApiClient.cs" company="Sanu Sathyaseelan">
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
//   The google maps api client.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GoogleMaps.Net
{
    using System.Net.Http;
    using Directions;
    using Geocoding.Services;
    using Geocoding.Services.Contracts;
    using Places.Contracts;
    using Places.Services;
    using Shared;

    /// <summary>
    /// The google maps api client.
    /// </summary>
    public class GoogleMapsApiClient : DisposableObject, IGoogleMapsApiClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleMapsApiClient"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api key.
        /// </param>
        public GoogleMapsApiClient(string apiKey)
        {
            var url = EndPointUris.GetBaseUri();

            var httpClientHandler = new HttpClientHandler();
            var httpClient = new HttpClientAdapter(
                new HttpClient(httpClientHandler, true)
                {
                    BaseAddress = url
                });
            var webApi = new WebApi(httpClient, apiKey);
            PlaceSearch = new PlaceSearch(webApi);
            GeocodingService = new GeocodingService(webApi);
            DirectionsService = new DirectionsService(webApi);
        }

        /// <summary>
        /// Dispose of resources being used by the disposable object.
        /// </summary>
        /// <param name="disposing">
        /// Explicit disposal?
        /// </param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                PlaceSearch?.Dispose();
            }
        }

        /// <summary>
        /// Gets the place search.
        /// </summary>
        public IPlaceSearch PlaceSearch { get; }

        /// <summary>
        /// Gets the geocoding service.
        /// </summary>
        public IGeocodingService GeocodingService { get; }

        /// <summary>
        /// Gets the directions service.
        /// </summary>
        public IDirectionsService DirectionsService { get; }
    }
}