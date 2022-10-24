using App.SEC.Dtos;
using App.SEC.Models;
using App.SEC.Models.Requests;
using App.SEC.Responses;
using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC
{
    public interface ISecServices
    {
        List<BudgetType> GetByFiscalYear(int FiscalYear);
        PlanCrudpolicy GetPolicy(int year);
        SecBaseResponse AddUpdatePlanCrudpolicy(PlanCrudpolicy policy);
        List<DepartmentDto> DepartmentGetByFiscalYear(int FiscalYear);
        List<ViewPlanForActivityByDepartmentTable> GetById(int departmentId, int FiscalYear);
        List<PlanTypeDto> PlanTypeGetByFiscalYear(int FiscalYear);

        SecBaseResponse StrategySetup(StrategySetupModel request);
        List<StrategySetupModel> StrategySetupByFiscalYear(int FiscalYear);
    }
}
