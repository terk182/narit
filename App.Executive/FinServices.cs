using narit_mis_api.Models;
using App.FIN.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.FIN.Models.Responses;
using App.FIN.Models.Requests;
using Microsoft.EntityFrameworkCore;

namespace App.FIN
{
    public class FinServices : IFinServices
    {
        private readonly NARIT_MIS_LINKContext _database;

        public FinServices(NARIT_MIS_LINKContext context)
        {
            _database = context;
        }
        //public List<RegisterProcureItemTypeDto> getAll()
        //{

        //    return _database.RegisterProcureItemTypes.ToList();
        //}
        //List<RegisterProcureItemTypeDto> IFinServices.getAll()
        //{
        //    return _database.RegisterProcureItemTypes.ToList();
        //}

        public List<RegisterProcureItemTypeDto> getAllRegis()
        {
            var result = new List<RegisterProcureItemTypeDto>();
            var data = _database.RegisterProcureItemTypes.ToList();
            foreach (var item in data)
            {
                result.Add(new RegisterProcureItemTypeDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    Active = item.Active,
                    EnduranceTypeEnum = item.EnduranceTypeEnum,
                    ParentRegisterProcureItemTypeId = item.ParentRegisterProcureItemTypeId,
                    TypeCode = item.TypeCode,
                    UsefulLife = item.UsefulLife

                });
            }
            return result;
        }

       

        //public List<Supplier> getAllSupplier()
        //{
        //    return _database.Suppliers.ToList();
        //}

        public List<SupplierDto> getAllSupplier()
        {
            var result = new List<SupplierDto>();
            var data = _database.Suppliers.ToList();
            foreach (var item in data)
            {
                result.Add(new SupplierDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    ContactPerson = item.ContactPerson,
                    AddressNumber = item.AddressNumber,
                    RoadName = item.RoadName,
                    MooBaan = item.MooBaan,
                    TamBon = item.TamBon,
                    AmPhur = item.AmPhur,
                    Province = item.Province,
                    Active = item.Active,
                    PostCode = item.PostCode,
                    CommercialRegistrationId = item.CommercialRegistrationId,
                    TaxRegistrationId = item.TaxRegistrationId,
                    CertificateOfPartnershipId = item.CertificateOfPartnershipId,
                    CertificateOfPartnershipDate = item.CertificateOfPartnershipDate,
                    TelephoneNumber = item.TelephoneNumber,
                    FaxNumber = item.FaxNumber,
                    SupplierTypeId = item.SupplierTypeId,
                    IsJuristicPerson = item.IsJuristicPerson,
                    SupplierType = item.SupplierType

                });
            }
            return result;
        }

        //public RegisterProcureItemType getById(int id)
        //{
        //    var data = _database.RegisterProcureItemTypes.Where(x => x.Id == id).FirstOrDefault();
        //    return data == null ? new RegisterProcureItemType() : data;
        //}

        public List<SupplierDto> getSupplierbyName(string name)
        {
            var result = new List<SupplierDto>();
            var data = _database.Suppliers.Where(x => x.Name == name).ToList();
            foreach (var item in data)
            {
                result.Add(new SupplierDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    ContactPerson = item.ContactPerson,
                    AddressNumber = item.AddressNumber,
                    RoadName = item.RoadName,
                    MooBaan = item.MooBaan,
                    TamBon = item.TamBon,
                    AmPhur = item.AmPhur,
                    Province = item.Province,
                    Active = item.Active,
                    PostCode = item.PostCode,
                    CommercialRegistrationId = item.CommercialRegistrationId,
                    TaxRegistrationId = item.TaxRegistrationId,
                    CertificateOfPartnershipId = item.CertificateOfPartnershipId,
                    CertificateOfPartnershipDate = item.CertificateOfPartnershipDate,
                    TelephoneNumber = item.TelephoneNumber,
                    FaxNumber = item.FaxNumber,
                    SupplierTypeId = item.SupplierTypeId,
                    IsJuristicPerson = item.IsJuristicPerson,
                    SupplierType = item.SupplierType

                });
            }
            return result;
        }

       public List<ProcureStoreLocationDto> getAllStoreLocation()
        {
            var result = new List<ProcureStoreLocationDto>();
            var data = _database.ProcureStoreLocations.ToList();
            foreach (var item in data)
            {
                result.Add(new ProcureStoreLocationDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    Active = item.Active,
                    ParentProcureStoreLocationId = item.ParentProcureStoreLocationId,
                    ProcureStoreLocationTypeEnum = item.ProcureStoreLocationTypeEnum,
                    Detail = item.Detail,
                    Code = item.Code,
                    Area = item.Area,
                    CanvasPosition = item.CanvasPosition,
                    HrdepartmentId = item.HrdepartmentId,
                    ImagePath = item.ImagePath,
                    //ParentProcureStoreLocation = item.ParentProcureStoreLocation

                });
            }
            return result;
        }

        public FinBaseResponse ProcureItemTypeSetup(ProcureItemTypeRequest request)
        {
            var _ProcureItemType = new RegisterProcureItemType();
            _ProcureItemType.Id = request.Id;
            _ProcureItemType.Name = request.Name;
            _ProcureItemType.Active = request.Active;
            _ProcureItemType.EnduranceTypeEnum = request.EnduranceTypeEnum; 
            _ProcureItemType.TypeCode = request.TypeCode;
            _ProcureItemType.UsefulLife = request.UsefulLife;

            if (request.ParentRegisterProcureItemTypeId != 0)
            {
                _ProcureItemType.ParentRegisterProcureItemTypeId = request.ParentRegisterProcureItemTypeId;
            }
            _database.Entry(_ProcureItemType).State = _ProcureItemType.Id == 0 ?
                                               EntityState.Added :
                                               EntityState.Modified;

            var result = _database.SaveChanges();
            var response = new FinBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = _ProcureItemType.Id == 0 ? "update" : "insert";
            return response;

        }

        public FinBaseResponse SetupSupplierDetail(SupplierRequest request)
        {
            var _SupplierSetup = new Supplier();
            _SupplierSetup.Id = request.Id;
            _SupplierSetup.Name = request.Name; 
            _SupplierSetup.ContactPerson = request.ContactPerson;
            _SupplierSetup.AddressNumber = request.AddressNumber;
            _SupplierSetup.RoadName = request.RoadName;
            _SupplierSetup.MooBaan = request.MooBaan;
            _SupplierSetup.TamBon = request.TamBon;
            _SupplierSetup.AmPhur = request.AmPhur;
            _SupplierSetup.Province = request.Province;
            _SupplierSetup.Active = request.Active;
            _SupplierSetup.PostCode = request.PostCode;
            _SupplierSetup.CommercialRegistrationId = request.CommercialRegistrationId;
            _SupplierSetup.TaxRegistrationId = request.TaxRegistrationId;
            _SupplierSetup.CertificateOfPartnershipId = request.CertificateOfPartnershipId;
            _SupplierSetup.CertificateOfPartnershipDate = request.CertificateOfPartnershipDate; 
            _SupplierSetup.TelephoneNumber = request.TelephoneNumber;
            _SupplierSetup.FaxNumber = request.FaxNumber;
           // _SupplierSetup.SupplierTypeId = request.SupplierTypeId;
            _SupplierSetup.IsJuristicPerson = request.IsJuristicPerson;

            _database.Entry(_SupplierSetup).State = _SupplierSetup.Id == 0 ?
                                             EntityState.Added :
                                             EntityState.Modified;

            var result = _database.SaveChanges();
            var response = new FinBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = _SupplierSetup.Id == 0 ? "update" : "insert";
            return response;
        }
    }
}
