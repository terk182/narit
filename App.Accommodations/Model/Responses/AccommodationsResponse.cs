
using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Accommodations.Model.Responses
{
    public class AccommodationsResponse : BaseResponse
    {
        public Accommodation? data { get; set; }
    }
}
