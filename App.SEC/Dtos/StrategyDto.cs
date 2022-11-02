using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Dtos
{
    public class StrategyDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? ParentStrategyId { get; set; }
        public int? ReferenceOldId { get; set; }
        public List<StrategyDto>? Strategy { get; set; }
    }
}
