using System.Collections.Generic;

namespace GoogleMaps.Net.Shared.Response
{
    public class ApiResult<T>
    {
        public IEnumerable<string> HtmlAttributions { get; set; }

        public T Result { get; set; }
        public PlacesServiceStatus Status { get; set; }

        public string ErrorMessage { get; set; }
    }
}