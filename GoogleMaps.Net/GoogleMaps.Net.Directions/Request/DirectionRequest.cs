using GoogleMaps.Net.Directions.Response;

namespace GoogleMaps.Net.Directions.Request
{
    public class DirectionRequest
    {
        public string Orgigin { get; set; }
        public string Destination { get; set; }

        public TravelMode? Mode { get; set; }
        public bool Alternatives { get; set; }
    }
}