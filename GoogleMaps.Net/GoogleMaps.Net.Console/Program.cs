// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Sanu Sathyaseelan">
//   The MIT License (MIT)
//   
//   Copyright (c) 2016 Sanu Sathyaseelan
//   
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//   of this software and associated documentation files (the "Software"), to deal
//   in the Software without restriction, including without limitation the rights
//   to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//   copies of the Software, and to permit persons to whom the Software is
//   furnished to do so, subject to the following conditions:
//   
//   The above copyright notice and this permission notice shall be included in all
//   copies or substantial portions of the Software.
//   
//   THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//   IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//   FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//   AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//   LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//   OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//   SOFTWARE.
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GoogleMaps.Net.Console
{
    using Newtonsoft.Json;
    using Shared.Data;

    /// <summary>
    /// The program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        private static void Main(string[] args)
        {
            // var url = new Uri("https://maps.googleapis.com/maps/");

            // var httpClientHandler = new HttpClientHandler();
            // var httpClient = new HttpClientAdapter(new HttpClient(
            // httpClientHandler, disposeHandler: true)
            // {
            // BaseAddress = url
            // });
            // var webapi = new WebApi(httpClient, "AIzaSyAkQzokNWcuyH4wa6nT5mclfsmdpMAjOZc");
            // var places = new PlaceSearch(webapi);
            // var details = places.Details(string.Empty).Result;
            using (var client = new GoogleMapsApiClient("AIzaSyAkQzokNWcuyH4wa6nT5mclfsmdpMAjOZc"))
            {
                var places = client.PlaceSearch;

// var details = places.Details("ChIJN1t_tDeuEmsRUsoyG83frY4").Result;
                var location = new LatLng(-33.8670522, 151.1957362);

// var request = new NearbySearchRequest
                // {
                // Location = location,
                // Type = "restaurant",
                // OpenNow = true,
                // Radius = 5000
                // };
                // var details = places.NearbySearch(request).Result;
                // var json = JsonConvert.SerializeObject(details, Formatting.Indented);
                // System.Console.WriteLine(json);

                // var search = places.TextSearch("restaurants in Sydney").Result;
                // json = JsonConvert.SerializeObject(search, Formatting.Indented);
                // System.Console.WriteLine(json);


                // var names = new[] {"sydney"};

                // var radarsearch = places.RadarSearchByNames(location, 5000, names).Result;
                // var json = JsonConvert.SerializeObject(radarsearch, Formatting.Indented);
                // System.Console.WriteLine(json);
                // System.Console.WriteLine("Total: "+radarsearch.Results.Count());

                // var request = new RadarSearchRequest
                // {
                // Location = location,
                // Type = "restaurant",
                // Keyword = "vegetarian",
                // OpenNow = true,
                // Radius = 5000
                // };
                // var radarsearch = places.RadarSearch(request).Result;
                // var json = JsonConvert.SerializeObject(radarsearch, Formatting.Indented);
                // System.Console.WriteLine(json);
                // System.Console.WriteLine("Total: " + radarsearch.Results.Count());

                // var radarsearch = places.Autocomplete("sydney").Result;
                // var json = JsonConvert.SerializeObject(radarsearch, Formatting.Indented);
                // System.Console.WriteLine(json);
                // System.Console.WriteLine("Total: " + radarsearch.Predictions.Count());

                // var radarsearch = client.GeocodingService.Geocode("sydney").Result;
                // var json = JsonConvert.SerializeObject(radarsearch, Formatting.Indented);
                // System.Console.WriteLine(json);
                var directions = client.DirectionsService.GetDirection("sydney", "north ryde").Result;
                var json = JsonConvert.SerializeObject(directions, Formatting.Indented);
                System.Console.WriteLine(json);
            }

            System.Console.ReadKey();
        }
    }
}