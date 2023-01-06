using System;
namespace App.FIN.Models.Responses
{
	public class EditDeniedRequestFormPlanViewDateResponses
	{
		public DateTime DateRequest { get; set; }

		public DateTime DateCancel { get; set; }

		public string? NumberID { get; set; }

        public string? Order { get; set; }

        public Double Balance { get; set; }
    }
}

