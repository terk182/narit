using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models.Requests
{
    public class RequestFormPlanViewRequest
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime? WriteDate { get; set; }
        public bool Active { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public int FiscalYear { get; set; }
        public int? ProcureMethodEnum { get; set; }
        public int ProcureTypeEnum { get; set; }
        public string Requester { get; set; } = null!;
        public string Purpose { get; set; } = null!;
        public int RequestFormId { get; set; }
        public int PlanActivityIdOld { get; set; }
        public bool IsApproved { get; set; }
        public bool IsFinishedTransform { get; set; }
        public DateTime? FinishedTransformDate { get; set; }
        public int PlanTypeId { get; set; }
        public int DepartmentId { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public bool IsTemporaryInvolve { get; set; }
        public DateTime StatementCalculationDate { get; set; }
        public string StatementName { get; set; } = null!;
        public int? RealInvolvePlanItemId { get; set; }
        public int? UsedToInvolvePlanItemId { get; set; }
        public int PlanCoreId { get; set; }
        public int ApprovalStatusEnum { get; set; }
        public string DepartmentName { get; set; } = null!;
        public string PlanCoreName { get; set; } = null!;
        public string BudgetTypeName { get; set; } = null!;
        public string PlanTypeName { get; set; } = null!;
        public string PlanActivityName { get; set; } = null!;
        public string ReserveByStaffName { get; set; } = null!;
        public string ReserveRemark { get; set; } = null!;
        public string ReserveForecastValue { get; set; } = null!;
        public int? ReserveByStaffId { get; set; }
        public DateTime? ReserveDate { get; set; }
        public bool IsReserve { get; set; }
        public int? ReserveDepartmentId { get; set; }
        public string ReserveDepartmentName { get; set; } = null!;
        public int RequestDepartmentId { get; set; }
        public string RequestDepartmentName { get; set; } = null!;
    }
}
