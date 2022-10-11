using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class HrdevelopmentType
    {
        public HrdevelopmentType()
        {
            DevelopmentRecordGroups = new HashSet<DevelopmentRecordGroup>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }

        public virtual ICollection<DevelopmentRecordGroup> DevelopmentRecordGroups { get; set; }
    }
}
