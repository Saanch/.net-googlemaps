using System.Threading.Tasks;
using GoogleMaps.Net.Directions.Response;

namespace GoogleMaps.Net.Directions
{
    public interface IDirectionsService
    {
        Task<DirectionResponse> GetDirection(string origin, string destination);
    }
}