using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class Itinerary
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public string StartingPoint { get; set; } = null!;
        public string Destination { get; set; } = null!;
        public string Distance { get; set; } = null!;
        public string Fare { get; set; } = null!;
        public string VehicleTypeEnum { get; set; } = null!;
        public int CollaborateReportId { get; set; }
        public string Remark { get; set; } = null!;
        public DateTime? Date { get; set; }

        public virtual CollaborateReport CollaborateReport { get; set; } = null!;
    }
}
