using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class ProcureComitteeGroup
    {
        public ProcureComitteeGroup()
        {
            ProcureComitteePeople = new HashSet<ProcureComitteePerson>();
            ProcureTrackingGroups = new HashSet<ProcureTrackingGroup>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int ProcureComitteeTypeEnum { get; set; }
        public int ControlGroupNumber { get; set; }

        public virtual ICollection<ProcureComitteePerson> ProcureComitteePeople { get; set; }

        public virtual ICollection<ProcureTrackingGroup> ProcureTrackingGroups { get; set; }
    }
}
