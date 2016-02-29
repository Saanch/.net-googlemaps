﻿using System;
using System.Net.Http;
using GoogleMaps.Net.Places.Contracts;
using GoogleMaps.Net.Places.Services;
using GoogleMaps.Net.Shared;

namespace GoogleMaps.Net
{
    public class GoogleMapsApiClient : DisposableObject, IGoogleMapsApiClient
    {
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

        public IPlaceSerach PlaceSearch { get; }
    }
}