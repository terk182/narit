using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models.Responses
{
    public class ViewPlanItemBudgetTransferListRespons
    {
        public int depId { get; set; }

        public int pTypeId { get; set; }

        public int FiscalYear { get; set; }

        public decimal budgetValue { get; set; }

        public string? documentNumber { get; set; }

        public int TransferTypeRadioButtonList { get; set; }
        public string? DirectionRadioButtonList { get; set; }
    }
}
