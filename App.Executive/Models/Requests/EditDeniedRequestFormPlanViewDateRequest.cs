using System;
namespace App.FIN.Models.Requests
{
	public class EditDeniedRequestFormPlanViewDateRequest
	{
		public int FiscalYear { get; set; }

		public int? DocNumber { get; set; }

        public string? PlanSelect { get; set; }

		public bool OrderType { get; set; }

        public bool Solution { get; set; }

        public bool PlanOrProject { get; set; }
    }
}

