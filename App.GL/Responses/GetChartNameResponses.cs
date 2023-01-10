using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.GL.Responses
{
    public class GetChartNameResponses
    {
        public int? BeforeChartId { get; set; }
        public string? BeforeChartName { get; set; }
        public int Id { get; set; }
        public string? ChartCode { get; set; }
        public int Index { get; set; }
        public string? Name { get; set; }
        public int Active { get; set; }
        public string? Detail { get; set; }
        public int? AccTypeId { get; set; }
    }
}
