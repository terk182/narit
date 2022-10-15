using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Procure
{
    public interface IProcureServices
    {
        List<RequestForm> getRequestFormbyYear (int year);
        List<ApproveForm> getApproveFormsbyYear(int year);
        List<OrderForm> getOrderFormbyYear(int year);
        List<CheckForm> getCheckFormbyYear(int year);
        List<ProcureLoaningMemoForm> getProcureLoaningMemoFormsbyYear(int year);
        List<ApproveItem> getApproveItemsbyYear(int year);

        decimal WaitForDeliveryAmount(List<OrderForm> OrderForm);
    }
}
