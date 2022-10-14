using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.EIS
{
    public enum ProcureApprovalStatus
    {
        WaitingForApproval = 10,
        Approved = 20,
        Denied = 30
    }
    public enum RqFormActionType
    {
        Read = 5,
        Mail = 7,
        MailFinishNotify = 8,
        WaitingForApproval = 10,
        Print = 0xF,
        Save = 20,
        Delete = 30,
        Sent = 35,
        DeApproved = 40,
        AcceptedByUnitChief = 300,
        HoldByUnitChief = 310,
        DeniedByUnitChief = 320,
        ApprovedByUnitChief = 330,
        AcceptedByProjectManager = 400,
        HoldByProjectManager = 410,
        DeniedByProjectManager = 420,
        ApprovedByProjectManager = 430,
        AcceptedByFinance = 800,
        HoldByFinance = 810,
        DeniedByFinance = 820,
        ApprovedByFinance = 830,
        AcceptedBySuppliesUnitChief = 1000,
        HoldBySuppliesUnitChief = 1010,
        DeniedBySuppliesUnitChief = 1020,
        ApprovedBySuppliesUnitChief = 1030
    }
}
