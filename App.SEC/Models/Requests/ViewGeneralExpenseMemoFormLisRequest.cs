﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models.Requests
{
    public class ViewGeneralExpenseMemoFormLisRequest
    {
        public int objId { get; set; }

        public int type { get; set; }

        public int FiscalYear { get; set; }

        public decimal budgetVal { get; set; }

        public string? documentNumber { get; set; }
    }
}
