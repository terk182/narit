﻿using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class BudgetType
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int? ParentBudgetTypeId { get; set; }
        public int? ReferenceOldId { get; set; }
        public int ExpenseTypeEnum { get; set; }
        public int GovExpenseTypeEnum { get; set; }
    }
}
