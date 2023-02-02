using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.helper
{
    public class GetPaidBudgetByMonthFunc
    {
        private readonly CGI_MISContext _database;

        public GetPaidBudgetByMonthFunc(CGI_MISContext context)
        {
            _database = context;
        }
        //public decimal GetPaidBudgetByMonth(int month, bool accumulate = false,int FiscalYear)
        //{
        //    decimal num = 0.00m;
        //    if (accumulate)
        //    {
        //        foreach (var item in _database.CheckViewUsedPlanItems.Where(c => c.Active && c.CheckFormPlanView.StatementPayStatusEnum == 30 && c.CheckFormPlanView.NetPayValue.HasValue && c.CheckFormPlanView.WriteDate.HasValue && ((c.CheckFormPlanView.WriteDate.Value.Month < 10) ? (c.CheckFormPlanView.WriteDate.Value.Year == FiscalYear || c.CheckFormPlanView.WriteDate.Value.Year == FiscalYear - 543) : (c.CheckFormPlanView.WriteDate.Value.Year + 1 == FiscalYear || c.CheckFormPlanView.WriteDate.Value.Year + 1 == FiscalYear - 543)) && ((month < 10) ? (c.CheckFormPlanView.WriteDate.Value.Month >= 10 || c.CheckFormPlanView.WriteDate.Value.Month <= month) : (c.CheckFormPlanView.WriteDate.Value.Month >= 10 && c.CheckFormPlanView.WriteDate.Value.Month <= month))))
        //        {
        //            num += (decimal)item.NetPayValue;
        //        }

        //        foreach (var item2 in  _database.GeneralExpenses.Where((GeneralExpense c) => c.Active && c.FinishTransformDate.HasValue && ((c.FinishTransformDate.Value.Month < 10) ? (c.FinishTransformDate.Value.Year == FiscalYear || c.FinishTransformDate.Value.Year == FiscalYear - 543) : (c.FinishTransformDate.Value.Year + 1 == FiscalYear || c.FinishTransformDate.Value.Year + 1 == FiscalYear - 543)) && ((month < 10) ? (c.FinishTransformDate.Value.Month >= 10 || c.FinishTransformDate.Value.Month <= month) : (c.FinishTransformDate.Value.Month >= 10 && c.FinishTransformDate.Value.Month <= month))))
        //        {
        //            decimal result;
        //            if (item2.IsBorrow)
        //            {
        //                result = (IsFinishedTransform ? (item2.TotalBudget - (SettleAmount.HasValue ? SettleAmount.Value : 0.00m) - CancelBudget - ReturnBudget) : TotalBudget);
        //            }
        //            else
        //            {
        //                decimal totalBudget = item2.TotalBudget;
        //                if(item2.IsBorrow)
        //        {
        //                  var SettleCanceledAndReturnBudget = item2.SettleAmount.HasValue ? (SettleAmount.Value + CancelBudget + ReturnBudget) : (CancelBudget + ReturnBudget);
        //                }
        //                else
        //                {
        //                    var SettleCanceledAndReturnBudget = item2.CancelBudget + item2.ReturnBudget;
        //                }
        //                decimal? settleCanceledAndReturnBudget = item2.SettleCanceledAndReturnBudget;
        //                result = ((decimal?)totalBudget - settleCanceledAndReturnBudget) ?? 0.00m;
        //            }
        //            num += item2.NetBudget;
        //        }

        //        foreach (DirectExpense item3 in _database.DirectExpenses.Where(c => c.Active && c.DirectExpenseMemoForm.StatementPayStatusEnum == 30 && ((c.DirectExpenseMemoForm.StatementCalculationDate.Month < 10) ? (c.DirectExpenseMemoForm.StatementCalculationDate.Year == FiscalYear || c.DirectExpenseMemoForm.StatementCalculationDate.Year == FiscalYear - 543) : (c.DirectExpenseMemoForm.StatementCalculationDate.Year + 1 == FiscalYear || c.DirectExpenseMemoForm.StatementCalculationDate.Year + 1 == FiscalYear - 543)) && ((month < 10) ? (c.DirectExpenseMemoForm.StatementCalculationDate.Month >= 10 || c.DirectExpenseMemoForm.StatementCalculationDate.Month <= month) : (c.DirectExpenseMemoForm.StatementCalculationDate.Month >= 10 && c.DirectExpenseMemoForm.StatementCalculationDate.Month <= month))))
        //        {
        //            num = (int)((item3.PlanStatementDirectionEnum == 30) ? (num - item3.TotalBudget) : (num + item3.TotalBudget));
        //        }
        //    }
        //    else
        //    {
        //        foreach (CheckViewUsedPlanItem item4 in _database.CheckViewUsedPlanItems.Where((CheckViewUsedPlanItem c) => c.Active && c.CheckFormPlanView.StatementPayStatusEnum == 30 && c.CheckFormPlanView.NetPayValue.HasValue && c.CheckFormPlanView.WriteDate.HasValue && ((c.CheckFormPlanView.WriteDate.Value.Month < 10) ? ((c.CheckFormPlanView.WriteDate.Value.Year == FiscalYear || c.CheckFormPlanView.WriteDate.Value.Year == FiscalYear - 543) && c.CheckFormPlanView.WriteDate.Value.Month == month) : (c.CheckFormPlanView.WriteDate.Value.Year - 1 == FiscalYear || c.CheckFormPlanView.WriteDate.Value.Year - 1 == FiscalYear - 543))))
        //        {
        //            num += item4.NetPayValue;
        //        }

        //        foreach (GeneralExpense item5 in _database.GeneralExpenses.Where((GeneralExpense c) => c.Active && c.GeneralExpenseMemoForm.StatementPayStatusEnum == 30 && c.FinishTransformDate.HasValue && ((c.FinishTransformDate.Value.Month < 10) ? ((c.FinishTransformDate.Value.Year == FiscalYear || c.FinishTransformDate.Value.Year == FiscalYear - 543) && c.FinishTransformDate.Value.Month == month) : (c.FinishTransformDate.Value.Year - 1 == FiscalYear || c.FinishTransformDate.Value.Year - 1 == FiscalYear - 543))))
        //        {
        //            num += item5.NetBudget;
        //        }

        //        foreach (DirectExpense item6 in _database.DirectExpenses.Where((DirectExpense c) => c.Active && c.DirectExpenseMemoForm.StatementPayStatusEnum == 30 && ((c.DirectExpenseMemoForm.StatementCalculationDate.Month < 10) ? (c.DirectExpenseMemoForm.StatementCalculationDate.Year == FiscalYear || c.DirectExpenseMemoForm.StatementCalculationDate.Year == FiscalYear - 543) : (c.DirectExpenseMemoForm.StatementCalculationDate.Year - 1 == FiscalYear || c.DirectExpenseMemoForm.StatementCalculationDate.Year - 1 == FiscalYear - 543)) && c.DirectExpenseMemoForm.StatementCalculationDate.Month == month))
        //        {
        //            num = (int)((item6.PlanStatementDirectionEnum == 30) ? (num - item6.TotalBudget) : (num + item6.TotalBudget));
        //        }
        //    }

        //    return num;
        //}


    }
}
