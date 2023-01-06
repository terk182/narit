using narit_acc_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.ACC
{
    public interface IAccServices
    {
        List<ChartDetail> GetAccbooks();
    }
}
