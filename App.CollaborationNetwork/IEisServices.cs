using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.EIS
{
    public interface IEisServices
    {
        List<PlanCore> getPlanCore();
        List<GovernmentDisbursementGoal> getGovernmentDisbursementGoal();
        List<PlanCore> planCoreList(int year);
    }
}