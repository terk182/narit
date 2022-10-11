using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class MedicalReimbursement
    {
        public MedicalReimbursement()
        {
            Hrfiles = new HashSet<Hrfile>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int FamilyRelationTypeEnum { get; set; }
        public int HospitalTypeEnum { get; set; }
        public int MedicalReimbursementTypeEnum { get; set; }
        public string LotNumber { get; set; } = null!;
        public decimal RequestAmount { get; set; }
        public decimal Amount { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? SentMailDate { get; set; }
        public int StaffId { get; set; }
        public int? RelativePersonId { get; set; }
        public bool IsMedicalCheckup { get; set; }
        public string HospitalName { get; set; } = null!;
        public DateTime RecordDate { get; set; }
        public DateTime? PayDate { get; set; }
        public string Remark { get; set; } = null!;
        public bool IsIpd { get; set; }
        public bool IsDirectPayment { get; set; }
        public int DirectPaymentHospitalEnum { get; set; }
        public string CaseNumber { get; set; } = null!;
        public decimal RemainAmountAtDate { get; set; }
        public decimal NonReimbursableAmount { get; set; }
        public decimal FullReimbursableAmount { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public DateTime? ApproverSignDate { get; set; }
        public int? ApprovedSignStaffId { get; set; }
        public string ApprovedSignHostName { get; set; } = null!;
        public string ApprovedSignHostAddress { get; set; } = null!;
        public int ApprovalStatusEnum { get; set; }
        public string UnitChiefName { get; set; } = null!;
        public string UnitChiefPositionName { get; set; } = null!;
        public DateTime? UnitChiefSignDate { get; set; }

        public virtual RelativePerson? RelativePerson { get; set; }
        public virtual Staff Staff { get; set; } = null!;
        public virtual ICollection<Hrfile> Hrfiles { get; set; }
    }
}
