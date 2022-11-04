using App.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Common
{
    public interface ICommonServices
    {
        List<BudgetTypeCommonDto>  GetBudgetTypes(int fiscalYear);
        List<PlanTypeCommonDto> GetPlanType(int fiscalYear);
    }
}
