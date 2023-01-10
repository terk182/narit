using System;
namespace App.FIN.Models.Responses
{
	public class EditReturnBudgetDateFromApproveFormResponses
	{
		//public DateTime DateFromOfferForm { get; set; }

		//public DateTime DateFromRequestForm { get; set; }

  //      public DateTime DateFromCreateRequestForm { get; set; }

  //      public DateTime DateReturn { get; set; }

		//public string? LicenseForm { get; set; }

		//public string? Order { get; set; }

		//public Double BalanceRequest { get; set; }

  //      public Double BalanceReturn { get; set; }

		//public string? DocNumber { get; set; }




        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int FiscalYear { get; set; }
        public bool Active { get; set; }
        public int? ParentPlanTypeId { get; set; }
        public int? ReferenceOldId { get; set; }
        public decimal Weight { get; set; }

    }
}

