using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using GoogleMaps.Net.Shared.Contracts;

namespace GoogleMaps.Net.Shared
{
    public class WebApi : DisposableObject, IWebApi
    {
        /// <summary>
        /// Media type formatters used to serialise and deserialise data contracts.
        /// </summary>
        private readonly MediaTypeFormatterCollection _mediaTypeFormatters;

        /// <summary>
        /// The <see cref="HttpClient"/> used to communicate with the Google Maps API.
        /// </summary>
        private IHttpClient _httpClient;

        private readonly string _apiKey;

        /// <summary>
        /// Initialises a new instance of the <see cref="WebApi"/> class.
        /// </summary>
        private WebApi()
        {
            var jsonMediaTypeFormatter = new JsonMediaTypeFormatter {SerializerSettings = {ContractResolver = new SnakeCaseContractResolver()}};
            _mediaTypeFormatters = new MediaTypeFormatterCollection(
                new MediaTypeFormatter[1]
                {
                    jsonMediaTypeFormatter
                });
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="WebApi"/> class.
        /// </summary>
        /// <param name="client">
        /// The client.
        /// </param>
        /// <param name="apiKey">The API Key</param>
        public WebApi(IHttpClient client, string apiKey) : this()
        {
            _httpClient = client;
            _apiKey = apiKey;
        }


        /// <summary>
        /// The get async.
        /// </summary>
        /// <param name="relativeOperationUri">
        /// The relative operation uri.
        /// </param>
        /// <typeparam name="TResult">
        /// Result from the Get call
        /// </typeparam>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// </exception>
        /// <exception cref="ArgumentException">
        /// </exception>
        /// <exception cref="HttpRequestException">
        /// </exception>
        private async Task<TResult> GetAsync<TResult>(Uri relativeOperationUri)
        {
            if (relativeOperationUri == null)
                throw new ArgumentNullException(nameof(relativeOperationUri));

            if (relativeOperationUri.IsAbsoluteUri)
                throw new ArgumentException("The supplied URI is not a relative URI.", nameof(relativeOperationUri));

            Debug.WriteLine(_httpClient.BaseAddress + relativeOperationUri.OriginalString);

            using (HttpResponseMessage response = await _httpClient.GetAsync(relativeOperationUri))
            {
                if (!response.IsSuccessStatusCode)
                {
                    await HandleApiRequestErrors(response, relativeOperationUri);
                }

                if (typeof (TResult) == typeof (string))
                {
                    return (TResult) (object) (await response.Content.ReadAsStringAsync());
                }
                return await ReadResponseAsync<TResult>(response.Content);
            }
        }

        public Task<TResult> GetAsync<TResult>(string relativePath)
        {
            throw new NotImplementedException();
        }

        public Task<TResult> GetAsync<TResult>(string relativePath, NameValueCollection queryParams)
        {
            queryParams.Add("key", _apiKey);
            var uri = CreateUri(relativePath, queryParams);
            return GetAsync<TResult>(uri);
        }

        private Uri CreateUri(string path)
        {
            return new Uri(path, UriKind.Relative);
        }

        private Uri CreateUri(string path, NameValueCollection queryParams)
        {
            var query = string.Join("&", queryParams.AllKeys.Select(key => key + "=" + queryParams[key]));
            var realtivePathWithQuery = string.IsNullOrEmpty(query) ? path : path + "?" + query;
            return new Uri(realtivePathWithQuery, UriKind.Relative);
        }

       
        /// <summary>
        /// Dispose of resources being used by the Google Maps API client.
        /// </summary>
        /// <param name="disposing">
        /// Explicit disposal?
        /// </param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_httpClient != null)
                {
                    _httpClient.Dispose();
                    _httpClient = null;
                }
            }
        }

        /// <summary>
        /// The handle api request errors.
        /// </summary>
        /// <param name="response">
        /// The response.
        /// </param>
        /// <param name="uri">
        /// The uri.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        /// <exception cref="InvalidCredentialsException">
        /// </exception>
        /// <exception cref="HttpRequestException">
        /// </exception>
        private async Task HandleApiRequestErrors(HttpResponseMessage response, Uri uri)
        {
            switch (response.StatusCode)
            {
                case HttpStatusCode.Unauthorized:
                {
                    throw new InvalidCredentialsException(uri);
                }

                //case HttpStatusCode.BadRequest:
                //    {
                //        // Handle specific Google Maps API Status response when posting a bad request
                //        if (uri.ToString().StartsWith(ApiUris.Todo))
                //        {
                //            Status status = await response.Content.ReadAsAsync<Status>(_mediaTypeFormatters);
                //            throw new BadRequestException(status, uri);
                //        }
                //        ResponseType responseMessage = await ReadResponseAsync<ResponseType>(response.Content);
                //        throw new BadRequestException(responseMessage, uri);
                //    }

                default:
                {
                    throw new HttpRequestException($"Google Maps API returned HTTP status code {response.StatusCode} ({response.RequestMessage.RequestUri.Scheme}) when performing {response.RequestMessage.RequestUri.Scheme} {response.RequestMessage.Method} on '{response.RequestMessage.RequestUri}'.");
                }
            }
        }

        /// <summary>
        /// Read response with utf-8 encoding workaround
        /// </summary>
        /// <typeparam name="TResult">Result type</typeparam>
        /// <param name="content">Http content</param>
        /// <returns>Response task</returns>
        private async Task<TResult> ReadResponseAsync<TResult>(HttpContent content)
        {
            Exception originalException;
            try
            {
                return await content.ReadAsAsync<TResult>(_mediaTypeFormatters);
            }
            catch (Exception ex)
            {
                originalException = ex;
            }

            ExceptionDispatchInfo.Capture(originalException).Throw();
            // this is just dummy
            return await Task.FromResult(default(TResult));
        }


        internal class InvalidCredentialsException : Exception
        {
            public InvalidCredentialsException(Uri uri)
            {
                throw new NotImplementedException();
            }
        }
    }
}