using System;
using System.Threading.Tasks;
using GoogleMaps.Net.Places.Models;
using GoogleMaps.Net.Shared.Models;

namespace GoogleMaps.Net.Places.Contracts
{
    public interface IPlaceSerach : IDisposable
    {
        Task<ApiResult<PlaceResult>> Details(string placeId);
    }
}