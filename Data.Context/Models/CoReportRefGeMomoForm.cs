using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class CoReportRefGeMomoForm
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public int GeneralExpenseMemoFormId { get; set; }
        public string Purpose { get; set; } = null!;
        public string StatementName { get; set; } = null!;
        public DateTime? WriteDate { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public int CollaborateReportId { get; set; }

        public virtual CollaborateReport CollaborateReport { get; set; } = null!;
    }
}
