using System;
using System.Threading.Tasks;
using GoogleMaps.Net.Places.Response;

namespace GoogleMaps.Net.Places.Contracts
{
    public interface IPlaceSerach : IDisposable
    {
        Task<PlaceDetailsResponse> Details(string placeId);
    }
}