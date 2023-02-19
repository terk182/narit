using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Dtos
{
    public class StrategiesGroupDto : StrategiesGroup
    {
        public List<StrategiesGroup>? StrategiesGroup { get; set; }
    }
}
