using System;
namespace App.SEC.Models.Requests
{
	public class ViewDirectExpenseMemoFormListRequest
	{
		public string? DocNumber { get; set; }

        public string? StateName { get; set; }

        public string? PlanSelect { get; set; }

        public int FiscalYear { get; set; }

        public int Budget { get; set; }

        public bool Perspective { get; set; }

    }
}

