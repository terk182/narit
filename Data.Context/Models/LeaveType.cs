using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class LeaveType
    {
        public LeaveType()
        {
            LeaveArchievedRecords = new HashSet<LeaveArchievedRecord>();
            LeaveCancellationForms = new HashSet<LeaveCancellationForm>();
            LeaveTypeLimits = new HashSet<LeaveTypeLimit>();
            Leaves = new HashSet<Leaf>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }

        public virtual ICollection<LeaveArchievedRecord> LeaveArchievedRecords { get; set; }
        public virtual ICollection<LeaveCancellationForm> LeaveCancellationForms { get; set; }
        public virtual ICollection<LeaveTypeLimit> LeaveTypeLimits { get; set; }
        public virtual ICollection<Leaf> Leaves { get; set; }
    }
}
