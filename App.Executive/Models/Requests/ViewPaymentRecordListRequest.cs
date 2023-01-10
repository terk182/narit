using System;
namespace App.FIN.Models.Requests
{
	public class ViewPaymentRecordListRequest
	{
		public string? PlanSelect { get; set; }

		public string? DocumentNumber { get; set; }

		public int FiscalYear { get; set; }

		public bool Status { get; set; }

        public bool OrderType { get; set; }


    }
}

