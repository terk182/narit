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
using System.Drawing;
using App.SEC.Models.Responses;

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

        public ViewRequestFormListResponses ViewRequestFormListForFinancialApproval(ViewRequestFormListRequest request)
        {
            var result = new ViewRequestFormListResponses();
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

        List<RegisterProcureItemTypeDto> IFinServices.getAllRegis()
        {
            throw new NotImplementedException();
        }

        List<SupplierDto> IFinServices.getAllSupplier()
        {
            throw new NotImplementedException();
        }

        List<SupplierDto> IFinServices.getSupplierbyName(string name)
        {
            throw new NotImplementedException();
        }

        List<ProcureStoreLocationDto> IFinServices.getAllStoreLocation()
        {
            throw new NotImplementedException();
        }

        FinBaseResponse IFinServices.ProcureItemTypeSetup(ProcureItemTypeRequest request)
        {
            throw new NotImplementedException();
        }

        FinBaseResponse IFinServices.SupplierDetailSetup(SupplierRequest request)
        {
            throw new NotImplementedException();
        }

        FinBaseResponse IFinServices.ProcureStoreLocationSetup(ProcureStoreLocationRequest request)
        {
            throw new NotImplementedException();
        }

        DocumentFormResponse IFinServices.DocumentForm(DocumentFormRequest request)
        {
            throw new NotImplementedException();
        }

        ViewRequestFormListResponses IFinServices.ViewRequestFormListForFinancialApproval(ViewRequestFormListRequest request)
        {
            throw new NotImplementedException();
        }

        public List<RegisterProcureItem> RegisterProcureItemSearch(int checkBox, int fiscalYear, int departmentId)
        {
            var data = _database.RegisterProcureItems.Where(x => x.FiscalYear == fiscalYear && x.Active && x.DepartmentId == departmentId).ToList();
            if (checkBox == 0)
            {
                data = _database.RegisterProcureItems.Where(x => x.FiscalYear == fiscalYear && x.Active && x.DepartmentId == departmentId).ToList();
                
            }
            else if (checkBox == 10)
            {
                data = _database.RegisterProcureItems.Where(x => x.FiscalYear == fiscalYear && x.Active && x.DepartmentId == departmentId && x.EnduranceTypeEnum == 10).ToList();
            }
            else if(checkBox == 30)
            {
                data = _database.RegisterProcureItems.Where(x => x.FiscalYear == fiscalYear && x.Active && x.DepartmentId == departmentId && x.EnduranceTypeEnum == 30).ToList();
            }
            else if (checkBox == 40)
            {
                data = _database.RegisterProcureItems.Where(x => x.FiscalYear == fiscalYear && x.Active && x.DepartmentId == departmentId && x.EnduranceTypeEnum == 40).ToList();
            }
            else if (checkBox == 50)
            {
                data = _database.RegisterProcureItems.Where(x => x.FiscalYear == fiscalYear && x.Active && x.DepartmentId == departmentId && x.EnduranceTypeEnum == 50).ToList();
            }
            return data;

        }

        public List<RegisterProcureItem> ShowRegisterProcureItemListByDepartment(int checkBox, int fiscalYear, int departmentId)
        {
            var data = _database.RegisterProcureItems.Where(x => x.FiscalYear == fiscalYear && x.Active && x.DepartmentId == departmentId).ToList();
            if (checkBox == 0)
            {
                data = _database.RegisterProcureItems.Where(x => x.FiscalYear == fiscalYear && x.Active && x.DepartmentId == departmentId).ToList();

            }
            else if (checkBox == 10)
            {
                data = _database.RegisterProcureItems.Where(x => x.FiscalYear == fiscalYear && x.Active && x.DepartmentId == departmentId && x.EnduranceTypeEnum == 10).ToList();
            }
            else if (checkBox == 30)
            {
                data = _database.RegisterProcureItems.Where(x => x.FiscalYear == fiscalYear && x.Active && x.DepartmentId == departmentId && x.EnduranceTypeEnum == 30).ToList();
            }
            else if (checkBox == 40)
            {
                data = _database.RegisterProcureItems.Where(x => x.FiscalYear == fiscalYear && x.Active && x.DepartmentId == departmentId && x.EnduranceTypeEnum == 40).ToList();
            }
            else if (checkBox == 50)
            {
                data = _database.RegisterProcureItems.Where(x => x.FiscalYear == fiscalYear && x.Active && x.DepartmentId == departmentId && x.EnduranceTypeEnum == 50).ToList();
            }
            return data;

        }
            
        public RequestApproveOrderCheckformDto SearchProcureDocForTrackingRoute(int document, string documentNumber, int fiscalYear)
        {
            var result = new RequestApproveOrderCheckformDto();
            var dataRequest = _database.RequestForms.ToList();
            var dataApprove = _database.ApproveForms.ToList();
            var dataOrder = _database.OrderForms.ToList();
            var dataCheck = _database.CheckForms.ToList();

            if (document == 1)
            {
                if(documentNumber == "0")
                {
                    dataRequest = _database.RequestForms.Where(x => x.FiscalYear == fiscalYear).ToList();
                    var RequestForm = new List<RequestFormDtoForSearchProcureDocForTrackingRoute>();
                    foreach (var item in dataRequest)
                    {

                        //var RequestForm = new List<RequestForm>();
                        //foreach (var item2 in item.)
                        //{
                            RequestForm.Add(new RequestFormDtoForSearchProcureDocForTrackingRoute
                            //narit_mis_api.Models.RequestForm
                            {
                                Id = item.Id,
                                Name = item.Name,
                                Active = item.Active,
                                WriteDate = item.WriteDate,
                                DocumentNumber = item.DocumentNumber,
                                DepartmentName = item.DepartmentName,
                                MedianPrice = item.MedianPrice,

                            });
                        //}
                        result.requestFormsDto = RequestForm;

                    }

                }
                else
                {
                    dataRequest = _database.RequestForms.Where(x => x.FiscalYear == fiscalYear && x.DocumentNumber == documentNumber).ToList();
                }
                
            }
            else if (document == 2)
            {
                if (documentNumber == null)
                {
                    dataApprove = _database.ApproveForms.Where(x => x.FiscalYear == fiscalYear).ToList();
                }
                else
                {
                    dataApprove = _database.ApproveForms.Where(x => x.FiscalYear == fiscalYear && x.DocumentNumber == documentNumber).ToList();
                }

            }
            else if (document == 3)
            {
                if (documentNumber == null)
                {
                    dataOrder = _database.OrderForms.Where(x => x.FiscalYear == fiscalYear).ToList();
                }
                else
                {
                    dataOrder = _database.OrderForms.Where(x => x.FiscalYear == fiscalYear && x.DocumentNumber == documentNumber).ToList();
                }

            }
            else if (document == 4)
            {
                if (documentNumber == null)
                {
                    dataCheck = _database.CheckForms.Where(x => x.FiscalYear == fiscalYear).ToList();
                }
                else
                {
                    dataCheck = _database.CheckForms.Where(x => x.FiscalYear == fiscalYear && x.DocumentNumber == documentNumber).ToList();
                }

            }
            return result;
        }

        public List<CheckForm> ViewRequestFormList(ViewRequestFormListMainRequest request)
        {
            var result = new List<CheckForm>();
            var query = _database.CheckForms.Where(c => c.Active && (request.isProcurePowerUser ? true : c.CreateByStaffId == request.staffId) && ((request.documentNumber != "") ? c.DocumentNumber.Contains(request.documentNumber) : true)
               && ((request.SupplierName != "") ? c.SupplierName.Contains(request.SupplierName) : true) && ((request.procureTypeEnum != 0) ? (c.ProcureTypeEnum == request.procureTypeEnum) : true)
               && ((request.DocumentTypeRadioButtonList != "All") ? ((request.DocumentTypeRadioButtonList == "Form" ? (c.ProcureMethodEnum == 10): (c.ProcureMethodEnum != 10))) : true)).OrderByDescending(c => c.Id).ToList();

            if (request.PlanTypeId == 0)
            {
                result=  query.Where(c => c.FiscalYear == request.FiscalYear).OrderByDescending(c => c.Id).ToList();
            }
            else
            {
                result= query.Where(c => c.PlanTypeId == request.PlanTypeId).OrderByDescending(c => c.Id).ToList();
            }


            return result;
        }

        public PlanFormFinancialStatusReportRespone PlanFormFinancialStatusReport(PlanFormFinancialStatusReportRequest request)
        {
            var respons = new PlanFormFinancialStatusReportRespone();
            var fromRequest = new List<FromRequest>();
            var offerRequest = new List<OfferRequest>();
            var  gMemoFormList = _database.GeneralExpenseMemoForms.Where(c => c.Active && c.FiscalYear == request.FiscalYear && (request.reqDepId != 0 ? c.RequestDepartmentId == request.reqDepId : true) && (request.pTypeId != 0 ? c.GeneralExpenses.Any(d => c.Active && d.PlanTypeId == request.pTypeId) : true)
            && (request.documentNumber != "" ? c.DocumentNumber.Contains(request.documentNumber) : true) && (request.name != "" ? c.StatementName.Contains(request.name) : true)).Include(c=> c.GeneralExpenses).Include(c => c.WithdrawalItems).ToList();



            if (gMemoFormList != null && gMemoFormList.Count > 0)
            {
                int i = 1;
                

                foreach (var gMemoForm in gMemoFormList)
                {
                   
                    fromRequest.Add(new FromRequest
                    {
                        No = i++,
                        documentNumber = gMemoForm.DocumentNumber,
                        WriteDate = gMemoForm.WriteDate.ToString(),
                        PlanTypeName = gMemoForm.PlanTypeName + " " + gMemoForm.PlanCoreName +" " + gMemoForm.BudgetTypeName, //+ " " + gMemoForm.PlanActivityName + " "
                        RequestDepartmentName = gMemoForm.RequestDepartmentName,
                        StatementName = gMemoForm.StatementName,
                        totalBudget= gMemoForm.GeneralExpenses.Where(c => c.Active && !c.IsPostApprovedAdded).Sum(d => d.TotalBudget),

                        approveBudget = gMemoForm.FirstBorrowAmount + gMemoForm.SecondBorrowAmount + gMemoForm.ThirdBorrowAmount + gMemoForm.FourthBorrowAmount + gMemoForm.FifthBorrowAmount,
                        UsedBudget = UsedBudget(),
                        disbursedBudget =0,
                        remaining = 0,
                        borrowBudget = 0,
                        amountBudget = 0,
                    }) ;





                   
                }
            }


            var rqpvFormList = _database.RequestFormPlanViews.Where(c => c.Active && c.FiscalYear == request.FiscalYear && (request.reqDepId != 0 ? c.RequestDepartmentId == request.reqDepId : true) && (request.pTypeId != 0 ? c.PlanTypeId == request.pTypeId : true)
            && (request.documentNumber != "" ? c.DocumentNumber.Contains(request.documentNumber) : true) && (request.name != "" ? c.StatementName.Contains(request.name) : true)).Include(c => c.RequestViewUsedPlanItems).ToList();

            int ii = 1;

            foreach (var rqpvForm in rqpvFormList)
            {
      
                    

                offerRequest.Add(new OfferRequest
                {
                    No = ii++,
                    documentNumber = rqpvForm.DocumentNumber,
                    WriteDate = rqpvForm.WriteDate.ToString(),
                    PlanTypeName = rqpvForm.PlanTypeName,
                    RequestDepartmentName = rqpvForm.DepartmentName,
                    StatementName = rqpvForm.StatementName,
                    totalBudget = 0,

                    approveBudget = 0,
                    UsedBudget = 0,
                    disbursedBudget = 0,
                    remaining = 0,
                    inspected = 0

                }); ;
            }



            respons.offerRequest = offerRequest;
            respons.fromRequest = fromRequest;

            return respons;
        }

        public decimal UsedBudget()
        {




                    var data = _database.WithdrawalItems.Any((WithdrawalItem c) => c.Active);
                   
                        decimal num = _database.WithdrawalItems.Where((WithdrawalItem c) => c.Active).Sum((WithdrawalItem c) => c.WithDrawnAmount);
                        decimal num2 = 0.00m;
                        if (_database.SettlementItems.Any((SettlementItem c) => c.Active && c.GeneralExpenseSettleForm.ApprovalStatusEnum == 20))
                        {
                            num2 = _database.SettlementItems.Where((SettlementItem c) => c.Active).Sum((SettlementItem c) => c.SettleAmount);
                        }

                        return num - num2;
         
        }

        

        public ViewProcureLoaningMemoFormListForApprovalRequest ViewProcureLoaningMemoFormListForApproval()
        {
            return new ViewProcureLoaningMemoFormListForApprovalRequest();
        }

        public ViewProcureReimbursementMemoFormListForApprovalRequest ViewProcureReimbursementMemoFormListForApproval()
        {
            return new ViewProcureReimbursementMemoFormListForApprovalRequest();
        }

        public ViewProcureSettleReceiptFormListForApprovalRequest ViewProcureSettleReceiptFormListForApproval()
        {
            return new ViewProcureSettleReceiptFormListForApprovalRequest();
        }

        public ViewProcureSettleMemoFormListForApprovalRequest ViewProcureSettleMemoFormListForApproval()
        {
            return new ViewProcureSettleMemoFormListForApprovalRequest();
        }

        public FinancialReserveStatementYearEndBriefReportByBudgetTypeRequest FinancialReserveStatementYearEndBriefReportByBudgetType()
        {
            return new FinancialReserveStatementYearEndBriefReportByBudgetTypeRequest();
        }

        public FinancialReserveStatementYearEndReportByBudgetTypeRequest FinancialReserveStatementYearEndReportByBudgetType()
        {
            return new FinancialReserveStatementYearEndReportByBudgetTypeRequest();
        }

        public FinancialReserveStatementYearEndReportByPlanTypeRequest FinancialReserveStatementYearEndReportByPlanType()
        {
            return new FinancialReserveStatementYearEndReportByPlanTypeRequest();
        }

        public FinancialReserveStatementMonthlyBriefReportByBudgetTypeRequest FinancialReserveStatementMonthlyBriefReportByBudgetType()
        {
            return new FinancialReserveStatementMonthlyBriefReportByBudgetTypeRequest();
        }

        public FinancialReserveStatementMonthlyReportByBudgetTypeRequest FinancialReserveStatementMonthlyReportByBudgetType()
        {
            return new FinancialReserveStatementMonthlyReportByBudgetTypeRequest();
        }

        public List<ViewFormForApprovalByFinanceResponses> ViewFormForApprovalByFinance(ViewFormForApprovalByFinanceRequest request)
        {
            var _viewFormForApprovalByFinanceResponses = new List<ViewFormForApprovalByFinanceResponses>();

            _viewFormForApprovalByFinanceResponses.Add(new ViewFormForApprovalByFinanceResponses
            {
                no = 1,
                date = DateTime.Now,
                type = "0",
                id = 1,
                requester = "Palm",
                price = 100.45,
                status = true,
            });
            _viewFormForApprovalByFinanceResponses.Add(new ViewFormForApprovalByFinanceResponses
            {
                no = 2,
                date = DateTime.Now,
                type = "0",
                id = 2,
                requester = "Nuw",
                price = 150.50,
                status = false,
            });
            
            return _viewFormForApprovalByFinanceResponses;
        }

        public List<ViewFormForApprovalByHeadOfFinanceResponse> ViewFormForApprovalByHeadOfFinance(ViewFormForApprovalByHeadOfFinanceRequest request)
        {
            var _viewFormForApprovalByHeadOfFinanceResponses = new List<ViewFormForApprovalByHeadOfFinanceResponse>();

            _viewFormForApprovalByHeadOfFinanceResponses.Add(new ViewFormForApprovalByHeadOfFinanceResponse
            {
                no = 1,
                date = DateTime.Now,
                type = "0",
                id = 1,
                requester = "Nuw",
                price = 893,
                status = true,
            });
            _viewFormForApprovalByHeadOfFinanceResponses.Add(new ViewFormForApprovalByHeadOfFinanceResponse
            {
                no = 2,
                date = DateTime.Now,
                type = "0",
                id = 2,
                requester = "Slime",
                price = 300,
                status = true,
            });
            return _viewFormForApprovalByHeadOfFinanceResponses;
        }

        public List<ViewProcureLoaningMemoFormListForApprovalResponses> ViewProcureLoaningMemoFormListForApproval(ViewProcureLoaningMemoFormListForApprovalRequest request)
        {
            var _viewProcureLoaningMemoFormListForApprovalResponses = new List<ViewProcureLoaningMemoFormListForApprovalResponses>();
            _viewProcureLoaningMemoFormListForApprovalResponses.Add(new ViewProcureLoaningMemoFormListForApprovalResponses
            {
                date = DateTime.Now,
                id = 1,
                requester = "Kong",
                agency = "someAgency",
                status = true,
                price= 200,
                transferDate= DateTime.Now,
                print = "Yes",
            });
            return _viewProcureLoaningMemoFormListForApprovalResponses;
        }
    }


}
