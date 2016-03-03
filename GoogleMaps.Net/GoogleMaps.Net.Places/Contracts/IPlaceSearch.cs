// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IPlaceSearch.cs" company="Sanu Sathyaseelan">
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
//   The PlaceSearch interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GoogleMaps.Net.Places.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Request;
    using Response;
    using Shared.Data;

    /// <summary>
    /// The PlaceSearch interface.
    /// </summary>
    public interface IPlaceSearch : IDisposable
    {
        /// <summary>
        /// The details.
        /// </summary>
        /// <param name="placeId">
        /// The place id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<PlaceDetailsResponse> Details(string placeId);

        /// <summary>
        /// The nearby search.
        /// </summary>
        /// <param name="location">
        /// The location.
        /// </param>
        /// <param name="radius">
        /// The radius.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<SearchResponse<NearbySearchResult>> NearbySearch(LatLng location, int radius);

        /// <summary>
        /// The nearby search.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<SearchResponse<NearbySearchResult>> NearbySearch(NearbySearchRequest request);

        /// <summary>
        /// The text search.
        /// </summary>
        /// <param name="query">
        /// The query.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<SearchResponse<TextSearchResult>> TextSearch(string query);

        /// <summary>
        /// The radar search by keyword.
        /// </summary>
        /// <param name="location">
        /// The location.
        /// </param>
        /// <param name="radius">
        /// The radius.
        /// </param>
        /// <param name="keyword">
        /// The keyword.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<RadarSearchResponse> RadarSearchByKeyword(LatLng location, int radius, string keyword);

        /// <summary>
        /// The radar search by name.
        /// </summary>
        /// <param name="location">
        /// The location.
        /// </param>
        /// <param name="radius">
        /// The radius.
        /// </param>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<RadarSearchResponse> RadarSearchByName(LatLng location, int radius, string name);

        /// <summary>
        /// The radar search by names.
        /// </summary>
        /// <param name="location">
        /// The location.
        /// </param>
        /// <param name="radius">
        /// The radius.
        /// </param>
        /// <param name="names">
        /// The names.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<RadarSearchResponse> RadarSearchByNames(LatLng location, int radius, IEnumerable<string> names);

        /// <summary>
        /// The radar search by type.
        /// </summary>
        /// <param name="location">
        /// The location.
        /// </param>
        /// <param name="radius">
        /// The radius.
        /// </param>
        /// <param name="type">
        /// The type.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<RadarSearchResponse> RadarSearchByType(LatLng location, int radius, string type);

        /// <summary>
        /// The radar search.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<RadarSearchResponse> RadarSearch(RadarSearchRequest request);

        /// <summary>
        /// The autocomplete.
        /// </summary>
        /// <param name="input">
        /// The input.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<AutocompleteResponse> Autocomplete(string input);
    }
}