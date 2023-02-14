using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Acc.GL.Responses
{
    public class ChartResponse
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public int Index { get; set; }
        public string? Name { get; set; }
        public int Active { get; set; }
        public int? BeforeCode { get; set; }
        public int? AccTypeId { get; set; }
        public string? AccTypeName { get; set; }
        public string? Detail { get; set; }

    }
}

