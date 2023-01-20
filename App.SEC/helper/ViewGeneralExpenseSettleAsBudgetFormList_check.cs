using Microsoft.EntityFrameworkCore;
using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.helper
{
    public class ViewGeneralExpenseSettleAsBudgetFormList_check
    {
        private readonly NARIT_MIS_LINKContext _database;

        public ViewGeneralExpenseSettleAsBudgetFormList_check(NARIT_MIS_LINKContext context)
        {
            _database = context;
        }
        public List<GeneralExpenseSettleForm> GetByPlanTypeId(int id, int approvalStatus, bool onlyHasSettleAsBudget = false, string documentNumber = "", decimal budgetValue = 0.00m, string statementName = "")
        {
            return _database.GeneralExpenseSettleForms.Where(c => c.Active && c.PlanTypeId == id).Include(c => c.SettlementItems).Include(c => c.SettleDirectPaymentItems).Include(c => c.SeFormActionLogs).Include(c => c.AdditionalSettleItems).OrderByDescending(c => c.Id).ToList();         //orderby c.Id descending select c).ToList();
        }
        public List<GeneralExpenseSettleForm> GetByDepartmentId(int id, int approvalStatus, bool onlyHasSettleAsBudget = false, string documentNumber = "", decimal budgetValue = 0.00m, string statementName = "")
        {
            return _database.GeneralExpenseSettleForms.Where(c => c.Active && c.DepartmentId == id).Include(c => c.SettlementItems).Include(c => c.SettleDirectPaymentItems).Include(c => c.SeFormActionLogs).Include(c => c.AdditionalSettleItems).OrderByDescending(c => c.Id).ToList();
        }
        public List<GeneralExpenseSettleForm> GetByFiscalYear(int fiscalYear, int approvalStatus, bool onlyHasSettleAsBudget = false, string documentNumber = "", decimal budgetValue = 0.00m, string statementName = "")
        {
            return _database.GeneralExpenseSettleForms.Where(c => c.Active && c.FiscalYear == fiscalYear).Include(c => c.SettlementItems).Include(c => c.SettleDirectPaymentItems).Include(c => c.SeFormActionLogs).Include(c => c.AdditionalSettleItems).OrderByDescending(c => c.Id).ToList();
        }
    }
}
