﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.FIN.Models.Requests
{
    public class ViewProcureSettleReceiptFormListForApprovalRequest
    {
        public string docNumber { get; set; }
        public string reqName { get; set; }
        public decimal budgetVal { get; set; }
        public int depId { get; set; }
        public int year { get; set; }
    }
}