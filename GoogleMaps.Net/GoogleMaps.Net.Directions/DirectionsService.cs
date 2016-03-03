// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DirectionsService.cs" company="Sanu Sathyaseelan">
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
//   The directions service.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GoogleMaps.Net.Directions
{
    using System.Collections.Specialized;
    using System.Threading.Tasks;
    using Response;
    using Shared;
    using Shared.Contracts;

    /// <summary>
    /// The directions service.
    /// </summary>
    public class DirectionsService : IDirectionsService
    {
        /// <summary>
        /// The _web api.
        /// </summary>
        private readonly IWebApi _webApi;

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectionsService"/> class.
        /// </summary>
        /// <param name="webApi">
        /// The web api.
        /// </param>
        public DirectionsService(IWebApi webApi)
        {
            _webApi = webApi;
        }

        /// <summary>
        /// The get direction.
        /// </summary>
        /// <param name="origin">
        /// The origin.
        /// </param>
        /// <param name="destination">
        /// The destination.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<DirectionResponse> GetDirection(string origin, string destination)
        {
            var queryParams = new NameValueCollection {{"origin", origin}, {"destination", destination}};
            return await _webApi.GetAsync<DirectionResponse>(EndPointUris.Directions, queryParams);
        }
    }
}