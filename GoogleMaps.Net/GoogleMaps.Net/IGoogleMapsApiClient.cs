using System;
using GoogleMaps.Net.Places.Contracts;

namespace GoogleMaps.Net
{
    public interface IGoogleMapsApiClient : IDisposable
    {
        IPlaceSerach PlaceSearch { get; }
    }
}