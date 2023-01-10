using System;
namespace App.FIN.Models.Responses
{
	public class EditDeniedRequestFormPlanViewDateResponses
	{
        public DateTime? WriteDate { get; set; }

        public DateTime? FinishedTransformDate { get; set; }

        public int Id { get; set; }

        public string? Name { get; set; }

        public string Purpose { get; set; } 

        public Double Balance { get; set; }
    }
}

