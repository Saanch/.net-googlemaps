using System.Collections.Generic;

namespace GoogleMaps.Net.Shared.Data
{
    public class OpeningHours
    {
        public bool OpenNow { get; set; }
        public IEnumerable<OpenDuration> Periods { get; set; }
        public IEnumerable<string> WeekdayText { get; set; }
    }
}