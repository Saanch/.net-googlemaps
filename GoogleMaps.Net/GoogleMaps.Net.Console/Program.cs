﻿using Newtonsoft.Json;

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
                var details = places.Details("ChIJN1t_tDeuEmsRUsoyG83frY4").Result;
                var json = JsonConvert.SerializeObject(details, Formatting.Indented);
                System.Console.WriteLine(json);
            }

            System.Console.ReadKey();
        }
    }
}