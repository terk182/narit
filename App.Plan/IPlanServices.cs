using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Plan
{
    public interface IPlanServices
    {
        List<PlanActivity> PlanActivityByPlanCoreId(int PlanCoreId);
        List<PlanItem> PlanItemsByPlanActivityId(int PlanActivityId);
        List<BudgetTransfer> BudgetTransferByPlanItemId(int PlanItemId);
        List<BudgetTransfer> BudgetTransferByPlanCoreId(int PlanCoreId);
        List<BudgetTransfer> BudgetTransferPlanActivityId(int PlanActivityId);
    }
}
