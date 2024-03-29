﻿using narit_mis_api.Models;
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
        List<RequestFormPlanView> RequestFormPlanViewsByYear(int Year);
        List<CheckFormPlanView> CheckFormPlanViewByYear(int Year);

        List<CheckFormPlanView> CheckFormPlanViewByRequestFormPlanViewId(int RequestFormPlanViewId);
        List<GeneralExpenseMemoForm> GetWaitingForApprove(int staffId, int yearNow);

        List<BudgetType> BudgetTypeByYear(int Year);
    }
}
