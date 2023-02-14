using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Acc.GL.Responses
{
    public class DebtorCreditorResponse
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public int TypeId { get; set; }
        public string? Type { get; set; }
        public int Active { get; set; }
    }
}
