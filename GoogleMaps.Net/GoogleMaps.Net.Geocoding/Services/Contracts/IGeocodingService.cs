using System.Threading.Tasks;
using GoogleMaps.Net.Geocoding.Response;

namespace GoogleMaps.Net.Geocoding.Services.Contracts
{
    public interface IGeocodingService
    {
        Task<GeocodingResponse> Geocode(string address);
    }
}