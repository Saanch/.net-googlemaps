using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace GoogleMaps.Net.Shared.Contracts
{
    /// <summary>
    /// The web API interface for communication with Google Maps API.
    /// </summary>
    public interface IWebApi : IDisposable
    {
        /// <summary>
        /// Invoke a Google Maps API operation using a HTTP GET request.
        /// </summary>
        /// <typeparam name="TResult">
        /// The XML-serialisable data contract type into which the response will be deserialised.
        /// </typeparam>
        /// <param name="relativeOperationUri">
        /// The operation URI (relative to the Google Maps API's base URI).
        /// </param>
        /// <returns>
        /// The operation result.
        /// </returns>
        Task<TResult> GetAsync<TResult>(Uri relativeOperationUri);

        Task<TResult> GetAsync<TResult>(string relativePath);

        Task<TResult> GetAsync<TResult>(string relativePath, NameValueCollection queryParams);

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
        Task<TResult> PostAsync<TObject, TResult>(Uri relativeOperationUri, TObject content);

        /// <summary>
        /// Invoke a Google Maps API operation using a HTTP POST request with string content
        /// </summary>
		/// <typeparam name="TResult">
		/// The XML-serialisable data contract type into which the response will be deserialised.
		/// </typeparam>
		/// <param name="relativeOperationUri">
		/// The operation URI (relative to the Google Maps API's base URI).
		/// </param>
		/// <param name="content">
		/// The content that will be passed as string in the body of the POST request.
		/// </param>
		/// <returns>
		/// The operation result.
		/// </returns>
        Task<TResult> PostAsync<TResult>(Uri relativeOperationUri, string content);
    }
}