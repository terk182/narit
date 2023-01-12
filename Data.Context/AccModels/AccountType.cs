using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class AccountType
    {
        public AccountType()
        {
            ChartHeaders = new HashSet<ChartHeader>();
            ChartMajors = new HashSet<ChartMajor>();
            ChartMinors = new HashSet<ChartMinor>();
            ChartSubHeaders = new HashSet<ChartSubHeader>();
            ChartSubMajors = new HashSet<ChartSubMajor>();
            ChartSubMinors = new HashSet<ChartSubMinor>();
            CreditorTypes = new HashSet<CreditorType>();
        }

        public int Id { get; set; }
        public string TypeCode { get; set; } = null!;
        public int Active { get; set; }
        public string? Detail { get; set; }
        public string Name { get; set; } = null!;
        public byte[] CreateDate { get; set; } = null!;

        public virtual ICollection<ChartHeader> ChartHeaders { get; set; }
        public virtual ICollection<ChartMajor> ChartMajors { get; set; }
        public virtual ICollection<ChartMinor> ChartMinors { get; set; }
        public virtual ICollection<ChartSubHeader> ChartSubHeaders { get; set; }
        public virtual ICollection<ChartSubMajor> ChartSubMajors { get; set; }
        public virtual ICollection<ChartSubMinor> ChartSubMinors { get; set; }
        public virtual ICollection<CreditorType> CreditorTypes { get; set; }
    }
}
