using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class OutsideDutyGroup
    {
        public OutsideDutyGroup()
        {
            Hrfiles = new HashSet<Hrfile>();
            OutsideDuties = new HashSet<OutsideDuty>();
            OutsideDutyGroupCancellations = new HashSet<OutsideDutyGroupCancellation>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Place { get; set; } = null!;
        public string OrderNumber { get; set; } = null!;
        public string Detail { get; set; } = null!;
        public int FiscalYear { get; set; }
        public DateTime? WriteDate { get; set; }
        public string Inform { get; set; } = null!;
        public string WriteAt { get; set; } = null!;
        public DateTime? UnitChiefSignDate { get; set; }
        public string UnitChiefName { get; set; } = null!;
        public string UnitChiefOpinion { get; set; } = null!;
        public string UnitChiefPositionName { get; set; } = null!;
        public string Approver { get; set; } = null!;
        public DateTime? ApproverSignDate { get; set; }
        public int ApprovalStatusEnum { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string ApproverPosition { get; set; } = null!;
        public string DocumentNumber { get; set; } = null!;
        public string ApproverOpinion { get; set; } = null!;
        public int? HrdepartmentId { get; set; }
        public string HrdepartmentName { get; set; } = null!;
        public int WorkAttendanceTimeRangeEnum { get; set; }
        public TimeSpan? TimeStart { get; set; }
        public TimeSpan? TimeEnd { get; set; }
        public string ExceptionDateValue { get; set; } = null!;
        public bool AllowExceptionDate { get; set; }
        public string RequesterName { get; set; } = null!;
        public int? ApproverId { get; set; }
        public int? ApprovedSignStaffId { get; set; }
        public string ApprovedSignHostName { get; set; } = null!;
        public string ApprovedSignHostAddress { get; set; } = null!;
        public int? CreatorStaffId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatorHostName { get; set; } = null!;
        public string CreatorHostAddress { get; set; } = null!;
        public int? GeneralExpenseMemoFormId { get; set; }
        public string Purpose { get; set; } = null!;
        public decimal? PlanCoreRemainBudget { get; set; }
        public string Remark { get; set; } = null!;
        public string Topic { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Location { get; set; } = null!;
        public string OperationTime { get; set; } = null!;
        public bool IsForeign { get; set; }
        public string FundTypeName { get; set; } = null!;
        public string DepartmentName { get; set; } = null!;
        public string PlanTypeName { get; set; } = null!;
        public string PlanCoreName { get; set; } = null!;
        public string PlanActivityName { get; set; } = null!;
        public string OtherPeopleText { get; set; } = null!;
        public int OtherPeopleAmount { get; set; }
        public string OtherPeopleAttachText { get; set; } = null!;
        public string OperationDate { get; set; } = null!;
        public int RangeNumber { get; set; }
        public int? EndWorkAttendanceTimeRangeEnum { get; set; }
        public bool NeedTimeStamp { get; set; }
        public bool IsEventOrganize { get; set; }

        public virtual ICollection<Hrfile> Hrfiles { get; set; }
        public virtual ICollection<OutsideDuty> OutsideDuties { get; set; }
        public virtual ICollection<OutsideDutyGroupCancellation> OutsideDutyGroupCancellations { get; set; }
    }
}
