using System;
namespace App.FIN.Models.Requests
{
	public class EditReturnBudgetDateFromApproveFormRequest
	{
		public string? OrderType { get; set; }

        public string? Solution { get; set; }

        public bool PlanOrProject { get; set; }

        public string? DocNumber { get; set; }

        public string? PlanSelect { get; set; }

        public int FiscalYear { get; set; }


	}
}

