using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models.Requests
{
    public class SelectSupplierListForFormRequest
    {
       public int supplierTypeId { get; set; }
       public string? name { get; set; }
    }
}
