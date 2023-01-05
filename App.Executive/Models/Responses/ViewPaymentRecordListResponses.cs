using System;
namespace App.FIN.Models.Responses
{
	public class ViewPaymentRecordListResponses
	{
		public int No { get; set; }

		public string? Order { get; set; }

		public string? DocNumber { get; set; }

		public DateTime Date { get; set; }

		public Double Balance { get; set; }

		public string? ImpoOrDerNum { get; set; }
		
	}
}

