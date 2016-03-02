using System;

namespace GoogleMaps.Net.Shared.Data
{
    public class Period
    {
        /// <summary>
        /// a number from 0–6, corresponding to the days of the week, starting on Sunday. For example, 2 means Tuesday.
        /// </summary>
        public DayOfWeek Day { get; set; }
        /// <summary>
        /// may contain a time of day in 24-hour hhmm format. Values are in the range 0000–2359. The time will be reported in the place’s time zone.
        /// </summary>
        public int Time { get; set; }
    }
}