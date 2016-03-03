// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HttpClientAdapter.cs" company="Sanu Sathyaseelan">
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
//   The http client adapter.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GoogleMaps.Net.Shared
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Contracts;

    /// <summary>
    /// The http client adapter.
    /// </summary>
    public class HttpClientAdapter : DisposableObject, IHttpClient
    {
        /// <summary>
        /// The underlying <see cref="HttpClient"/>.
        /// </summary>
        private readonly HttpClient _client;

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpClientAdapter"/> class. 
        /// Initialises a new instance of the <see cref="HttpClientAdapter"/> class. 
        /// Create a new <see cref="HttpClient"/> adaptor.
        /// </summary>
        /// <param name="client">
        /// The <see cref="HttpClient"/> wrapped by the adaptor.
        /// </param>
        public HttpClientAdapter(HttpClient client)
        {
            if (client == null)
                throw new ArgumentNullException(nameof(client));

            _client = client;
        }

        /// <summary>
        /// The base address used by the HTTP client.
        /// </summary>
        public Uri BaseAddress
        {
            get
            {
                this.CheckDisposed();

                return this._client.BaseAddress;
            }
        }

        /// <summary>
        /// The get async.
        /// </summary>
        /// <param name="uri">
        /// The uri.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public Task<HttpResponseMessage> GetAsync(Uri uri)
        {
            this.CheckDisposed();

            return this._client.GetAsync(uri);
        }

        /// <summary>
        /// The delete async.
        /// </summary>
        /// <param name="uri">
        /// The uri.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public Task<HttpResponseMessage> DeleteAsync(Uri uri)
        {
            this.CheckDisposed();

            return this._client.DeleteAsync(uri);
        }

        /// <summary>
        /// The put async.
        /// </summary>
        /// <param name="uri">
        /// The uri.
        /// </param>
        /// <param name="content">
        /// The content.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public Task<HttpResponseMessage> PutAsync(Uri uri, HttpContent content)
        {
            this.CheckDisposed();

            return this._client.PutAsync(uri, content);
        }

        /// <summary>
        /// The post async.
        /// </summary>
        /// <param name="uri">
        /// The uri.
        /// </param>
        /// <param name="content">
        /// The content.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public Task<HttpResponseMessage> PostAsync(Uri uri, HttpContent content)
        {
            this.CheckDisposed();

            return this._client.PostAsync(uri, content);
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
                _client.Dispose();
        }
    }
}