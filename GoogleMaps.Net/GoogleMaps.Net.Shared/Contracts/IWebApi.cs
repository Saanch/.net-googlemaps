using System;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace GoogleMaps.Net.Shared.Contracts
{
    /// <summary>
    /// The web API interface for communication with Google Maps API.
    /// </summary>
    public interface IWebApi : IDisposable
    {
        Task<TResult> GetAsync<TResult>(string relativePath);

        Task<TResult> GetAsync<TResult>(string relativePath, NameValueCollection queryParams);
    }
}