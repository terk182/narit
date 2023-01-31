using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.GL.DTO
{
    public class SubJournalDto
    {
        public int Id { get; set; }
        public string? JournalCode { get; set; }
        public string? JournalName { get; set; }
        public string? SubJournalCode { get; set; }
        public string? SubJournalName { get; set; }
        public string? Year { get; set; }
        public string? Month { get; set; }
        public int? Number { get; set; }

    }
}
