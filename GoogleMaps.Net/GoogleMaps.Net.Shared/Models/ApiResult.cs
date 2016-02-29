using System.Collections.Generic;
using System.Security.AccessControl;
using Newtonsoft.Json;

namespace GoogleMaps.Net.Shared.Models
{
    public class ApiResult<T>
    {
        [JsonProperty("html_attributions")]
        public IEnumerable<string> HtmlAttributions { get; set; }

        public T Result { get; set; }
        public PlacesServiceStatus Status { get; set; }

        public string ErrorMessage { get; set; }
    }
}