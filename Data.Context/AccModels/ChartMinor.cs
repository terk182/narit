using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class ChartMinor
    {
        public ChartMinor()
        {
            DebtorTypes = new HashSet<DebtorType>();
            TransectionCreditNavigations = new HashSet<Transection>();
            TransectionDebitNavigations = new HashSet<Transection>();
            TransectionTypes = new HashSet<TransectionType>();
        }

        public int Id { get; set; }
        public string? ChartMinorCode { get; set; }
        public int Index { get; set; }
        public string? Name { get; set; }
        public int Active { get; set; }
        public byte[] CreateDate { get; set; } = null!;
        public int? ChartSubMajorId { get; set; }
        public string? Detail { get; set; }
        public int? AccTypeId { get; set; }
        public int? Balance { get; set; }

        public virtual AccountType? AccType { get; set; }
        public virtual ChartSubMajor? ChartSubMajor { get; set; }
        public virtual ICollection<DebtorType> DebtorTypes { get; set; }
        public virtual ICollection<Transection> TransectionCreditNavigations { get; set; }
        public virtual ICollection<Transection> TransectionDebitNavigations { get; set; }
        public virtual ICollection<TransectionType> TransectionTypes { get; set; }
    }
}
