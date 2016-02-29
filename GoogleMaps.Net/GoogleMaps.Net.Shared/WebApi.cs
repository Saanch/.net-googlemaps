using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using GoogleMaps.Net.Shared.Contracts;
using GoogleMaps.Net.Shared.Extensions;
using Newtonsoft.Json.Serialization;
using static System.String;

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
            // Work around for handling cases where Cloud control api returns non utf-8 characters 
            // in the xml response marked as utf-8
            var xmlFormatter = new XmlMediaTypeFormatter();
            xmlFormatter.SupportedEncodings.Clear();
            xmlFormatter.SupportedEncodings.Add((Encoding)new UTF8Encoding(false, false));
            xmlFormatter.SupportedEncodings.Add((Encoding)new UnicodeEncoding(false, true, false));

            var jsonMediaTypeFormatter = new JsonMediaTypeFormatter();
            jsonMediaTypeFormatter.SerializerSettings.ContractResolver = new SnakeCaseContractResolver();

            _mediaTypeFormatters = new MediaTypeFormatterCollection(
                new MediaTypeFormatter[2]
                {
                    xmlFormatter,
                    jsonMediaTypeFormatter
                });
            _mediaTypeFormatters.XmlFormatter.UseXmlSerializer = true;
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="WebApi"/> class.
        /// </summary>
        /// <param name="client">
        /// The client.
        /// </param>
        /// <param name="apiKey">The API Key</param>
        public WebApi(IHttpClient client, string apiKey)
            : this()
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
        /// <param name="pagingOptions">
        /// The paging options.
        /// </param>
		/// <param name="filteringOptions">
		/// The filtering options.
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
        public async Task<TResult> GetAsync<TResult>(Uri relativeOperationUri)
        {
            if (relativeOperationUri == null)
                throw new ArgumentNullException(nameof(relativeOperationUri));

            if (relativeOperationUri.IsAbsoluteUri)
                throw new ArgumentException("The supplied URI is not a relative URI.", nameof(relativeOperationUri));

            using (HttpResponseMessage response = await _httpClient.GetAsync(relativeOperationUri))
            {
                if (!response.IsSuccessStatusCode)
                {
                    await HandleApiRequestErrors(response, relativeOperationUri);
                }

                if (typeof(TResult) == typeof(string))
                {
                    return (TResult)(object)(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    return await ReadResponseAsync<TResult>(response.Content);
                }
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
            var query = new StringBuilder();
            const string sepChar = "&";
            string sep = Empty;
            foreach (var key in queryParams.AllKeys)
            {
                query.Append(sep).Append(key).Append('=').Append(queryParams[key]);
                sep = sepChar;
            }

            var realtivePathWithQuery = path + "?" + query;
            return new Uri(realtivePathWithQuery, UriKind.Relative);
        }

        /// <summary>
        /// Invoke a Google Maps API operation using a HTTP POST request.
        /// </summary>
        /// <typeparam name="TObject">
        /// The XML-Serialisable data contract type that the request will be sent.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The XML-serialisable data contract type into which the response will be deserialised.
        /// </typeparam>
        /// <param name="relativeOperationUri">
        /// The operation URI (relative to the Google Maps API's base URI).
        /// </param>
        /// <param name="content">
        /// The content that will be deserialised and passed in the body of the POST request.
        /// </param>
        /// <returns>
        /// The operation result.
        /// </returns>
        public async Task<TResult> PostAsync<TObject, TResult>(Uri relativeOperationUri, TObject content)
        {
            ObjectContent<TObject> objectContent = new ObjectContent<TObject>(content, _mediaTypeFormatters.XmlFormatter);
            using (
                HttpResponseMessage response =
                    await
                        _httpClient.PostAsync(relativeOperationUri, objectContent))
            {
                if (!response.IsSuccessStatusCode)
                {
                    await HandleApiRequestErrors(response, relativeOperationUri);
                }

                return await ReadResponseAsync<TResult>(response.Content);
            }
        }

        /// <summary>
        /// Invoke a Google Maps API operation using a HTTP POST request.
        /// </summary>
        /// <typeparam name="TResult">
        /// The XML-serialisable data contract type into which the response will be deserialised.
        /// </typeparam>
        /// <param name="relativeOperationUri">
        /// The operation URI (relative to the Google Maps API's base URI).
        /// </param>
        /// <param name="content">
        /// The content that will be deserialised and passed in the body of the POST request.
        /// </param>
        /// <returns>
        /// The operation result.
        /// </returns>
        public async Task<TResult> PostAsync<TResult>(Uri relativeOperationUri, string content)
        {
            var objectContent = new ObjectContent<string>(content, new JsonMediaTypeFormatter());
            using (
                HttpResponseMessage response =
                    await
                        _httpClient.PostAsync(relativeOperationUri, objectContent))
            {
                if (!response.IsSuccessStatusCode)
                    await HandleApiRequestErrors(response, relativeOperationUri);

                return await ReadResponseAsync<TResult>(response.Content);
            }
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
                        throw new HttpRequestException(
                            Format(
                                "Google Maps API returned HTTP status code {0} ({1}) when performing {2} {3} on '{4}'.",
                                (int)response.StatusCode,
                                response.StatusCode,
                                response.RequestMessage.RequestUri.Scheme,
                                response.RequestMessage.Method,
                                response.RequestMessage.RequestUri));
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
            Exception originalException = null;
            try
            {
                Debug.WriteLine(await content.ReadAsStringAsync());
                return await content.ReadAsAsync<TResult>(_mediaTypeFormatters);
            }
            catch (Exception ex)
            {
                originalException = ex;
            }

            try
            {
                var decoderException = originalException.InnerException != null
                    ? originalException.InnerException.InnerException as System.Text.DecoderFallbackException
                    : null;
                // This is only a work-around the utf-8 encoding error   
                if (decoderException == null || !decoderException.StackTrace.Contains("UTF8Encoding"))
                    ExceptionDispatchInfo.Capture(originalException).Throw();

                return await ReadResponseUtf8WorkAroundAsync<TResult>(content);

            }
            catch (Exception)
            {
                // ignoring any exceptions that happen while the workaround is running
            }

            ExceptionDispatchInfo.Capture(originalException).Throw();
            // this is just dummy
            return await Task.FromResult(default(TResult));
        }

        /// <summary>
        /// Read response as string then convert to type, utf-8 encoding error work around
        /// </summary>
        /// <typeparam name="TResult">Result type</typeparam>
        /// <param name="content">Http content</param>
        /// <returns>Response task</returns>
        private async Task<TResult> ReadResponseUtf8WorkAroundAsync<TResult>(HttpContent content)
        {
            // This is work-around for handling Unicode characters being passed as ansi in utf-8 stream.
            // eg: \xE8 = 'è' but the utf-8 encoding should be \xc3a8, this causes the ut8 parser to fail
            // but string parser handles it well and replaces it with "\xFFFD"
            MediaTypeHeaderValue mediaType = content.Headers.ContentType ?? new MediaTypeHeaderValue("text/xml");

            var formatter = new MediaTypeFormatterCollection(_mediaTypeFormatters).FindReader(typeof(TResult),
                mediaType);

            if (formatter == null)
                throw new InvalidOperationException("Do not support non XMLMediaTypeFormatter");

            var contentText = await content.ReadAsStringAsync();
            if (IsNullOrEmpty(contentText))
                throw new InvalidOperationException("Do not support work around on empty content");

            // this is only supporting Utf-8 encoding
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(contentText));
            return
                (TResult)
                    (object)
                        (await
                            formatter.ReadFromStreamAsync(typeof(TResult), ms, content, null));
        }
    }

    internal class InvalidCredentialsException : Exception
    {
        public InvalidCredentialsException(Uri uri)
        {
            throw new NotImplementedException();
        }
    }
}