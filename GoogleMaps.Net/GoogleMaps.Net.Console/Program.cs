using System.Linq;
using GoogleMaps.Net.Geocoding.Services;
using GoogleMaps.Net.Places.Request;
using GoogleMaps.Net.Shared.Data;
using Newtonsoft.Json;

namespace GoogleMaps.Net.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //var url = new Uri("https://maps.googleapis.com/maps/");

            //var httpClientHandler = new HttpClientHandler();
            //var httpClient = new HttpClientAdapter(new HttpClient(
            //        httpClientHandler, disposeHandler: true)
            //{
            //    BaseAddress = url
            //});
            //var webapi = new WebApi(httpClient, "AIzaSyAkQzokNWcuyH4wa6nT5mclfsmdpMAjOZc");
            //var places = new PlaceSearch(webapi);
            //var details = places.Details(string.Empty).Result;

            using (var client = new GoogleMapsApiClient("AIzaSyAkQzokNWcuyH4wa6nT5mclfsmdpMAjOZc"))
            {
                var places = client.PlaceSearch;
                //var details = places.Details("ChIJN1t_tDeuEmsRUsoyG83frY4").Result;
                var location = new LatLng(-33.8670522, 151.1957362);
                //var request = new NearbySearchRequest
                //{
                //    Location = location,
                //    Type = "restaurant",
                //    OpenNow = true,
                //    Radius = 5000
                //};
                //var details = places.NearbySearch(request).Result;
                //var json = JsonConvert.SerializeObject(details, Formatting.Indented);
                //System.Console.WriteLine(json);

                //var search = places.TextSearch("restaurants in Sydney").Result;
                //json = JsonConvert.SerializeObject(search, Formatting.Indented);
                //System.Console.WriteLine(json);


                //var names = new[] {"sydney"};
                
                //var radarsearch = places.RadarSearchByNames(location, 5000, names).Result;
                //var json = JsonConvert.SerializeObject(radarsearch, Formatting.Indented);
                //System.Console.WriteLine(json);
                //System.Console.WriteLine("Total: "+radarsearch.Results.Count());

                //var request = new RadarSearchRequest
                //{
                //    Location = location,
                //    Type = "restaurant",
                //    Keyword = "vegetarian",
                //    OpenNow = true,
                //    Radius = 5000
                //};
                //var radarsearch = places.RadarSearch(request).Result;
                //var json = JsonConvert.SerializeObject(radarsearch, Formatting.Indented);
                //System.Console.WriteLine(json);
                //System.Console.WriteLine("Total: " + radarsearch.Results.Count());

                //var radarsearch = places.Autocomplete("sydney").Result;
                //var json = JsonConvert.SerializeObject(radarsearch, Formatting.Indented);
                //System.Console.WriteLine(json);
                //System.Console.WriteLine("Total: " + radarsearch.Predictions.Count());

                //var radarsearch = client.GeocodingService.Geocode("sydney").Result;
                //var json = JsonConvert.SerializeObject(radarsearch, Formatting.Indented);
                //System.Console.WriteLine(json);

                var directions = client.DirectionsService.GetDirection("sydney", "north ryde").Result;
                var json = JsonConvert.SerializeObject(directions, Formatting.Indented);
                System.Console.WriteLine(json);

            }

            System.Console.ReadKey();
        }
    }
}