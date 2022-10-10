using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class OutsideDutyReportForm
    {
        public OutsideDutyReportForm()
        {
            OutsideDutyReportActionLogs = new HashSet<OutsideDutyReportActionLog>();
            OutsideDutyReportReceipts = new HashSet<OutsideDutyReportReceipt>();
            OutsideDutyReportStaffs = new HashSet<OutsideDutyReportStaff>();
            GeneralExpenseMemoForms = new HashSet<GeneralExpenseMemoForm>();
        }

        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public int FiscalYear { get; set; }
        public string Inform { get; set; } = null!;
        public DateTime? WriteDate { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public int StaffId { get; set; }
        public string StaffName { get; set; } = null!;
        public string StaffPosition { get; set; } = null!;
        public string StaffDepartment { get; set; } = null!;
        public string RefDocumentNumber { get; set; } = null!;
        public DateTime? RefDocumentDate { get; set; }
        public decimal RefTotalBudget { get; set; }
        public string TravelBy { get; set; } = null!;
        public string Detail { get; set; } = null!;
        public string StartingPoint { get; set; } = null!;
        public DateTime DateStart { get; set; }
        public string? TimeStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string? TimeEnd { get; set; }
        public int? OvernightAmount { get; set; }
        public string OvernightPlace { get; set; } = null!;
        public decimal TotalExpense { get; set; }
        public string RequesterName { get; set; } = null!;
        public DateTime? RequesterSignDate { get; set; }
        public string ReceiptAttachedAmount { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public int? GeneralExpenseMemoFormId { get; set; }
        public string TotalTraveler { get; set; } = null!;
        public bool? IsOutsideDuty { get; set; }
        public string OtherRequest { get; set; } = null!;
        public string Remark { get; set; } = null!;

        public virtual ICollection<OutsideDutyReportActionLog> OutsideDutyReportActionLogs { get; set; }
        public virtual ICollection<OutsideDutyReportReceipt> OutsideDutyReportReceipts { get; set; }
        public virtual ICollection<OutsideDutyReportStaff> OutsideDutyReportStaffs { get; set; }

        public virtual ICollection<GeneralExpenseMemoForm> GeneralExpenseMemoForms { get; set; }
    }
}
