﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models.Requests
{
    public class DepartmentBudgetLimitRequest
    {
        public int Id { get; set; }
        public int? BudgetLimit { get; set; }
    }
}
