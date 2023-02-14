using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Acc.GL.Responses
{
    public class DocumentResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public string Characters { get; set; } = null!;
        public string SpecialCharacters { get; set; } = null!;
        public int Year { get; set; }
        public int Month { get; set; }
        public int? Number { get; set; }
        public int? JournalId { get; set; }
        public string JournalName { get; set; }
        public int? SubjournalId { get; set; }
        public string SubJournalName { get; set; }

        public int Copies { get; set; }
        public int Active { get; set; }
    }
}
