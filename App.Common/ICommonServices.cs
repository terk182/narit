using App.Common.Dtos;
using App.Common.Models.Responses;
using narit_mis_api.Models;
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
        CommonBaseResponse EditMisGeneralExpenseMemoFormsSignList(MisGeneralExpenseMemoFormsSignListDto GeFormActionLog);
        List<MisGeneralExpenseMemoFormsSignList> GetMisGeneralExpenseMemoFormsSignList(int GeneralExpenseMemoFormsId);
        CommonBaseResponse GeFormActionLog(GeFormActionLog GeFormActionLog);
        List<GeFormActionLog> GetGeFormActionLog(int GeneralExpenseMemoFormId );

    }
}
