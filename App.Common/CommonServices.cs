using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Common
{
    public class CommonServices : ICommonServices
    {
        private readonly NARIT_MIS_LINKContext _database;

        public CommonServices(NARIT_MIS_LINKContext context)
        {
            _database = context;
        }
    }
}
