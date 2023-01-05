using narit_acc_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.ACC
{
    public class AccServices : IAccServices
    {
        private readonly NARIT_MIS_ACCContext _databaseACC;

        public AccServices(NARIT_MIS_ACCContext context)
        {
            _databaseACC = context;
        }

        public List<ChartAcc> GetAccbooks()
        {
            var data = _databaseACC.ChartAccs.ToList();
            return data;
        }
    }
}
