using App.EIS;
using Microsoft.EntityFrameworkCore;
using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Plan
{
    public class PlanServices : IPlanServices
    {
        private readonly NARIT_MIS_LINKContext _database;

        public PlanServices(NARIT_MIS_LINKContext context)
        {
            _database = context;
        }



        public List<PlanActivity> PlanActivityByPlanCoreId(int PlanCoreId)
        {
            var planActivities = new List<PlanActivity>();
            var result = _database.PlanActivities.Where(x => x.PlanCoreId == PlanCoreId);
            foreach (var activity in result)
            {
                planActivities.Add(activity);
            }

            return planActivities;
        }

        public List<PlanItem> PlanItemsByPlanActivityId(int PlanActivityId)
        {
            var result = _database.PlanItems.Where(x => x.PlanActivityId == PlanActivityId);
            var PlanItems = new List<PlanItem>();
          
            foreach (var activity in result)
            {
                PlanItems.Add(activity);
            }
            return PlanItems;
        }
        public List<BudgetTransfer> BudgetTransferByPlanItemId(int PlanItemId)
        {
            var result = _database.BudgetTransfers.Where(x => x.InwardPlanItemId == PlanItemId);
            var BudgetTransfers = new List<BudgetTransfer>();

            foreach (var activity in result)
            {
                BudgetTransfers.Add(activity);
            }
            return BudgetTransfers;
        }

        public List<BudgetTransfer> BudgetTransferByPlanCoreId(int PlanCoreId)
        {
            var result = _database.BudgetTransfers.Where(x => x.InwardPlanCoreId == PlanCoreId);
            var BudgetTransfers = new List<BudgetTransfer>();

            foreach (var activity in result)
            {
                BudgetTransfers.Add(activity);
            }
            return BudgetTransfers;
        }

        public List<BudgetTransfer> BudgetTransferPlanActivityId(int PlanActivityId)
        {
            var result = _database.BudgetTransfers.Where(x => x.OutwardPlanActivityId == PlanActivityId);
            var BudgetTransfers = new List<BudgetTransfer>();

            foreach (var activity in result)
            {
                BudgetTransfers.Add(activity);
            }
            return BudgetTransfers;
        }

        public List<RequestFormPlanView> RequestFormPlanViewsByYear(int Year)
        {
            var AllReqProcurePlanViewList = _database.RequestFormPlanViews.Where(c => c.Active && c.FiscalYear == Year && c.ApprovalStatusEnum != (int)ProcureApprovalStatus.Denied);
            return AllReqProcurePlanViewList.ToList();
        }

        public List<CheckFormPlanView> CheckFormPlanViewByYear(int Year)
        {
            return _database.CheckFormPlanViews.Where(c => c.Active && c.FiscalYear == Year).ToList();
            
        }

        public List<CheckFormPlanView> CheckFormPlanViewByRequestFormPlanViewId(int RequestFormPlanViewId)
        {
            return _database.CheckFormPlanViews.Where(x=> x.RequestFormPlanViewId == RequestFormPlanViewId).ToList();
        }


        //----------home check staff-------
        public List<GeneralExpenseMemoForm> GetWaitingForApprove(int staffId, int yearNow)
        {
            return  _database.GeneralExpenseMemoForms.Where(c => (c.Active && c.IsSent && c.FiscalYear == yearNow && !c.IsHidden && c.ApprovalStatusEnum == 10 && ((!c.DocCheckerStaffId.HasValue && c.PlanFormApprovalStatusEnum == 10) || c.PlanFormApprovalStatusEnum == 230) && c.UnitChiefStaffId.HasValue && c.UnitChiefStaffId.Value == staffId && !c.UnitChiefSignDate.HasValue) || (c.PlanFormApprovalStatusEnum == 330 && ((c.ProjectManager1StaffId.HasValue && c.ProjectManager1StaffId.Value == staffId && !c.ProjectManager1SignDate.HasValue) || (c.ProjectManager2StaffId.HasValue && c.ProjectManager2StaffId.Value == staffId && !c.ProjectManager2SignDate.HasValue) || (c.ProjectManager3StaffId.HasValue && c.ProjectManager3StaffId.Value == staffId && !c.ProjectManager3SignDate.HasValue) || (c.ProjectManager4StaffId.HasValue && c.ProjectManager4StaffId.Value == staffId && !c.ProjectManager4SignDate.HasValue))) || (c.ApproverStaffId.HasValue && c.ApproverStaffId.Value == staffId && c.PlanFormApprovalStatusEnum == 980)).ToList();
        }

        public List<BudgetType> BudgetTypeByYear(int Year)
        {
            return _database.BudgetTypes.Where(c => c.FiscalYear == Year && c.Active).OrderBy(c => c.Name).ToList();
            
        }
    }
}
