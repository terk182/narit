using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models.Requests
{
    public class BudgetTransferFormRequest
    {
        public int fiscalYear { get; set; }
        public string? documentnumber { get; set; }
        public decimal budget { get; set; }


    }
}
