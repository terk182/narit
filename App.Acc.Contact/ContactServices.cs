using App.Acc.Contact.Requests;
using App.Acc.Contact.Responses;
using App.Common.Models.Responses;
using Microsoft.EntityFrameworkCore;
using narit_acc_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Acc.Contact
{
    public class ContactServices : IContactServices
    {
        private readonly CGI_ACCContext _databaseACC;

        public ContactServices(CGI_ACCContext context)
        {
            _databaseACC = context;
        }

        // Contact
        public List<ContactMain> GetContactMainAll()
        {
            List<ContactMain> ContactMainAll = _databaseACC.ContactMains.ToList();
            return ContactMainAll;
        }

        public List<ContactMain> GetContactMainId(int Id)
        {
            List<ContactMain> ContactMainAll = _databaseACC.ContactMains.Where( x => x.Id == Id ).ToList();
            return ContactMainAll;
        }

        public List<ContactMainResponse> GetContactMain()
        {
            var result = new List<ContactMainResponse>();
            var data = _databaseACC.ContactMains.ToList();
            foreach (var item in data)
            {
                result.Add(new ContactMainResponse
                {
                    Id = item.Id,
                    Code = item.Code,
                    ContactName = item.ContactName,
                    ContactTypeID = item.ContactTypeId,
                    ContactTypeName = item.ContactTypeId == 1 ? "นิติบุคคล" : "บุคคลธรรมดา",
                    Active = item.Active
                });
            }
            return result;
        }

        public CommonBaseResponse AddContactMain(ContactMainRequest request)
        {
            var response = new CommonBaseResponse();
            if (request.Id == 0)
            {
                var getcontactname = _databaseACC.ContactMains.OrderByDescending(x => x.Id).FirstOrDefault();
                var codecontact = (getcontactname.Id) + 1;
                var codecode = DateTime.Now.ToString("yy0000");
                var beforecodecontact = codecode + codecontact;
                var _ContactMain = new ContactMain();
                _ContactMain.Active = request.Active;
                _ContactMain.Code = beforecodecontact;
                _ContactMain.Country = request.Country;
                _ContactMain.RegistrationNumber = request.RegistrationNumber;
                _ContactMain.OfficeType = request.OfficeType;
                _ContactMain.ContactTypeId = request.ContactTypeId;
                _ContactMain.ContactSubTypeId = request.ContactSubTypeId;
                _ContactMain.ContactPrefix = request.ContactPrefix;
                _ContactMain.ContactName = request.ContactName;
                _ContactMain.ContactSurname = request.ContactSurname;
                _ContactMain.RegisteredName = request.RegisteredName;
                _ContactMain.RegisteredAddress = request.RegisteredAddress;
                _ContactMain.RegisteredSubdistrict = request.RegisteredSubdistrict;
                _ContactMain.RegisteredDistrict = request.RegisteredDistrict;
                _ContactMain.RegisteredProvince = request.RegisteredProvince;
                _ContactMain.RegisteredPostcode = request.RegisteredPostcode;
                _ContactMain.ContactPhone = request.ContactPhone;
                _ContactMain.ContactEmail = request.ContactEmail;
                _ContactMain.ContactDate = DateTime.Now;
                _databaseACC.Entry(_ContactMain).State = EntityState.Added;
                var result = _databaseACC.SaveChanges();
                response.Success = true;
                response.Messsage = "Add complete";
                response.Data = _ContactMain;
            }
            else
            {
                response.Success = false;
                response.Messsage = "Error";
                response.Data = null;
            }
            return response;
        }

        public List<ContactRef> GetContactRefByContactId(int ContactId)
        {
            List<ContactRef> ContactRef = _databaseACC.ContactRefs.Where(x => x.ContactId == ContactId).ToList();
            return ContactRef;
        }

        public List<ContactPerson> GetContactPersonByContactId(int ContactId)
        {
            List<ContactPerson> ContactPerson = _databaseACC.ContactPeople.Where(x => x.ContactId == ContactId).ToList();
            return ContactPerson;
        }

        public List<ContactBank> GetContactBankByContactId(int ContactId)
        {
            List<ContactBank> ContactBank = _databaseACC.ContactBanks.Where(x => x.ContactId == ContactId).ToList();
            return ContactBank;
        }
        public List<ContactAcc> GetContactAccByContactId(int ContactId)
        {
            List<ContactAcc> ContactAcc = _databaseACC.ContactAccs.Where(x => x.ContactId == ContactId).ToList();
            return ContactAcc;
        }

        public CommonBaseResponse EditContactMainId(ContactMain request)
        {
            var response = new CommonBaseResponse();
            var checkid = _databaseACC.ContactMains.Where(x => x.Id == request.Id).FirstOrDefault();

            if (checkid == null)
            {
                response.Success = false;
                response.Messsage = " No Data ";
            }
            if (checkid != null)
            {
                _databaseACC.Entry(request).State = EntityState.Modified;
                var result = _databaseACC.SaveChanges();
                response.Success = true;
                response.Messsage = "Edit complete";
            }
            return response;
        }
    }
}
