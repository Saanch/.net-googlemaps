using GoogleMaps.Net.Shared.Contracts;

namespace GoogleMaps.Net.Directions
{
    public class DirectionsService : IDirectionsService
    {
        private readonly IWebApi _webApi;

        public DirectionsService(IWebApi webApi)
        {
            _webApi = webApi;
        }
    }
}