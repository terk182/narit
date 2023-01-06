using System;
namespace App.SEC.Models.Responses
{
	public class ViewGeneralExpenseSettleAsBudgetFormListResponses
	{
		public int No { get; set; }

		public DateTime Date { get; set; }

		public string? NumberId { get; set; }

        public string? Order { get; set; }

		public Double AllBorrowed { get; set; }

        public Double CashBack { get; set; }

        public Double Refun { get; set; }

        public Double AllRefun { get; set; }

    }
}

