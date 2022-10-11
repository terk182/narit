using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class OverTimeMultiplyRate
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public double ForHolidayOfficeHoursRate { get; set; }
        public double ForHolidayAfterHoursRate { get; set; }
        public double ForWorkDayAfterHoursRate { get; set; }
        public TimeSpan ForHolidayOfficeHoursMaxTime { get; set; }
        public TimeSpan ForHolidayAfterHoursMaxTime { get; set; }
        public TimeSpan ForWorkDayAfterHoursMaxTime { get; set; }
    }
}
