namespace GoogleMaps.Net.Directions.Models
{
    public class Step
    {
        public TravelMode TravelMode { get; set; }
        public LatLng StartLocation { get; set; }

        public LatLng EndLocation { get; set; }
        public Polyline Polyline { get; set; }
        public Duration Duration { get; set; }
        public string HtmlInstructions { get; set; }
        public Duration Distance { get; set; }
    }
}