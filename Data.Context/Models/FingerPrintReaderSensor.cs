using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class FingerPrintReaderSensor
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int SensorId { get; set; }
        public string Place { get; set; } = null!;
        public string Remark { get; set; } = null!;
        public DateTime LastSourceCheckTimeRead { get; set; }
    }
}
