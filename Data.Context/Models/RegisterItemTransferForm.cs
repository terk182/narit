using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class RegisterItemTransferForm
    {
        public RegisterItemTransferForm()
        {
            RegItemTransferFormActionLogs = new HashSet<RegItemTransferFormActionLog>();
            RegisterItemTransferRecords = new HashSet<RegisterItemTransferRecord>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public DateTime? WriteDate { get; set; }
        public int FiscalYear { get; set; }
        public string Purpose { get; set; } = null!;
        public string Requester { get; set; } = null!;
        public string FromDepPhoneNumber { get; set; } = null!;
        public string FromDepUnitChiefName { get; set; } = null!;
        public string ToDepUnitChiefName { get; set; } = null!;
        public string FromDepartmentChiefName { get; set; } = null!;
        public string ToDepartmentChiefName { get; set; } = null!;
        public string SuppliesOfficer { get; set; } = null!;
        public string SuppliesUnitChief { get; set; } = null!;
        public DateTime? FromDepUnitChiefSignDate { get; set; }
        public DateTime? FromDepChiefSignDate { get; set; }
        public DateTime? ToDepUnitChiefSignDate { get; set; }
        public DateTime? ToDepChiefSignDate { get; set; }
        public DateTime? SuppliesOfficerSignDate { get; set; }
        public DateTime? SuppliesUnitChiefSignDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int? ApprovedByStaffId { get; set; }
        public int ProcureApprovalStatusEnum { get; set; }

        public virtual ICollection<RegItemTransferFormActionLog> RegItemTransferFormActionLogs { get; set; }
        public virtual ICollection<RegisterItemTransferRecord> RegisterItemTransferRecords { get; set; }
    }
}
