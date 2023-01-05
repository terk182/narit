using System;
namespace App.FIN.Models.Requests
{
	public class SelectPlanForStatementCalculationDateListRequest
	{
        public bool ProjectType { get; set; }

        public int FiscalYear { get; set; }
    }
}

