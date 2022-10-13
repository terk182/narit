using App.EIS.Models;
using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.EIS
{
    public class EisServices : IEisServices
    {
        private readonly NARIT_MIS_LINKContext _database;

        public EisServices(NARIT_MIS_LINKContext context)
        {
            _database = context;
        }
        public List<GovernmentDisbursementGoal> getGovernmentDisbursementGoal()
        {
            throw new NotImplementedException();
        }

        public List<PlanCore> getPlanCore()
        {
            throw new NotImplementedException();
        }

        public List<PlanCore> planCoreList(int year)
        {
            var planCore = _database.PlanCores.Where(x => x.FiscalYear == year && x.Active).OrderBy(x => x.Name).ToList();   
            return planCore;
        }
    }
}
