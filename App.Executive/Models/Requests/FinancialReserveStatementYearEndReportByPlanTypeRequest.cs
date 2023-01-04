﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.FIN.Models.Requests
{
    public class FinancialReserveStatementYearEndReportByPlanTypeRequest
    {
        public int fiscalYear { get; set; }
        public int month { get; set; }
        public int planTypeOrder { get; set; }
        public int depId { get; set; }
        public string? Show { get; set; }
    }
}
