using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class View1
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public int Active { get; set; }
        public byte[] CreateDate { get; set; } = null!;
        public string? Detail { get; set; }
        public string? Expr1 { get; set; }
        public string? Expr2 { get; set; }
    }
}
