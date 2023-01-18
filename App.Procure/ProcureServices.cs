using App.EIS;
using App.Procure.emum;
using Microsoft.EntityFrameworkCore;
using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Procure
{
    public class ProcureServices : IProcureServices
    {
        private readonly NARIT_MIS_LINKContext _database;

        public ProcureServices(NARIT_MIS_LINKContext context)
        {
            _database = context;
        }

        public List<ApproveForm> getApproveFormsbyYear(int year)
        {
            var AllApproveFormList = _database.ApproveForms.Where(c => c.Active && c.FiscalYear == year && c.ProcureTransformStatusEnum != (int)ProcureTransformStatus.FinishTransform).ToList();
            return AllApproveFormList;
        }

        public List<ApproveItem> getApproveItemsbyYear(int year)
        {
            return _database.ApproveItems.Where(c => c.Active && c.FiscalYear == year && c.IsLoaning && c.SupplierId.HasValue &&
                (c.ProcureLoaningItems == null || c.ProcureLoaningItems.Where(d => d.Active || (d.ApprovalStatusEnum == (int)FinanceApprovalStatus.Denied)).Sum(f => f.Amount) < c.Amount)).ToList();
         
        }

        public List<CheckForm> getCheckFormbyYear(int year)
        {
            var AllCheckFormList = _database.CheckForms.Where(c => c.Active && c.FiscalYear == year).ToList();
            return AllCheckFormList;
        }

        public List<OrderForm> getOrderFormbyYear(int year)
        {
            var AllOrderFormList = _database.OrderForms.Where(c => c.Active && c.FiscalYear == year).ToList();
            return AllOrderFormList;
        }

        public List<ProcureLoaningMemoForm> getProcureLoaningMemoFormsbyYear(int year)
        {
            return _database.ProcureLoaningMemoForms.Where(c => c.Active && c.FiscalYear == year && (c.StatementPayStatusEnum == 30 || c.StatementPayStatusEnum == 40)).ToList();
                    
         
        }

        public List<RequestForm> getRequestFormbyYear(int year)
        {
            //var RequestForm = new List<RequestForm>();
            //string sql = String.Format(" SELECT * FROM [Procure].[RequestForms]  WHERE ( [FiscalYear] = '{0}' AND [ProcureApprovalStatusEnum] <> 30)", year);
            //var result = _database.RequestForms.FromSqlRaw(sql);

            //foreach (var item in result)
            //{
            //    RequestForm.Add(item);
            //}
            //return RequestForm;
            var data = _database.RequestForms.Where(c => c.Active == true && c.FiscalYear == year && c.ProcureApprovalStatusEnum != (int)ProcureApprovalStatus.Denied).ToList();
            return data.ToList();
        }

        public decimal WaitForDeliveryAmount(List<OrderForm> OrderForm)
        {
            decimal remOrderAppValue = 0.00m;
            decimal RemainAmount_value = 0;
            decimal reqIPV_value = 0;
            var reqIPV = new RequestViewUsedPlanItem();
            foreach (var orForm in OrderForm.Where(c => c.ProcureTransformStatusEnum != (int)ProcureTransformStatus.FinishTransform).ToList())
            {

                var orItems = _database.OrderItems.Where(d => d.Active).Include(x => x.ApproveOrderItemTransforms).ToList();
                foreach (var orItem in orItems)
                {
                    ApproveItem appI = orItem.ApproveOrderItemTransforms.First(c => c.Active).ApproveItem;
                    if (appI.IsImmediatelyReturnBudget)
                    {
                        var RemainAmount = _database.OrderCheckItemTransforms.Where(x => x.OrderItemId == orItem.Id && x.Active).Sum(c => c.Amount);
                        RemainAmount_value = (decimal)RemainAmount;
                        remOrderAppValue += RemainAmount_value * (decimal)orItem.PricePerPiece;
                    }
                    else
                    {

                        if (appI.RequestViewUsedPlanItemId.HasValue)
                        {
                             reqIPV = _database.RequestViewUsedPlanItems.Where(x => x.Id == appI.RequestViewUsedPlanItemId.Value).SingleOrDefault();
                            reqIPV_value = reqIPV.IsImmediatelyReturnBudget == true ? (decimal)reqIPV.ApprovePricePerPiece : (decimal)reqIPV.PricePerPiece;
                        }
                        else
                        {
                             reqIPV = _database.RequestViewUsedPlanItems.Where(c => c.Active && c.RequestItemId == appI.RequestItemId).SingleOrDefault();
                            reqIPV_value = reqIPV.IsImmediatelyReturnBudget == true ? (decimal)reqIPV.ApprovePricePerPiece : (decimal)reqIPV.PricePerPiece;
                        }


                        decimal res = (RemainAmount_value * reqIPV_value);
                   
                        if (reqIPV.Active && reqIPV.IsLateAdded)
                        {
                            res = res - (RemainAmount_value * (decimal)reqIPV.ApprovePricePerPiece);
                        }
                           
                        remOrderAppValue += res;
                    }
                }
            }
            return remOrderAppValue;
        }
    }
}
