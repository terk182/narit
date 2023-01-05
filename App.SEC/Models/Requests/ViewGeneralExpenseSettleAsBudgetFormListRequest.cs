using System;
namespace App.SEC.Models.Requests
{
	public class ViewGeneralExpenseSettleAsBudgetFormListRequest
	{
		public string? DocNumber { get; set; }

        public string? Planselect { get; set; }

        public int Budget { get; set; }

        public int FiscalYear { get; set; }

        public bool Perspective { get; set; }

        public bool Show { get; set; }
    }
}

