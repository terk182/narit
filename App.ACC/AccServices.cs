using narit_mis_api.AccModels;
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
    }
}
