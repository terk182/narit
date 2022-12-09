using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models.Requests
{
    public class ViewGeneralExpenseMemoFormListRequest
    {
        public int objId {get; set;}

        public int FiscalYear { get; set; }

        public decimal budgetValue { get; set; }

        public string? documentNumber { get; set; }
        public string? stateName { get; set; }
        public int reqdepId { get; set; }

        public int isBorrow { get; set; }
        public int appState { get; set; }
        public int staffId { get; set; }
        public string? PlanObjectTypeRadioButtonList { get; set; }

    }
}
