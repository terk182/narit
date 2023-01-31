﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.GL.Requests
{
    public class EditTransectionRequest
    {
        public int Id { get; set; }
        public int? Credit { get; set; }
        public int? Debit { get; set; }
        public string? Status { get; set; }
        public int? SubJournalId { get; set; }
    }
}