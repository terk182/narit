using System;
namespace App.FIN.Models.Responses
{
	public class EditReturnBudgetDateFromApproveFormResponses
	{
		public DateTime DateFromOfferForm { get; set; }

		public DateTime DateFromRequestForm { get; set; }

        public DateTime DateFromCreateRequestForm { get; set; }

        public DateTime DateReturn { get; set; }

		public string? LicenseForm { get; set; }

		public string? Order { get; set; }

		public Double BalanceRequest { get; set; }

        public Double BalanceReturn { get; set; }

    }
}

