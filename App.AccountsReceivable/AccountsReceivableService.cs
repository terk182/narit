using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using narit_acc_api.Models;

namespace App.AccountsReceivable
{
    public class AccountsReceivableService : IAccountsReceivableService
    {
        private readonly CGI_ACCContext _databaseACC;

        public AccountsReceivableService(CGI_ACCContext context)
        {
            _databaseACC = context;
        }


        public List<ChartHeader> GetChartHeaders()
        {
            var data = _databaseACC.ChartHeaders.ToList();
            if (data.Count > 0)
            {
                return data;
            }
            return data;
        }
    }
}
