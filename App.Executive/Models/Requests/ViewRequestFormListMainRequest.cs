using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.FIN.Models.Requests
{
    public class ViewRequestFormListMainRequest
    {
        public bool isProcurePowerUser { get; set; }

        public int staffId { get; set; }

        public int FiscalYear { get; set; }

        public string? documentNumber { get; set; }

        public string? SupplierName { get; set; }

        public int procureTypeEnum { get; set;}

        public int PlanTypeId { get; set; }
        public string?  DocumentTypeRadioButtonList { get; set; }
    }

}