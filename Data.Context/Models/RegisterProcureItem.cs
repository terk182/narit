using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class RegisterProcureItem
    {
        public RegisterProcureItem()
        {
            RegisterDurableItems = new HashSet<RegisterDurableItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int DepartmentId { get; set; }
        public int PlanActivityId { get; set; }
        public int FiscalYear { get; set; }
        public int? CheckItemId { get; set; }
        public int? RegisterProcureItemTypeId { get; set; }
        public decimal? Amount { get; set; }
        public string Unit { get; set; } = null!;
        public decimal? Discount { get; set; }
        public int VatMethodEnum { get; set; }
        public decimal? PricePerPiece { get; set; }
        public int? EnduranceTypeEnum { get; set; }
        public DateTime? Date { get; set; }
        public string SupplierName { get; set; } = null!;
        public int? SupplierId { get; set; }
        public int? ProcureLoaningItemId { get; set; }
        public int? CheckItemId1 { get; set; }
        public int? ProcureLoaningSettleItemId { get; set; }
        public int BudgetTypeId { get; set; }

        public virtual CheckItem? CheckItemId1Navigation { get; set; }
        public virtual ProcureLoaningItem? ProcureLoaningItem { get; set; }
        public virtual ProcureLoaningSettleItem? ProcureLoaningSettleItem { get; set; }
        public virtual RegisterProcureItemType? RegisterProcureItemType { get; set; }
        public virtual ICollection<RegisterDurableItem> RegisterDurableItems { get; set; }
    }
}
