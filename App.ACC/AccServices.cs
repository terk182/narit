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
        private readonly CGI_ACCContext _databaseACC;

        public AccServices(CGI_ACCContext context)
        {
            _databaseACC = context;
        }

        public List<ChartDetail> GetAccbooks()
        {
            var data = _databaseACC.ChartDetails.ToList();
            return data;
        }

    }
}
