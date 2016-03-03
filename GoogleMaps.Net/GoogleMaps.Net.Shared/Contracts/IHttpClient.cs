// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IHttpClient.cs" company="Sanu Sathyaseelan">
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
//   The HttpClient interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GoogleMaps.Net.Shared.Contracts
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;

    /// <summary>
    /// The HttpClient interface.
    /// </summary>
    public interface IHttpClient : IDisposable
    {
        /// <summary>
        /// The base address used by the HTTP client.
        /// </summary>
        Uri BaseAddress { get; }

        /// <summary>
        /// Get asynchronously
        /// </summary>
        /// <param name="uri">
        /// The URI
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<HttpResponseMessage> GetAsync(Uri uri);

        /// <summary>
        /// Delete asynchronously
        /// </summary>
        /// <param name="uri">
        /// The URI
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<HttpResponseMessage> DeleteAsync(Uri uri);

        /// <summary>
        /// Put asynchronously
        /// </summary>
        /// <param name="uri">
        /// The URI
        /// </param>
        /// <param name="content">
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<HttpResponseMessage> PutAsync(Uri uri, HttpContent content);

        /// <summary>
        /// Post asynchronously
        /// </summary>
        /// <param name="uri">
        /// The URI
        /// </param>
        /// <param name="content">
        /// The content to post
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<HttpResponseMessage> PostAsync(Uri uri, HttpContent content);
    }
}