using App.Acc.Contact.Requests;
using App.Acc.Contact.Responses;
using App.Common.Models.Responses;
using narit_acc_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Acc.Contact
{
    public interface IContactServices
    {
        List<ContactMain> GetContactMainAll();
        List<ContactMain> GetContactMainId(int Id);
        List<ContactMainResponse> GetContactMain();
        CommonBaseResponse AddContactMain(ContactMainRequest request);
        List<ContactRef> GetContactRefByContactId(int ContactId);
        List<ContactPerson> GetContactPersonByContactId(int ContactId);
        List<ContactBank> GetContactBankByContactId(int ContactId);
        List<ContactAcc> GetContactAccByContactId(int ContactId);
        CommonBaseResponse EditContactMainId(ContactMain request);


    }
}
