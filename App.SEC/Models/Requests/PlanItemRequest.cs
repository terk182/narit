using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models.Requests
{
    public class PlanItemRequest
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int PlanActivityId { get; set; }
        public string? Unit { get; set; }
        public int? CostTypeId { get; set; }
        public int? PlanItemTypeId { get; set; }
        public int? BudgetTypeId { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public decimal UndefineReserveBudget { get; set; }
        public decimal ProtectBudget { get; set; }
        public DateTime? UndefineReserveDate { get; set; }
        public int? UndefineReserveByStaffId { get; set; }
        public string UndefineReserveByStaffName { get; set; } = null!;
        public string UndefineReserveRemark { get; set; } = null!;
        public string UndefineReserveForecastValue { get; set; } = null!;
        public decimal UndefineReserveReturnBudget { get; set; }
        public DateTime? UndefineReserveReturnDate { get; set; }
        public decimal ReservedBudget { get; set; }
        public decimal ReceivedBudget1 { get; set; }
        public decimal ReceivedBudget2 { get; set; }
        public decimal ReceivedBudget3 { get; set; }
        public decimal ReceivedBudget4 { get; set; }
        public DateTime? ReceivedBudgetDate1 { get; set; }
        public DateTime? ReceivedBudgetDate2 { get; set; }
        public DateTime? ReceivedBudgetDate3 { get; set; }
        public DateTime? ReceivedBudgetDate4 { get; set; }
        public bool IsBlocked { get; set; }
        public bool IsNotControlByReceivedBudget { get; set; }
        public string Remark { get; set; } = null!;
    }
}
