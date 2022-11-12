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
using System.Xml.Linq;
using System.Xml;

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

        public FinBaseResponse SupplierDetailSetup(SupplierRequest request)
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

        public FinBaseResponse ProcureStoreLocationSetup(ProcureStoreLocationRequest request)
        {
            var _ProcureStoreLocationSetup = new ProcureStoreLocation();
            _ProcureStoreLocationSetup.Id = request.Id;
            _ProcureStoreLocationSetup.Name = request.Name;
            _ProcureStoreLocationSetup.Active = request.Active;
            _ProcureStoreLocationSetup.ProcureStoreLocationTypeEnum = request.ProcureStoreLocationTypeEnum;
            _ProcureStoreLocationSetup.Detail = request.Detail;
            _ProcureStoreLocationSetup.Code = request.Code;
            _ProcureStoreLocationSetup.Area = request.Area;
            _ProcureStoreLocationSetup.CanvasPosition = request.CanvasPosition;
            _ProcureStoreLocationSetup.HrdepartmentId = request.HrdepartmentId;
            _ProcureStoreLocationSetup.ImagePath = request.ImagePath;

            if (request.ParentProcureStoreLocationId != 0)
            {
                _ProcureStoreLocationSetup.ParentProcureStoreLocationId = request.ParentProcureStoreLocationId;
            }
            _database.Entry(_ProcureStoreLocationSetup).State = _ProcureStoreLocationSetup.Id == 0 ?
                                               EntityState.Added :
                                               EntityState.Modified;

            var result = _database.SaveChanges();
            var response = new FinBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = _ProcureStoreLocationSetup.Id == 0 ? "update" : "insert";
            return response;
        }

        public DocumentFormResponse DocumentForm(DocumentFormRequest request)
        {
            var response = new DocumentFormResponse();
            var data = _database.GeneralExpenseMemoForms.Where(c => c.Active && c.FiscalYear == request.FiscalYear && !c.IsHidden && c.IsSent && c.ApprovalStatusEnum != 30 && (c.ApprovalStatusEnum == 10 || (c.ApprovalStatusEnum > 10 && c.PlanFormApprovalStatusEnum >= 830 && c.PlanFormApprovalStatusEnum <= 1020)) && ((request.DocumentNumber != "") ? c.DocumentNumber.Contains(request.DocumentNumber) : true) && ((request.RequesterName != "") ? c.RequesterName.Contains(request.RequesterName) : true) && (request.DepartmentId == 0 ? true : (c.DepartmentId == request.DepartmentId || c.GeneralExpenses.Any(d => d.Active && d.DepartmentId == request.DepartmentId))) &&
                  (request.PlanTypeId == 0 ? true : (c.PlanTypeId == request.PlanTypeId || c.GeneralExpenses.Any(d => d.Active && d.PlanTypeId == request.PlanTypeId)))).Include(c => c.GeneralExpenses).ToList();
            var _list = new List<DocumentFormData>();
            foreach (var item in data)
            {

                _list.Add(new DocumentFormData
                {
                    Id = item.Id,
                    Name = item.Name,
                    Active = item.Active,
                    FiscalYear = item.FiscalYear,
                    WriteDate = item.WriteDate,
                    Inform = item.Inform,
                    Enclosures = item.Enclosures,
                    Purpose = item.Purpose,
                    RequesterName = item.RequesterName,
                    RequesterSignDate = item.RequesterSignDate,
                    UnitChiefName = item.UnitChiefName,
                    UnitChiefSignDate = item.UnitChiefSignDate,
                    BudgetCheckerName = item.BudgetCheckerName,
                    BudgetCheckerSignDate = item.BudgetCheckerSignDate,
                    Approver = item.Approver,
                    ApproverSignDate = item.ApproverSignDate,
                    ApprovalStatusEnum = item.ApprovalStatusEnum,
                    DepartmentName = item.DepartmentName,
                    DepartmentId = item.DepartmentId,
                    PlanTypeName = item.PlanTypeName,
                    PlanTypeId = item.PlanTypeId,
                    PlanCoreName = item.PlanCoreName,
                    PlanCoreId = item.PlanCoreId,
                    BudgetTypeName = item.BudgetTypeName,
                    BudgetTypeId = item.BudgetTypeId,
                    PlanCoreRemainBudget = item.PlanCoreRemainBudget,
                    PlanCoreCode = item.PlanCoreCode,
                    ApprovedDate = item.ApprovedDate,
                    DocumentNumber = item.DocumentNumber,
                    StatementPayStatusEnum = item.StatementPayStatusEnum,
                    NetPayValue = item.NetPayValue,
                    CreateDate = item.CreateDate,
                    CreateByStaffId = item.CreateByStaffId,
                    IsBorrow = item.IsBorrow,
                    IsTemporaryInvolve = item.IsTemporaryInvolve,
                    StatementCalculationDate = item.StatementCalculationDate,
                    PlanActivityIdOld = item.PlanActivityIdOld,
                    FundTypeName = item.FundTypeName,
                    FundTypeId = item.FundTypeId,
                    StatementName = item.StatementName,
                    RealInvolvePlanItemId = item.RealInvolvePlanItemId,
                    UsedToInvolvePlanItemId = item.UsedToInvolvePlanItemId,
                    ReserveByStaffName = item.ReserveByStaffName,
                    ReserveRemark = item.ReserveRemark,
                    ReserveForecastValue = item.ReserveForecastValue,
                    ReserveByStaffId = item.ReserveByStaffId,
                    ReserveDate = item.ReserveDate,
                    IsReserve = item.IsReserve,
                    DevelopmentRecordGroupId = item.DevelopmentRecordGroupId,
                    OutsideDutyGroupId = item.OutsideDutyGroupId,
                    ReserveDepartmentId = item.ReserveDepartmentId,
                    ReserveDepartmentName = item.ReserveDepartmentName,
                    SuppliesOfficerName = item.SuppliesOfficerName,
                    HrofficerName = item.HrofficerName,
                    SuppliesOfficerSignDate = item.SuppliesOfficerSignDate,
                    HrofficerSignDate = item.HrofficerSignDate,
                    RequesterDepartmentName = item.RequestDepartmentName,
                    RequesterPositionName = item.RequesterPositionName,
                    ProcureRequest = item.ProcureRequest,
                    FirstProcureComittee = item.FirstProcureComittee,
                    FirstCheckComittee = item.FirstCheckComittee,
                    OtherRequest = item.OtherRequest,
                    FirstBorrower = item.FirstBorrower,
                    SecondBorrower = item.SecondBorrower,
                    ThirdBorrower = item.ThirdBorrower,
                    FirstBorrowAmount = item.FirstBorrowAmount,
                    SecondBorrowAmount = item.SecondBorrowAmount,
                    ThirdBorrowAmount = item.ThirdBorrowAmount,
                    FirstBorrowerPosition = item.FirstBorrowerPosition,
                    ThirdBorrowerPosition = item.ThirdBorrowerPosition,
                    SecondBorrowerPosition = item.SecondBorrowerPosition,
                    FirstBorrowerDepartment = item.FirstBorrowerDepartment,
                    SecondBorrowerDepartment = item.SecondBorrowerDepartment,
                    ThirdBorrowerDepartment = item.ThirdBorrowerDepartment,
                    FourthBorrower = item.FourthBorrower,
                    FourthBorrowAmount = item.FourthBorrowAmount,
                    FourthBorrowerPosition = item.FourthBorrowerDepartment,
                    FourthBorrowerDepartment = item.FourthBorrowerDepartment,
                    FifthBorrower = item.FifthBorrower,
                    FifthBorrowAmount = item.FirstBorrowAmount,
                    FifthBorrowerPosition = item.FirstBorrowerPosition,
                    FifthBorrowerDepartment = item.FifthBorrowerDepartment,
                    RequestDepartmentId = item.RequestDepartmentId,
                    RequestDepartmentName = item.RequestDepartmentName,
                    SettleDay = item.SettleDay,
                    DueDate = item.DueDate,
                    StartCountingDate = item.StartCountingDate,
                    UnitChiefStaffId = item.UnitChiefStaffId,
                    ApproverStaffId = item.ApproverStaffId,
                    PlanFormApprovalStatusEnum = item.PlanFormApprovalStatusEnum,
                    IsHidden = item.IsHidden,
                    ScheduleTitle = item.ScheduleTitle,
                    RelatedRegulation = item.RelatedRegulation,
                    ApproverSignatureId = item.ApproverSignatureId,
                    UnitChiefSignatureId = item.UnitChiefSignatureId,
                    SuppliesOfficerSignatureId = item.SuppliesOfficerSignatureId,
                    ProjectManagerSignatureId = item.ProjectManagerSignatureId,
                    BudgetCheckerSignatureId = item.BudgetCheckerSignatureId,
                    SuppliesOfficerStaffId = item.SuppliesOfficerStaffId,
                    ProjectManagerStaffId = item.ProjectManagerStaffId,
                    RequesterStaffId = item.RequesterStaffId,
                    BudgetCheckerStaffId = item.BudgetCheckerStaffId,
                    RequesterSignatureId = item.RequesterSignatureId,
                    ProjectManager = item.ProjectManager,
                    ProjectManagerSignDate = item.ProjectManagerSignDate,
                    HrofficerStaffId = item.HrofficerStaffId,
                    HrofficerSignatureId = item.HrofficerSignatureId,
                    ProjectManager1SignatureId = item.ProjectManager1SignatureId,
                    ProjectManager1 = item.ProjectManager1,
                    ProjectManager1SignDate = item.ProjectManager1SignDate,
                    ProjectManager1StaffId = item.ProjectManager1StaffId,
                    ProjectManager2SignatureId = item.ProjectManager2SignatureId,
                    ProjectManager2 = item.ProjectManager2,
                    ProjectManager2SignDate = item.ProjectManager2SignDate,
                    ProjectManager2StaffId = item.ProjectManager2StaffId,
                    ProjectManager3SignatureId = item.ProjectManager3SignatureId,
                    ProjectManager3 = item.ProjectManager3,
                    ProjectManager3SignDate = item.ProjectManager3SignDate,
                    ProjectManager3StaffId = item.ProjectManager3StaffId,
                    ProjectManager4SignatureId = item.ProjectManager4SignatureId,
                    ProjectManager4 = item.ProjectManager4,
                    ProjectManager4SignDate = item.ProjectManager4SignDate,
                    ProjectManager4StaffId = item.ProjectManager4StaffId,
                    UnitChiefPosition = item.UnitChiefPosition,
                    BudgetCheckerPosition = item.BudgetCheckerPosition,
                    ApproverPosition = item.ApproverPosition,
                    SuppliesOfficerPosition = item.SuppliesOfficerPosition,
                    HrofficerPosition = item.HrofficerPosition,
                    ProjectManager1Position = item.ProjectManager1Position,
                    ProjectManager2Position = item.ProjectManager2Position,
                    ProjectManager3Position = item.ProjectManager3Position,
                    ProjectManager4Position = item.ProjectManager4Position,
                    IsApproveInstead = item.IsApproveInstead,
                    DocCheckerName = item.DocCheckerName,
                    DocCheckerPosition = item.DocCheckerPosition,
                    DocCheckerSignDate = item.DocCheckerSignDate,
                    DocCheckerStaffId = item.DocCheckerStaffId,
                    DocCheckerSignatureId = item.DocCheckerSignatureId,
                    IsSent = item.IsSent,
                    FirstBorrowerPositionTypeName = item.FirstBorrowerPositionTypeName,
                    SecondBorrowerPositionTypeName = item.SecondBorrowerPositionTypeName,
                    ThirdBorrowerPositionTypeName = item.ThirdBorrowerPositionTypeName,
                    FourthBorrowerPositionTypeName = item.FourthBorrowerPositionTypeName,
                    FifthBorrowerPositionTypeName = item.FifthBorrowerPositionTypeName,
                    //TotalBudget = item.GeneralExpenses.Sum(x => x.TotalBudget)
                });
            }

            response.Success = data != null? true:false;
            response.data = _list;
            return response;
        }

        public ViewRequestFormListResponse ViewRequestFormListForFinancialApproval(ViewRequestFormListRequest request)
        {
            var result = new ViewRequestFormListResponse();
            var respose = new List<RequestFormDto>();
            var data = new List<RequestForm>();
            if (request.perspective == 0) {
                 data = _database.RequestForms.Where(c => c.Active && c.FiscalYear == request.FiscalYear && c.ProcureApprovalStatusEnum == 10 && c.ProcureFormApprovalStatusEnum < 1000
                    && ((request.DocumentNumber != "") ? c.DocumentNumber.Contains(request.DocumentNumber) : true)).OrderByDescending(c => c.Id).ToList();
            }
            else
            {
                switch (request.perspective)
                {
                    case 1:
                         data = _database.RequestForms.Where(c => c.Active && c.ProcureApprovalStatusEnum == 10 && c.ProcureFormApprovalStatusEnum < 1000 && c.PlanTypeId == request.PlanTypeId
                            && ((request.DocumentNumber != "") ? c.DocumentNumber.Contains(request.DocumentNumber) : true)).OrderByDescending(c => c.Id).ToList();
                        break;
                    case 2:
                         data = _database.RequestForms.Where(c => c.Active && c.ProcureApprovalStatusEnum == 10 && c.ProcureFormApprovalStatusEnum < 1000 && c.DepartmentId == request.DepartmentId
                            && ((request.DocumentNumber != "") ? c.DocumentNumber.Contains(request.DocumentNumber) : true)).OrderByDescending(c => c.Id).ToList(); 
                        break;
                    default:
                        break;
                }
            }
            foreach (var item in data)
            {
                respose.Add(new RequestFormDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    WriteDate = item.WriteDate,
                    WriteAt = item.WriteAt,
                    Purpose = item.Purpose,
                    Active = item.Active,
                    Inform = item.Inform,
                    DocumentNumber = item.DocumentNumber,
                    FiscalYear = item.FiscalYear,
                    ProcureTypeEnum = item.ProcureTypeEnum,
                    ProcureMethodEnum = item.ProcureMethodEnum,
                    DepartmentName = item.DepartmentName,
                    PlanTypeName = item.PlanTypeName,
                    Enclosure = item.Enclosure,
                    OtherProcureMethodName = item.OtherProcureMethodName,
                    PlanCoreName = item.PlanCoreName,
                    BudgetTypeName = item.BudgetTypeName,
                    ProcureChairman = item.ProcureChairman,
                    ProcureFirstComittee = item.ProcureFifthComittee,
                    ProcureSecondComittee = item.ProcureSecondComittee,
                    CheckChairman = item.CheckChairman,
                    CheckFirstComittee = item.CheckFirstComittee,
                    CheckSecondComittee = item.CheckSecondComittee,
                    Requester = item.Requester,
                    RequesterSignDate = item.RequesterSignDate,
                    UnitChief = item.UnitChief,
                    UnitChiefSignDate = item.UnitChiefSignDate,
                    BudgetChecker = item.BudgetChecker,
                   // BudgetCheckerSignDate = item.BudgetCheckerSignDate.ToString(),
                    SuppliesOfficer = item.SuppliesOfficer,
                    SuppliesUnitChief = item.SuppliesUnitChief,
                   // SuppliesUnitChiefSignDate = item.SuppliesUnitChiefSignDate,
                    PlanCoreId = item.PlanCoreId,
                    PlanTypeId = item.PlanTypeId,
                    DepartmentId = item.DepartmentId,
                    ProcureApprovalStatusEnum = item.ProcureApprovalStatusEnum,
                    ProcureTransformStatusEnum = item.ProcureTransformStatusEnum,
                    WithInDay = item.WithInDay,
                    FundTypeId = item.FundTypeId,
                    FundTypeName = item.FundTypeName,
                    PlanActivityIdOld = item.PlanActivityIdOld,
                    PlanActivityName = item.PlanActivityName,
                    CreateDate = item.CreateDate,
                    CreateByStaffId = item.CreateByStaffId,
                    WithInDate = item.WithInDate,
                    StatementName = item.StatementName,
                    CheckThirdComittee = item.CheckThirdComittee,
                    CheckFourthComittee = item.CheckFourthComittee,
                    CheckFifthComittee = item.CheckFifthComittee,
                    CheckSecretaryComittee = item.CheckSecretaryComittee,
                    ProcureThirdComittee = item.ProcureThirdComittee,
                    ProcureFourthComittee = item.ProcureFourthComittee,
                    ProcureFifthComittee = item.ProcureFifthComittee,
                    ProcureSecretaryComittee = item.ProcureSecretaryComittee,
                    IsForeign = item.IsForeign,
                    IsUrgent = item.IsUrgent,
                    BudgetTypeEnum = item.BudgetTypeEnum,
                    Topic = item.Topic,
                    ProcureViceChairman = item.ProcureViceChairman,
                    CheckViceChairman = item.CheckViceChairman,
                    CheckSecretaryAndComittee = item.CheckSecretaryAndComittee,
                    ProcureSecretaryAndComittee = item.ProcureSecretaryAndComittee,
                    RequesterPosition = item.RequesterPosition,
                    UnitChiefPosition = item.UnitChiefPosition,
                    MedianPrice = item.MedianPrice,
                    RequestDepartmentId = item.RequestDepartmentId,
                    RequestDepartmentName = item.RequestDepartmentName,
                    IsContinuousProject = item.IsContinuousProject,
                    CheckSixthComittee = item.CheckSixthComittee,
                    CheckSeventhComittee = item.CheckSixthComittee,
                    CheckEighthComittee = item.CheckEighthComittee,
                    CheckNinthComittee = item.CheckNinthComittee,
                    ProcureFormApprovalStatusEnum = item.ProcureFormApprovalStatusEnum,
                    RequesterStaffId = item.RequesterStaffId,
                    DocCheckerStaffId = item.DocCheckerStaffId,
                    UnitChiefStaffId = item.UnitChiefStaffId,
                    ProjectManagerStaffId = item.ProjectManagerStaffId,
                    BudgetCheckerStaffId = item.BudgetCheckerStaffId,
                    SuppliesUnitChiefStaffId = item.SuppliesUnitChiefStaffId,
                    IsSent = item.IsSent,
                    ProjectManagerSignDate = item.ProjectManagerSignDate,
                    ProjectManager = item.ProjectManager,
                   // ProjectManagerPosition = item.ProjectManagerSignatureId,
                    //UnitChiefSignatureId = item.UnitChiefSignatureId,
                    ProjectManagerSignatureId = item.ProjectManagerSignatureId,
                    RequesterSignatureId = item.RequesterSignatureId,
                    BudgetCheckerSignatureId = item.BudgetCheckerSignatureId,
                    SuppliesUnitChiefSignatureId = item.SuppliesUnitChiefSignatureId,
                    BudgetCheckerPosition = item.BudgetCheckerPosition,
                    SuppliesOfficerPosition = item.SuppliesOfficerPosition,
                });
            }
            result.Success = data != null? true: false;
            result.data = respose; 
            return result;
      
        }
    }
}
