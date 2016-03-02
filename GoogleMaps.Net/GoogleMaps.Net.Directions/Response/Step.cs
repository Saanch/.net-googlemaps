using GoogleMaps.Net.Shared.Data;

namespace GoogleMaps.Net.Directions.Response
{
    public class Step
    {
        public TextValue Distance { get; set; }
        public TextValue Duration { get; set; }
        public LatLng EndLocation { get; set; }
        public string HtmlInstructions { get; set; }
        public Polyline Polyline { get; set; }
        public LatLng StartLocation { get; set; }
        public TravelMode TravelMode { get; set; }
    }
}