using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class RequestFormCommentStatus
    {
        public int Id { get; set; }
        public int? CodeEnum { get; set; }
        public string? Name { get; set; }
    }
}
