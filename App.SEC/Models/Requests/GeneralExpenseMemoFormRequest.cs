using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models.Requests
{
    public class GeneralExpenseMemoFormRequest
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public DateTime? WriteDate { get; set; }
        public string Inform { get; set; } = null!;
        public string Enclosures { get; set; } = null!;
        public string Purpose { get; set; } = null!;
        public string RequesterName { get; set; } = null!;
        public DateTime? RequesterSignDate { get; set; }
        public string UnitChiefName { get; set; } = null!;
        public DateTime? UnitChiefSignDate { get; set; }
        public string BudgetCheckerName { get; set; } = null!;
        public DateTime? BudgetCheckerSignDate { get; set; }
        public string Approver { get; set; } = null!;
        public DateTime? ApproverSignDate { get; set; }
        public int ApprovalStatusEnum { get; set; }
        public string DepartmentName { get; set; } = null!;
        public int DepartmentId { get; set; }
        public string PlanTypeName { get; set; } = null!;
        public int PlanTypeId { get; set; }
        public string PlanCoreName { get; set; } = null!;
        public int PlanCoreId { get; set; }
        public string BudgetTypeName { get; set; } = null!;
        public int BudgetTypeId { get; set; }
        public decimal PlanCoreRemainBudget { get; set; }
        public string PlanCoreCode { get; set; } = null!;
        public DateTime? ApprovedDate { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public int StatementPayStatusEnum { get; set; }
        public decimal? NetPayValue { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public bool IsBorrow { get; set; }
        public bool IsTemporaryInvolve { get; set; }
        public DateTime StatementCalculationDate { get; set; }
        public int PlanActivityIdOld { get; set; }
        public string FundTypeName { get; set; } = null!;
        public int FundTypeId { get; set; }
        public string StatementName { get; set; } = null!;
        //public List<MisGeneralExpenseMemoFormsSignList> SignList { get; set; }
    }
}
