using App.SEC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.helper
{
    public class obj_sum
    {
        decimal _TotalBudgetCache = 0;
        decimal _TotalAmount = 0;
        decimal _NetAmount = 0;
        decimal _NetBudgetCache = 0;
        decimal _UsedBudgetCache = 0;
        decimal _RemainBudgetCache = 0;
        decimal _TotalBudget = 0;

        public sum_result sum(List<ViewPlanForActivityByDepartmentTable> data)
        {
            for (int i = 0;i< data.Count();i++)
            {
                _TotalBudget += data[i].TotalBudget;
                _TotalBudgetCache += data[i].TotalBudgetCache;
                _NetBudgetCache += data[i].NetBudgetCache;
                _UsedBudgetCache += data[i].UsedBudgetCache;
                _RemainBudgetCache += data[i].RemainBudgetCache;
            }
            var respone = new sum_result();
            respone.TotalBudgetCache = _TotalBudgetCache;
            respone.UsedBudgetCache = _UsedBudgetCache;
            respone.RemainBudgetCache = _RemainBudgetCache;
            respone.NetBudgetCache = _NetBudgetCache;
            respone.TotalBudget = _TotalBudget;
            return respone;
        }
    }
}
