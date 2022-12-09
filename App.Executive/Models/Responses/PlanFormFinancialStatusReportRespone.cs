using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.FIN.Models.Responses
{
    public class PlanFormFinancialStatusReportRespone
    {
        public List<FromRequest>? fromRequest { get; set; }
        public List<OfferRequest>? offerRequest { get; set; }
    }
    public class FromRequest: commonRequest
    {


        public decimal borrowBudget { get; set; }
        public decimal amountBudget { get; set; }

    }
    public class OfferRequest : commonRequest
    {

        public decimal inspected { get; set; }

    }
    public class commonRequest
    {
        public int No { get; set; }
        public string? documentNumber { get; set; }
        public string? WriteDate { get; set; }
        public string? PlanTypeName { get; set; }
        public string? RequestDepartmentName { get; set; }
        public string? StatementName { get; set; }
        public decimal totalBudget { get; set; }
        public decimal UsedBudget { get; set; }
        public decimal approveBudget { get; set; }
        public decimal remainBudget { get; set; }
        public decimal disbursedBudget { get; set; }
        public decimal remaining { get; set; }
    }
}
