using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.FIN.Models.Requests
{
    public class ViewProcureReimbursementMemoFormListForApprovalRequest
    {
        public int year { get; set; }
        public int planTId { get; set; }
    }
}
