using App.EIS.Models;
using App.PathDetail;
using App.Plan;
using App.Plan.Dtos;
using App.Procure;
using App.SEC;
using App.SEC.Dtos;
using App.SEC.enums;
using App.SEC.helper;
using App.SEC.Models;
using App.SEC.Models.Requests;
using App.SEC.Models.Responses;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace narit_mis_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SecController : Controller
    {
        protected readonly IPlanServices _Service;
        protected readonly ISecServices _SecServices;
       
        private readonly ILogger _Logger;

        public SecController(ILogger<SecController> logger, IPlanServices PlanServices, ISecServices SecServices)
        {
            _Service = PlanServices;
            _SecServices = SecServices;

            _Logger = logger;

            //_configuration = Configuration;
            // connecttion = _configuration.GetConnectionString("Defaultconnectton");
        }
        #region  Filing Operate

      

        [HttpGet]
        [Route("/Filing/Operate/DownloadFile")]
        public IActionResult DownloadFile()
        {
            return Json("DownloadFile");
        }


        [HttpGet]
        [Route("/Filing/Operate/EditFilingDocumentDetail")]
        public IActionResult EditFilingDocumentDetail()
        {
            return Json("EditFilingDocumentDetail");
        }



        [HttpGet]
        [Route("/Filing/Operate/EditFilingDocumentRegisterDate")]
        public IActionResult EditFilingDocumentRegisterDate()
        {
            return Json("EditFilingDocumentRegisterDate");
        }


        [HttpGet]
        [Route("/Filing/Operate/EditFilingMemorandum")]
        public IActionResult EditFilingMemorandum()
        {
            return Json("EditFilingMemorandum");
        }


        [HttpGet]
        [Route("/Filing/Operate/EditFilingRegisterNumber")]
        public IActionResult EditFilingRegisterNumber()
        {
            return Json("EditFilingRegisterNumber");
        }


        [HttpGet]
        [Route("/Filing/Operate/EditFilingRoute")]
        public IActionResult EditFilingRoute()
        {
            return Json("EditFilingRoute");
        }


        [HttpGet]
        [Route("/Filing/Operate/FilingDocumentCoordination")]
        public IActionResult FilingDocumentCoordination()
        {
            return Json("FilingDocumentCoordination");
        }


        [HttpGet]
        [Route("/Filing/Operate/FilingFaceSheetStream")]
        public IActionResult FilingFaceSheetStream()
        {
            return Json("FilingFaceSheetStream.ashx.cs");
        }


        [HttpGet]
        [Route("/Filing/Operate/FilingHomePage")]
        public IActionResult FilingHomePage()
        {
            return Json("FilingHomePage");
        }

        [HttpGet]
        [Route("/Filing/Operate/FilingMemorandumStream")]
        public IActionResult FilingMemorandumStream()
        {
            return Json("FilingMemorandumStream.ashx");
        }


        [HttpGet]
        [Route("/Filing/Operate/FilingReceiverSelection")]
        public IActionResult FilingReceiverSelection()
        {
            return Json("FilingReceiverSelection");
        }


        [HttpGet]
        [Route("/Filing/Operate/GetFilingQRCode")]
        public IActionResult GetFilingQRCode()
        {
            return Json("GetFilingQRCode.ashx");
        }


        [HttpGet]
        [Route("/Filing/Operate/PrintFilingCoverNote")]
        public IActionResult PrintFilingCoverNote()
        {
            return Json("PrintFilingCoverNote");
        }


        [HttpGet]
        [Route("/Filing/Operate/ViewFilingRegisterNumber")]
        public IActionResult ViewFilingRegisterNumber()
        {
            return Json("ViewFilingRegisterNumber");
        }


        [HttpGet]
        [Route("/Filing/Operate/ViewReservedFilingRegisterNumber")]
        public IActionResult ViewReservedFilingRegisterNumber()
        {
            return Json("ViewReservedFilingRegisterNumber");
        }




        #endregion

        #region Filing Report

        [HttpGet]
        [Route("/Filing/Report/FilingFormReportViewer")]
        public IActionResult FilingFormReportViewer()
        {
            return Json("FilingFormReportViewer");
        }



        [HttpGet]
        [Route("/Filing/Report/FilingReportStream")]
        public IActionResult FilingReportStream()
        {
            return Json("FilingReportStream.ashx");
        }


        [HttpGet]
        [Route("/Filing/Report/PersonalAccessLogReport")]
        public IActionResult PersonalAccessLogReport()
        {
            return Json("PersonalAccessLogReport");
        }



        [HttpGet]
        [Route("/Filing/Report/PrintFilingMemorandum")]
        public IActionResult PrintFilingMemorandum()
        {
            return Json("PrintFilingMemorandum");
        }

        #endregion


        #region Filing Setup

        [HttpGet]
        [Route("/Filing/Setup/DepartmentInternalFilingNumberSetup")]
        public IActionResult DepartmentInternalFilingNumberSetup()
        {
            return Json("DepartmentInternalFilingNumberSetup");
        }


        [HttpGet]
        [Route("/Filing/Setup/FilingGeneralOrderSetup")]
        public IActionResult FilingGeneralOrderSetup()
        {
            return Json("FilingGeneralOrderSetup");
        }



        [HttpGet]
        [Route("/Filing/Setup/FilingHRDepartmentPermissionSetup")]
        public IActionResult FilingHRDepartmentPermissionSetup()
        {
            return Json("FilingHRDepartmentPermissionSetup");
        }



        [HttpGet]
        [Route("/Filing/Setup/FilingOpinionSetup")]
        public IActionResult FilingOpinionSetup()
        {
            return Json("FilingOpinionSetup");
        }


        [HttpGet]
        [Route("/Filing/Setup/FilingPostscriptSetup")]
        public IActionResult FilingPostscriptSetup()
        {
            return Json("FilingPostscriptSetup");
        }


        [HttpGet]
        [Route("/Filing/Setup/FilingProjectSetup")]
        public IActionResult FilingProjectSetup()
        {
            return Json("FilingProjectSetup");
        }


        [HttpGet]
        [Route("/Filing/Setup/FilingRegisterBookSetup")]
        public IActionResult FilingRegisterBookSetup()
        {
            return Json("FilingRegisterBookSetup");
        }


        [HttpGet]
        [Route("/Filing/Setup/FilingSendFormSetup")]
        public IActionResult FilingSendFormSetup()
        {
            return Json("FilingSendFormSetup");
        }



        [HttpGet]
        [Route("/Filing/Setup/HRDepartmentStaffPermissionForFilingSetup")]
        public IActionResult HRDepartmentStaffPermissionForFilingSetup()
        {
            return Json("HRDepartmentStaffPermissionForFilingSetup");
        }



        #endregion
        


       

        #region Plan
        [HttpGet]
        [Route("/Plan/MainPlanPage")]
        public IActionResult MainPlanPage()
        {
            return Json("MainPlanPage");
        }


       

        [HttpGet]
        [Route("/Plan/MainPlanPage_New")]
        public IActionResult MainPlanPage_New()
        {
            return Json("MainPlanPage_New");
        }


     
        #endregion
        #region Plan Operate
        [HttpGet]
        [Route("/Plan/Operate/DownloadFile")]
        public IActionResult Operate_DownloadFile()
        {
            return Json("DownloadFile");
        }


        [HttpPost]
        [Route("/Plan/Operate/EditBudgetTransferForm")]
        public IActionResult EditBudgetTransferForm(BudgetTransferFormDto request)
        {
            var data = _SecServices.BudgetTransferForm(request);
            return Json(data);
        }



        [HttpPost]
        [Route("/Plan/Operate/EditChangedPlanItemRecord")]
        public IActionResult EditChangedPlanItemRecord(RequestFormPlanViewRequest request)
        {
            var data = _SecServices.EditChangedPlanItemRecord(request);
            return Json(data);
        }



        [HttpPost]
        [Route("/Plan/Operate/EditDirectExpenseMemoForm")]
        public IActionResult EditDirectExpenseMemoForm(DirectExpenseMemoFormRequest request)
        {
            var data = _SecServices.EditDirectExpenseMemoForm(request);

            return Json(data);
        }



        [HttpPost]
        [Route("/Plan/Operate/EditGeneralExpenseExtendForm")]
        public IActionResult EditGeneralExpenseExtendForm(GeneralExpenseExtendFormRequest request)
        {
            var data = _SecServices.EditGeneralExpenseExtendForm(request);
            return Json(data);
        }



        [HttpGet]
        [Route("/Plan/Operate/EditGeneralExpenseForOutsideDutyOrDevForm")]
        public IActionResult EditGeneralExpenseForOutsideDutyOrDevForm()
        {
            return Json("EditGeneralExpenseForOutsideDutyOrDevForm");
        }


        //---อยู่ common-----
        //[HttpGet]
        //[Route("/Plan/Operate/EditGeneralExpenseMemoForm")]
        //public IActionResult EditGeneralExpenseMemoForm()
        //{
        //    return Json("EditGeneralExpenseMemoForm");
        //}



        [HttpPost]
        [Route("/Plan/Operate/EditGeneralExpensePersonalBorrowForm")]
        public IActionResult EditGeneralExpensePersonalBorrowForm(List<GeneralExpensePersonalBorrowItemRequest> request)
        {
            var data = _SecServices.EditGeneralExpensePersonalBorrowForm(request);
            return Json(data);
        }



        //[HttpGet]
        //[Route("/Plan/Operate/EditGeneralExpenseSettleAsBudgetForm")]
        //public IActionResult EditGeneralExpenseSettleAsBudgetForm()
        //{
        //    return Json("EditGeneralExpenseSettleAsBudgetForm");
        //}



        [HttpGet]
        [Route("/Plan/Operate/EditGeneralExpenseSettleForm")]
        public IActionResult EditGeneralExpenseSettleForm(GeneralExpenseSettleFormRequest request)
        {
            var data = _SecServices.EditGeneralExpenseSettleForm(request);
            return Json(data);
        }



        [HttpPost]
        [Route("/Plan/Operate/EditMonthlyForecastAdjustment")]
        public IActionResult EditMonthlyForecastAdjustment(MonthlyForecastAdjustment request)
        {
            var data = _SecServices.EditMonthlyForecastAdjustment_t(request);
            return Json(data);
        }



        [HttpPost]
        [Route("/Plan/Operate/EditOutsideDutyReportForm")]
        public IActionResult EditOutsideDutyReportForm(List<OutsideDutyReportStaff> request)
        {
            var data = _SecServices.EditOutsideDutyReportForm(request);
            return Json(data);
        }

        [HttpPost]
        [Route("/Plan/Operate/EditOutsideDutyGroup")]
        public IActionResult EditOutsideDutyGroup(List<OutsideDutyGroupRequest> request)
        {
            var data = EditOutsideDutyGroup(request);
            return Json(data);
        }
        [HttpGet]
        [Route("/Plan/Operate/GetOutsideDutyGroup/{GeneralExpenseMemoFormsId}")]
        public IActionResult GetditOutsideDutyGroup(int GeneralExpenseMemoFormsId)
        {
            var data = _SecServices.GetditOutsideDutyGroup(GeneralExpenseMemoFormsId);
            return Json(data);
        }
        

        [HttpPost]
        [Route("/Plan/Operate/EditPerformanceIndicatorResult")]
        public IActionResult EditPerformanceIndicatorResult(PerformanceIndicator request)
        {
            var data = _SecServices.EditPerformanceIndicatorResult(request);
            return Json(data);
        }



        [HttpGet]
        [Route("/Plan/Operate/EditPlan/{PlanCoreId}")]
        public IActionResult EditPlan(int PlanCoreId)
        {
            var data = _SecServices.GetEditPlan(PlanCoreId);
            return Json(data);
        }
        [HttpGet]
        [Route("/Plan/Operate/EditPlan/GetAllPlanCore/{year}")]
        public IActionResult GetAllPlanCore(int year)
        {
            var data = _SecServices.GetAllPlanCore(year);
            return Json(data);
        }
        [HttpGet]
        [Route("/Plan/Operate/EditPlan/getAllPlanCorebyStaffId/{year}/{staffId}")]
        public IActionResult GetAllPlanCorebyStaffId(int year, int staffId)
        {
            var data = _SecServices.GetAllPlanCorebyStaffId(year, staffId);
            return Json(data);
        }
        [HttpGet]
        [Route("/Plan/Operate/EditPlan/GetAllStaff")]
        public IActionResult GetAllStaff()
        {
            var data = _SecServices.GetAllStaff();
            return Json(data);
        }
        [HttpPost]
        [Route("/Plan/Operate/EditPlan/PlanCoreSetUp")]
        public IActionResult PlanCoreSetUp(PlanCoreRequest request)
        {
            var data = _SecServices.PlanCoreSetUp(request);
            return Json(data);
        }
        [HttpPost]
        [Route("/Plan/Operate/EditPlan/ResponsiblePersonSetUp")]
        public IActionResult ResponsiblePersonSetUp(ResponsiblePersonRequest request)
        {
            var data = _SecServices.ResponsiblePersonSetUp(request);
            return Json(data);
        }
        [HttpPost]
        [Route("/Plan/Operate/EditPlan/PerformanceIndicatorSetUp")]
        public IActionResult PerformanceIndicatorSetUp(PerformanceIndicatorRequest request)
        {
            var data = _SecServices.PerformanceIndicatorSetUp(request);
            return Json(data);
        }
        [HttpGet]
        [Route("/Plan/Operate/EditPlan/PrinciplePlanTags")]
        public IActionResult EditPlanPrinciplePlanTags()
        {
            var data = _SecServices.EditPlanPrinciplePlanTags();
            return Json(data);
        }
        [HttpGet]
        [Route("/Plan/Operate/EditPlan/StrategicIndicatorServ/{fiscalYear}")]
        public IActionResult EditStrategicIndicatorServ(int fiscalYear)
        {
            var data = _SecServices.EditPlanStrategicIndicatorServ(fiscalYear);
            return Json(data);
        }

        [HttpGet]
        [Route("/Plan/Operate/EditPlan/PlanTypeTree/{fiscalYear}")]
        public IActionResult EditPlanTypeTree(int fiscalYear)
        {
            var data = _SecServices.EditPlanStrategicIndicatorServ(fiscalYear);
            return Json(data);
        }


        [HttpGet]
        [Route("/Plan/Operate/EditPlan/EditPerformanceIndicator/{fiscalYear}")]
        public IActionResult EditPlanEditPerformanceIndicator(int fiscalYear)
        {
            var data = _SecServices.EditPerformanceIndicator(fiscalYear);
            return Json(data);
        }
        [HttpGet]
        [Route("/Plan/Operate/EditPlan/GetDepartments/{fiscalYear}")]
        public IActionResult EditPlanEditGetDepartments(int fiscalYear)
        {
            var data = _SecServices.GetDepartments(fiscalYear);
            return Json(data);
        }
        

        [HttpPost]
        [Route("/Plan/Operate/EditPlanActivity")]
        public IActionResult EditPlanActivity(PlanActivityRequest request)
        {
            var data = _SecServices.EditPlanActivity( request);
            return Json(data);
        }



        //[HttpGet]
        //[Route("/Plan/Operate/EditPlanActivityOperationPeriod")]
        //public IActionResult EditPlanActivityOperationPeriod()
        //{
        //    return Json("EditPlanActivityOperationPeriod");
        //}



        //[HttpGet]
        //[Route("/Plan/Operate/EditPlanActivityOperationPeriodOnList")]
        //public IActionResult EditPlanActivityOperationPeriodOnList()
        //{
        //    return Json("EditPlanActivityOperationPeriodOnList");
        //}



        [HttpGet]
        [Route("/Plan/ViewGeneralExpenseMemoFormList" +
"OperationPeriodResult/{PlanActivityId}")]
        public IActionResult EditPlanActivityOperationPeriodResult(int PlanActivityId)
        {
            var data = _SecServices.EditPlanActivityOperationPeriodResult(PlanActivityId);
            return Json(data);
        }


        [HttpPost]
        [Route("/Plan/Operate/EditPlanItem")]
        public IActionResult EditPlanItem(PlanItemRequest request)
        {
            var data = _SecServices.EditPlanItem(request);
            return Json(data);
        }


        [HttpPost]
        [Route("/Plan/Operate/EditPlanMonthlyOperation")]
        public IActionResult EditPlanMonthlyOperation(PlanMonthlyOperation request)
        {
            var data = _SecServices.EditPlanMonthlyOperation(request);
            return Json(data);
        }



        //[HttpGet]
        //[Route("/Plan/Operate/EditPlanOperationPeriod")]
        //public IActionResult EditPlanOperationPeriod()
        //{
        //    return Json("EditPlanOperationPeriod");
        //}



        //[HttpGet]
        //[Route("/Plan/Operate/EditReceivedReservedBudgetByPlanActivity")]
        //public IActionResult EditReceivedReservedBudgetByPlanActivity()
        //{
        //    return Json("EditReceivedReservedBudgetByPlanActivity");
        //}



        [HttpPost]
        [Route("/Plan/Operate/EditSettleReceiptForm")]
        public IActionResult EditSettleReceiptForm(SettleReceiptForm request)
        {
            var data = _SecServices.EditSettleReceiptForm(request);
            return Json(data);
        }



        [HttpPost]
        [Route("/Plan/Operate/SearchPlanActivity")]
        public IActionResult SearchPlanActivity(SearchPlanActivityRequest request)
        {
            var data = _SecServices.SearchPlanActivity(request);
            return Json(data);
        }



        //[HttpGet]
        //[Route("/Plan/Operate/SearchPlanForActivity")]
        //public IActionResult SearchPlanForActivity()
        //{
        //    return Json("SearchPlanForActivity");
        //}


        [HttpPost]
        [Route("/Plan/Operate/SearchPlanItem")]
        public IActionResult SearchPlanItem(SearchPlanItemRequest request)
        {
            var data = _SecServices.SearchPlanItem(request);
            return Json(data);
        }


        //[HttpGet]
        //[Route("/Plan/Operate/SelectGeneralExpenseForPersonalBorrowing")]
        //public IActionResult SelectGeneralExpenseForPersonalBorrowing()
        //{
        //    return Json("SelectGeneralExpenseForPersonalBorrowing");
        //}


        //[HttpGet]
        //[Route("/Plan/Operate/SelectGEPersonalBorrowFormForExtend")]
        //public IActionResult SelectGEPersonalBorrowFormForExtend()
        //{
        //    return Json("SelectGEPersonalBorrowFormForExtend");
        //}



        [HttpPost]
        [Route("/Plan/Operate/SelectSupplierListForForm")]
        public IActionResult SelectSupplierListForForm(SelectSupplierListForFormRequest request) 
        {
            var data = _SecServices.SelectSupplierListForForm(request);
            return Json(data);
        }



        [HttpGet]
        [Route("/Plan/Operate/SelectViewPlanForActivityByDepartment/GetByFiscalYear/{year}")]
        public IActionResult SelectViewPlanForActivityByDepartment(int year)
        {
            var data = _SecServices.DepartmentGetByFiscalYear(year);
            return Json(data);
        }

        [HttpGet]
        [Route("/Plan/Operate/ShowStrategy/GetByFiscalYear/{year}")]
        public IActionResult TryGetStrategy(int year)
        {
            var data = _SecServices.TryGetStrategy(year);
            return Json(data);
        }

        [HttpGet]
        [Route("/Plan/Operate/SelectDepartment/GetByFiscalYearandDepartmentid/{year}/{id}")]
        public IActionResult SelectDepartmentGetByFiscalYearandDepartmentid(int year, int id)
        {
            var data = _SecServices.DepartmentGetByFiscalYearandDepartmentid(year, id);
            return Json(data);
        }

        [HttpGet]
        [Route("/Plan/Operate/SelectViewPlanForActivityByPlanType/GetByFiscalYear/{year}")]
        public IActionResult SelectViewPlanForActivityByPlanTypeGetByFiscalYear(int year)
        {
            var data = _SecServices.PlanTypeGetByFiscalYear(year);
            return Json(data);
        }

        [HttpGet]
        [Route("/Plan/Operate/SelectViewPlanForActivityByPlanType/GetByFiscalYearandPlanTypeid/{year}/{id}")]
        public IActionResult SelectViewPlanForActivityByPlanTypeGetByFiscalYearandPlanTypeid(int year, int id)
        {
            var data = _SecServices.PlanTypeGetByFiscalYearandPlanTypeid(year, id);
            return Json(data);
        }


        [HttpPost]
        [Route("/Plan/Operate/ViewChangedPlanItemRecordList")]
        public IActionResult ViewChangedPlanItemRecordList(ViewChangedPlanItemRecordListRequest request)
        {
            var data = _SecServices.ViewChangedPlanItemRecordList(request);
            return Json(data);
        }



        [HttpPost]
        [Route("/Plan/Operate/ViewDirectExpenseMemoFormList")]
        public IActionResult ViewDirectExpenseMemoFormList(ViewDirectExpenseMemoFormListRequest request)
        {
            var data = _SecServices.ViewDirectExpenseMemoFormList(request);
            return Json(data);
        }



        [HttpGet]
        [Route("/Plan/Operate/ViewGeneralExpenseDebtList")]
        public IActionResult ViewGeneralExpenseDebtList()
        {
            return Json("ViewGeneralExpenseDebtList");
        }



        [HttpGet]
        [Route("/Plan/Operate/ViewGeneralExpenseExtendFormList")]
        public IActionResult ViewGeneralExpenseExtendFormList()
        {
            return Json("ViewGeneralExpenseExtendFormList");
        }



        //[HttpGet]
        //[Route("/Plan/Operate/ViewGeneralExpenseMemoFormForSettle")]
        //public IActionResult ViewGeneralExpenseMemoFormForSettle()
        //{
        //    return Json("ViewGeneralExpenseMemoFormForSettle");
        //}



        [HttpPost]
        [Route("/Plan/Operate/ViewGeneralExpenseMemoFormList")]
        public IActionResult ViewGeneralExpenseMemoFormList(ViewGeneralExpenseMemoFormListRequest request)
        {
            var data = _SecServices.ViewGeneralExpenseMemoFormList(request);
            return Json(data);
        }



        [HttpPost]
        [Route("/Plan/Operate/ViewGeneralExpenseMemoFormListForApproval")]
        public IActionResult ViewGeneralExpenseMemoFormListForApproval(ViewGeneralExpenseMemoFormLisRequest request)
        {
            var data = _SecServices.ViewGeneralExpenseMemoFormListForApproval(request);
            return Json(data);
        }



        [HttpPost]
        [Route("/Plan/Operate/ViewGeneralExpenseMemoFormListForExtend")]
        public IActionResult ViewGeneralExpenseMemoFormListForExtend(ViewGeneralExpenseMemoFormListForExtendRequest request)
        {
            var data = _SecServices.ViewGeneralExpenseMemoFormListForExtend(request);
            return Json("ViewGeneralExpenseMemoFormListForExtend");
        }



        [HttpGet]
        [Route("/Plan/Operate/ViewGeneralExpenseMemoFormListForOutsideDutyReport")]
        public IActionResult ViewGeneralExpenseMemoFormListForOutsideDutyReport()
        {
            return Json("ViewGeneralExpenseMemoFormListForOutsideDutyReport");
        }



        [HttpGet]
        [Route("/Plan/Operate/ViewGeneralExpenseMemoFormListForPersonalBorrowing")]
        public IActionResult ViewGeneralExpenseMemoFormListForPersonalBorrowing()
        {
            return Json("ViewGeneralExpenseMemoFormListForPersonalBorrowing");
        }



        [HttpGet]
        [Route("/Plan/Operate/ViewGeneralExpensePersonalBorrowFormList")]
        public IActionResult ViewGeneralExpensePersonalBorrowFormList()
        {
            return Json("ViewGeneralExpensePersonalBorrowFormList");
        }



        [HttpPost]
        [Route("/Plan/Operate/ViewGeneralExpenseSettleAsBudgetFormList")]
        public IActionResult ViewGeneralExpenseSettleAsBudgetFormList(ViewGeneralExpenseSettleAsBudgetFormListRequest request)
        {
            var data = _SecServices.ViewGeneralExpenseSettleAsBudgetFormList(request);
            return Json(data);
        }



        [HttpPost]
        [Route("/Plan/Operate/ViewGeneralExpenseSettleFormList")]
        public IActionResult ViewGeneralExpenseSettleFormList(ViewGeneralExpenseSettleFormListRequest request)
        {
            var data = _SecServices.viewGeneralExpenseSettleFormList(request);
            return Json(data);
        }



        [HttpPost]
        [Route("/Plan/Operate/ViewGeneralExpenseSettleFormListForApproval")]
        public IActionResult ViewGeneralExpenseSettleFormListForApproval(ViewGeneralExpenseSettleFormListRequest request)
        {
            var data = _SecServices.ViewGeneralExpenseSettleFormListForApproval(request);
            return Json(data);
        }


        [HttpPost]
        [Route("/Plan/Operate/ViewMonthlyForecastAdjustmentList")]
        public IActionResult ViewMonthlyForecastAdjustmentList(ViewMonthlyForecastAdjustmentListRequest request)
        {
            var data = _SecServices.ViewMonthlyForecastAdjustmentList(request);
            return Json(data);
        }



        [HttpPost]
        [Route("/Plan/Operate/ViewOutsideDutyReportFormList")]
        public IActionResult ViewOutsideDutyReportFormList(ViewOutsideDutyReportFormListRequest request)
        {
            var data = ViewOutsideDutyReportFormList(request);
            return Json(data);
        }



        [HttpGet]
        [Route("/Plan/Operate/ViewPerformanceIndicatorByPlanActivityList/{PlanCoreId}")]
        public IActionResult ViewPerformanceIndicatorByPlanActivityList(int PlanCoreId)
        {
            var data = _SecServices.ViewPerformanceIndicatorByPlanActivityList(PlanCoreId);
            return Json(data);
        }



        [HttpGet]
        [Route("/Plan/Operate/ViewPlanActivityList/{PlanActivityId}")]
        public IActionResult ViewPlanActivityList(int PlanActivityId)
        {
            var data = _SecServices.SearchPlanItemById(PlanActivityId);
            return Json(data);
        }

        [HttpGet]
        [Route("/Plan/Operate/ViewPlanItemNamebyPlanActivity/{PlanActivityId}")]
        public IActionResult SearchPlanItemNameByPlanActivityId(int PlanActivityId)
        {
            var data = _SecServices.SearchPlanItemNameByPlanActivityId(PlanActivityId);
            return Json(data);
        }

        [HttpGet]
        [Route("/Plan/Operate/ViewPlanActivityOperationPeriodByPlanCore/{PlanCoreId}")]
        public IActionResult ViewPlanActivityOperationPeriodByPlanCore(int PlanCoreId)
        {
            var data = _SecServices.ViewPlanActivityOperationPeriodByPlanCore(PlanCoreId);
            return Json(data);
        }



        [HttpGet]
        [Route("/Plan/Operate/ViewPlanActivitySelectionForMemoForm")]
        public IActionResult ViewPlanActivitySelectionForMemoForm()
        {
            return Json("ViewPlanActivitySelectionForMemoForm");
        }


        [HttpGet]
        [Route("/Plan/Operate/ViewPlanForActivityByDepartment/GetById/{DepartmentID}/{FiscalYear}")]
        public IActionResult ViewPlanForActivityByDepartment(int DepartmentID, int FiscalYear)
        {
            var data = _SecServices.GetById(DepartmentID, FiscalYear);
            return Json(data);
        }


        [HttpGet]
        [Route("/Plan/Operate/ViewPlanForActivityByPlanType")]
        public IActionResult ViewPlanForActivityByPlanType()
        {
            return Json("ViewPlanForActivityByPlanType");
        }



        [HttpGet]
        [Route("/Plan/Operate/ViewPlanForActivityByPlanTypeBudgetType/{planTypeId}/{fiscalYear}/{depId}")]
        public IActionResult ViewPlanForActivityByPlanTypeBudgetType(int planTypeId, int fiscalYear, int depId = 0)
        {
            var data = _SecServices.ViewPlanForActivityByPlanTypeBudgetTypeCreateTableData(planTypeId, fiscalYear, depId);
            return Json(data);
        }



        [HttpPost]
        [Route("/Plan/Operate/ViewPlanItemBudgetTransferList")]
        public IActionResult ViewPlanItemBudgetTransferList(ViewPlanItemBudgetTransferListRespons request)
        {
            var data = _SecServices.ViewPlanItemBudgetTransferList( request);
            return Json(data);
        }



        [HttpPost]
        [Route("/Plan/Operate/ViewPlanItemBudgetTransferListForApprove")]
        public IActionResult ViewPlanItemBudgetTransferListForApprove(BudgetTransferFormRequest request)
        {
            var data = _SecServices.ViewPlanItemBudgetTransferListForApprove(request);
            return Json(data);
        }



        [HttpGet]
        [Route("/Plan/Operate/ViewPlanItemSelectionForMemoForm")]
        public IActionResult ViewPlanItemSelectionForMemoForm()
        {
            return Json("ViewPlanItemSelectionForMemoForm");
        }



        [HttpGet]
        [Route("/Plan/Operate/ViewReceivedReservedBudgetByPlanActivity/{PlanActivityId}")]
        public IActionResult ViewReceivedReservedBudgetByPlanActivity(int PlanActivityId)
        {
            var data = _SecServices.ViewReceivedReservedBudgetByPlanActivity(PlanActivityId);
            return Json(data);
        }


        [HttpGet]
        [Route("/Plan/Operate/ViewReceivedReservedBudgetByPlanCore/{planTypeId}/{fiscalYear}/{depId}")]
        public IActionResult ViewReceivedReservedBudgetByPlanCore(int planTypeId, int fiscalYear, int depId = 0)
        {
            var data = _SecServices.ReceivedReservedBudgetByPlanCreateTableData(planTypeId, fiscalYear, depId);
            return Json(data);
        }



        [HttpGet]
        [Route("/Plan/Operate/ViewRequestFormPlanViewList")]
        public IActionResult ViewRequestFormPlanViewList()
        {
            return Json("ViewRequestFormPlanViewList");
        }



        [HttpGet]
        [Route("/Plan/Operate/ViewSettleReceiptFormList")]
        public IActionResult ViewSettleReceiptFormList()
        {
            return Json("ViewSettleReceiptFormList");
        }



        [HttpPost]
        [Route("/Plan/Operate/ViewSettleReceiptFormListForApproval")]
        public IActionResult ViewSettleReceiptFormListForApproval(ViewSettleReceiptFormListRequest request)
        {
            var data = _SecServices.ViewSettleReceiptFormListForApproval(request);
            return Json(data);
        }



        [HttpGet]
        [Route("/Plan/Operate/ViewWithdrawalFormForSettle")]
        public IActionResult ViewWithdrawalFormForSettle()
        {
            return Json("ViewWithdrawalFormForSettle");
        }

        [HttpGet]
        [Route("/Plan/Operate/SearchPlanForActivity/FundTypeList/GetByFiscalYear/{year}")]
        public IActionResult SearchPlanForActivityFundTypeSetupByFiscalYear(int year)
        {
            var data = _SecServices.SearchPlanForActivityFundTypeSetupByFiscalYear(year);
            return Json(data);
        }

        [HttpGet]
        [Route("/Plan/Operate/SearchPlanForActivity/DepartmentList/GetByFiscalYear/{year}")]
        public IActionResult SearchPlanForActivityDepartmentListGetByFiscalYear(int year)
        {
            var data = _SecServices.SearchPlanForActivityDepartmentListGetByFiscalYear(year);
            return Json(data);
        }
        [HttpGet]
        [Route("/Plan/Operate/PlanTypeGetAll/GetByFiscalYear/{year}")]
        public IActionResult PlanTypeGetAll(int year)
        {
            var data = _SecServices.PlanTypeGetAll(year);
            return Json(data);
        }
        [HttpGet]
        [Route("/Plan/Operate/SearchPlanForActivity/PlanList/GetByFiscalYear/{year}")]
        public IActionResult SearchPlanForActivityPlanTypeGetByFiscalYear(int year)
        {
            var data = _SecServices.SearchPlanForActivityPlanTypeGetByFiscalYear(year);
            return Json(data);
        }

        [HttpGet]
        [Route("/Plan/Operate/SearchPlanActivity/FundTypeList/GetByFiscalYear/{year}")]
        public IActionResult SearchPlanActivityFundTypeSetupByFiscalYear(int year)
        {
            var data = _SecServices.SearchPlanActivityFundTypeSetupByFiscalYear(year);
            return Json(data);
        }

        [HttpGet]
        [Route("/Plan/Operate/SearchPlanActivity/DepartmentList/GetByFiscalYear/{year}")]
        public IActionResult SearchPlanActivityDepartmentListGetByFiscalYear(int year)
        {
            var data = _SecServices.SearchPlanActivityDepartmentListGetByFiscalYear(year);
            return Json(data);
        }

        [HttpGet]
        [Route("/Plan/Operate/SearchPlanActivity/PlanList/GetByFiscalYear/{year}")]
        public IActionResult SearchPlanActivityPlanTypeGetByFiscalYear(int year)
        {
            var data = _SecServices.SearchPlanActivityPlanTypeGetByFiscalYear(year);
            return Json(data);
        }

        [HttpGet]
        [Route("/Plan/Operate/SearchPlanItem/FundTypeList/GetByFiscalYear/{year}")]
        public IActionResult SearchPlanItemFundTypeSetupByFiscalYear(int year)
        {
            var data = _SecServices.SearchPlanItemFundTypeSetupByFiscalYear(year);
            return Json(data);
        }

        [HttpGet]
        [Route("/Plan/Operate/SearchPlanItem/DepartmentList/GetByFiscalYear/{year}")]
        public IActionResult SearchPlanItemDepartmentListGetByFiscalYear(int year)
        {
            var data = _SecServices.SearchPlanItemDepartmentListGetByFiscalYear(year);
            return Json(data);
        }

        [HttpGet]
        [Route("/Plan/Operate/SearchPlanItem/PlanList/GetByFiscalYear/{year}")]
        public IActionResult SearchPlanItemPlanTypeGetByFiscalYear(int year)
        {
            var data = _SecServices.SearchPlanItemPlanTypeGetByFiscalYear(year);
            return Json(data);
        }
        #endregion


        #region Plan Report

        [HttpGet]
        [Route("/Plan/Report/BudgetOverviewDrillThroughReport")]
        public IActionResult BudgetOverviewDrillThroughReport()
        {
            return Json("BudgetOverviewDrillThroughReport");
        }




        [HttpGet]
        [Route("/Plan/Report/BudgetTransferByMonthReport")]
        public IActionResult BudgetTransferByMonthReport()
        {
            return Json("BudgetTransferByMonthReport");
        }


        
        [HttpGet]
        [Route("/Plan/Report/FinancialDetailGroupReport")]
        public IActionResult FinancialDetailGroupReport()
        {
            return Json("FinancialDetailGroupReport");
        }



        [HttpGet]
        [Route("/Plan/Report/FinancialPlanCoreReportByMonth")]
        public IActionResult FinancialPlanCoreReportByMonth()
        {
            return Json("FinancialPlanCoreReportByMonth");
        }



        [HttpGet]
        [Route("/Plan/Report/FinancialPlanCoreReportByType")]
        public IActionResult FinancialPlanCoreReportByType()
        {
            return Json("FinancialPlanCoreReportByType");
        }



        [HttpGet]
        [Route("/Plan/Report/FinancialStatementMonthlyBriefReportByBudgetType")]
        public IActionResult FinancialStatementMonthlyBriefReportByBudgetType()
        {
            return Json("FinancialStatementMonthlyBriefReportByBudgetType");
        }



        [HttpGet]
        [Route("/Plan/Report/FinancialStatementMonthlyReportByBudgetType")]
        public IActionResult FinancialStatementMonthlyReportByBudgetType()
        {
            return Json("FinancialStatementMonthlyReportByBudgetType");
        }



        [HttpGet]
        [Route("/Plan/Report/FinancialStatementMonthlyReportByPlanCore")]
        public IActionResult FinancialStatementMonthlyReportByPlanCore()
        {
            return Json("FinancialStatementMonthlyReportByPlanCore");
        }



        [HttpGet]
        [Route("/Plan/Report/FinancialStatementMonthlyReportByPlanCore_Backup")]
        public IActionResult FinancialStatementMonthlyReportByPlanCore_Backup()
        {
            return Json("FinancialStatementMonthlyReportByPlanCore_Backup");
        }



        [HttpGet]
        [Route("/Plan/Report/FinancialStatementMonthlyReportByPlanType")]
        public IActionResult FinancialStatementMonthlyReportByPlanType()
        {
            return Json("FinancialStatementMonthlyReportByPlanType");
        }



        [HttpGet]
        [Route("/Plan/Report/FinancialStatementMonthlyReportByPlanType_Backup")]
        public IActionResult FinancialStatementMonthlyReportByPlanType_Backup()
        {
            return Json("FinancialStatementMonthlyReportByPlanType_Backup");
        }



        [HttpGet]
        [Route("/Plan/Report/FinancialStatementPeriodReportByPlanCore")]
        public IActionResult FinancialStatementPeriodReportByPlanCore()
        {
            return Json("FinancialStatementPeriodReportByPlanCore");
        }



        [HttpGet]
        [Route("/Plan/Report/FinancialStatementPeriodReportByPlanType")]
        public IActionResult FinancialStatementPeriodReportByPlanType()
        {
            return Json("FinancialStatementPeriodReportByPlanType");
        }



        [HttpGet]
        [Route("/Plan/Report/FinancialSummarizeReportByPlanType")]
        public IActionResult FinancialSummarizeReportByPlanType()
        {
            return Json("FinancialSummarizeReportByPlanType");
        }


  

        [HttpGet]
        [Route("/Plan/Report/GEFromTrackingRoute")]
        public IActionResult GEFromTrackingRoute()
        {
            return Json("GEFromTrackingRoute");
        }



        [HttpGet]
        [Route("/Plan/Report/GeneralExpenseDocTrackingRoute")]
        public IActionResult GeneralExpenseDocTrackingRoute()
        {
            return Json("GeneralExpenseDocTrackingRoute");
        }



        [HttpGet]
        [Route("/Plan/Report/LateGeneralExpenseBorrowFormReport")]
        public IActionResult LateGeneralExpenseBorrowFormReport()
        {
            return Json("LateGeneralExpenseBorrowFormReport");
        }



        [HttpGet]
        [Route("/Plan/Report/PlanActivityByRequestViewUsedPlanItemReport")]
        public IActionResult PlanActivityByRequestViewUsedPlanItemReport()
        {
            return Json("PlanActivityByRequestViewUsedPlanItemReport");
        }



        [HttpPost]
        [Route("/Plan/Report/PlanCoreApproveStatusReport")]
        public IActionResult PlanCoreApproveStatusReport(PlanCoreApproveStatusReportRequest request)
        {
            _Logger.LogInformation("sql");
            var data = _SecServices.PlanCoreApproveStatusReport(request);
            return Json(data);
        }



        [HttpGet]
        [Route("/Plan/Report/PlanCoreDetailReport")]
        public IActionResult PlanCoreDetailReport()
        {
            return Json("PlanCoreDetailReport");
        }



        [HttpGet]
        [Route("/Plan/Report/PlanCoreGroupByPlanTypeMonthlyReport")]
        public IActionResult PlanCoreGroupByPlanTypeMonthlyReport()
        {
            return Json("PlanCoreGroupByPlanTypeMonthlyReport");
        }



        [HttpGet]
        [Route("/Plan/Report/PlanCoreMonthlyReport")]
        public IActionResult PlanCoreMonthlyReport()
        {
            return Json("PlanCoreMonthlyReport");
        }



        [HttpGet]
        [Route("/Plan/Report/PlanFileStream")]
        public IActionResult PlanFileStream()
        {
            return Json("PlanFileStream");
        }



        [HttpGet]
        [Route("/Plan/Report/PlanFormReportViewer")]
        public IActionResult PlanFormReportViewer()
        {
            return Json("PlanFormReportViewer");
        }



        [HttpGet]
        [Route("/Plan/Report/PlanIncompletedResultMonthlyReport")]
        public IActionResult PlanIncompletedResultMonthlyReport()
        {
            return Json("PlanIncompletedResultMonthlyReport");
        }



        [HttpGet]
        [Route("/Plan/Report/PlanItemByBudgetTypeAndPlanTypeReport/{fiscalYear}/{month}/{planTypeId}/{budgetTypeId}")]
        public IActionResult PlanItemByBudgetTypeAndPlanTypeReport(int fiscalYear, int month, int planTypeId, int budgetTypeId)
        {
            var data = _SecServices.PlanItemByBudgetTypeAndPlanTypeReport(fiscalYear, month, planTypeId, budgetTypeId);
            return Json(data);
        }



        [HttpGet]
        [Route("/Plan/Report/PlanItemOperationReport")]
        public IActionResult PlanItemOperationReport()
        {
            return Json("PlanItemOperationReport");
        }


       

        [HttpGet]
        [Route("/Plan/Report/PlanItemProcureOperationReport")]
        public IActionResult PlanItemProcureOperationReport()
        {
            return Json("PlanItemProcureOperationReport");
        }


     

        [HttpGet]
        [Route("/Plan/Report/PlanItemReportByBudgetType")]
        public IActionResult PlanItemReportByBudgetType()
        {
            return Json("PlanItemReportByBudgetType");
        }


       


        [HttpGet]
        [Route("/Plan/Report/PlanReportByBudgetType/{fiscalYear}")]
        public IActionResult PlanReportByBudgetType(int fiscalYear)
        {
            var data = _SecServices.PlanReportByBudgetType(fiscalYear);
            return Json(data);
        }


       

        [HttpGet]
        [Route("/Plan/Report/PlanReportByDepartment/{fiscalYear}")]
        public IActionResult PlanReportByDepartment(int fiscalYear)
        {
            var data = _SecServices.PlanReportByDepartment(fiscalYear);
            return Json(data);
        }



        [HttpGet]
        [Route("/Plan/Report/PlanReportByFundType")]
        public IActionResult PlanReportByFundType()
        {
            return Json("PlanReportByFundType");
        }



        [HttpGet]
        [Route("/Plan/Report/PlanReportByPlanType/{fiscalYear}")]
        public IActionResult PlanReportByPlanType(int fiscalYear)
        {
            var data = _SecServices.PlanReportByPlanType(fiscalYear);
            return Json(data);
        }



        [HttpGet]
        [Route("/Plan/Report/PlanReportByStrategy")]
        public IActionResult PlanReportByStrategy()
        {
            return Json("PlanReportByStrategy");
        }


       

        [HttpGet]
        [Route("/Plan/Report/PlanReportStream")]
        public IActionResult PlanReportStream()
        {
            return Json("PlanReportStream");
        }


        [HttpGet]
        [Route("/Plan/Report/PlanTypeAndFundTypeReport")]
        public IActionResult PlanTypeAndFundTypeReport()
        {
            return Json("PlanTypeAndFundTypeReport");
        }


        [HttpGet]
        [Route("/Plan/Report/SearchGeneralExpenseDocForTrackingRoute")]
        public IActionResult SearchGeneralExpenseDocForTrackingRoute()
        {
            return Json("SearchGeneralExpenseDocForTrackingRoute");
        }


        [HttpGet]
        [Route("/Plan/Report/ShowPlanActivityDetail")]
        public IActionResult ShowPlanActivityDetail()
        {
            return Json("ShowPlanActivityDetail");
        }



        [HttpGet]
        [Route("/Plan/Report/ShowPlanCoreDetail")]
        public IActionResult ShowPlanCoreDetail()
        {
            return Json("ShowPlanCoreDetail");
        }



        [HttpGet]
        [Route("/Plan/Report/ShowPlanCoreListGroupReport")]
        public IActionResult ShowPlanCoreListGroupReport()
        {
            return Json("ShowPlanCoreListGroupReport");
        }



        [HttpGet]
        [Route("/Plan/Report/ShowPlanItemDetail")]
        public IActionResult ShowPlanItemDetail()
        {
            return Json("ShowPlanItemDetail");
        }



        [HttpGet]
        [Route("/Plan/Report/ShowPlanItemDetail_Backup")]
        public IActionResult ShowPlanItemDetail_Backup()
        {
            return Json("ShowPlanItemDetail_Backup");
        }



        [HttpGet]
        [Route("/Plan/Report/ShowPlanItemListGroupReport")]
        public IActionResult ShowPlanItemListGroupReport()
        {
            return Json("ShowPlanItemListGroupReport");
        }



        [HttpGet]
        [Route("/Plan/Report/StrategicIndicatorByPlanActivityReport")]
        public IActionResult StrategicIndicatorByPlanActivityReport()
        {
            return Json("StrategicIndicatorByPlanActivityReport");
        }



        [HttpGet]
        [Route("/Plan/Report/SummarizeReportByBudgetType")]
        public IActionResult SummarizeReportByBudgetType()
        {
            return Json("SummarizeReportByBudgetType");
        }


        [HttpGet]
        [Route("/Plan/Report/SummarizeReportByDepartment")]
        public IActionResult SummarizeReportByDepartment()
        {
            return Json("SummarizeReportByDepartment");
        }




        [HttpGet]
        [Route("/Plan/Report/SummarizeReportByFundType")]
        public IActionResult SummarizeReportByFundType()
        {
            return Json("SummarizeReportByFundType");
        }



        [HttpGet]
        [Route("/Plan/Report/SummarizeReportByPlanCore")]
        public IActionResult SummarizeReportByPlanCore()
        {
            return Json("SummarizeReportByPlanCore");
        }



        [HttpGet]
        [Route("/Plan/Report/SummarizeReportByPlanType")]
        public IActionResult SummarizeReportByPlanType()
        {
            return Json("SummarizeReportByPlanType");
        }


     


        [HttpGet]
        [Route("/Plan/Report/SummarizeReportByStrategy")]
        public IActionResult SummarizeReportByStrategy()
        {
            return Json("SummarizeReportByStrategy");
        }



        [HttpGet]
        [Route("/Plan/Report/ViewPrinciplePlanTagReport")]
        public IActionResult ViewPrinciplePlanTagReport()
        {
            return Json("ViewPrinciplePlanTagReport");
        }


        #endregion

        #region Plan Setup
        [HttpPost]
        [Route("/Plan/Setup/BudgetTypeSetup")]
        public IActionResult BudgetTypeSetup(BudgetTypeRequest request)
        {
            var data = _SecServices.BudgetTypeSetup(request);
            return Json(data);
        }

        [HttpGet]
        [Route("/Plan/Setup/BudgetTypeSetup/GovExpenseType")]
        public IActionResult GovExpenseType()
        {

            var data = _SecServices.GovExpenseType("./json/GovExpenseType.json");
            return Json(data);
        }
        [HttpGet]
        [Route("/Plan/Setup/BudgetTypeSetup/ExpenseType")]
        public IActionResult ExpenseType()
        {

            var data = _SecServices.GovExpenseType("./json/ExpenseType.json");
            return Json(data);
        }

        [HttpGet]
        [Route("/Plan/Setup/BudgetTypeSetup/GetByFiscalYear/{GetByFiscalYear}")]
        public IActionResult BudgetTypeSetupGetByFiscalYear(int GetByFiscalYear)
        {
            var data = _SecServices.GetByFiscalYear(GetByFiscalYear);
            var _BudgetType = new List<BudgetTypeDto>();
            foreach (var item in data)
            {
                _BudgetType.Add(new BudgetTypeDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    Active = item.Active,
                    FiscalYear = item.FiscalYear,
                    ParentBudgetTypeId = item.ParentBudgetTypeId,
                    ReferenceOldId = item.ReferenceOldId,
                    ExpenseTypeEnum = item.ExpenseTypeEnum,
                    GovExpenseTypeEnum = item.GovExpenseTypeEnum,

                });

            }

            return Json(_BudgetType);
        }

        [HttpPost]
        [Route("/Plan/Setup/CostTypeSetup")]
        public IActionResult CostTypeSetup(CostTypeRequest request)
        {
            var data = _SecServices.CostTypeSetup(request);
            return Json(data);
        }



        [HttpPost]
        [Route("/Plan/Setup/DepartmentSetup")]
        public IActionResult DepartmentSetup(DepartmentRequest request)
        {
            var data = _SecServices.DepartmentSetup(request);
            return Json(data);
        }
        [HttpPost]
        [Route("/Plan/Setup/DepartmentBudgetLimitSetup")]
        public IActionResult DepartmentBudgetLimitSetup(DepartmentBudgetLimitRequest request)
        {
            var data = _SecServices.DepartmentBudgetLimitSetup(request);
            return Json(data);
        }
        [HttpGet]
        [Route("/Plan/Setup/DepartmentSetup/GetByFiscalYear/{year}")]
        public IActionResult DepartmentSetupGetByFiscalYear(int year)
        {
            var data = _SecServices.DepartmentListGetByFiscalYear(year);
            return Json(data);
        }
        [HttpGet]
        [Route("/Plan/Setup/DepartmentBudgetLimitSetup/GetByFiscalYear/{year}")]
        public IActionResult DepartmentBudgetLimitGetByFiscalYear(int year)
        {
            var data = _SecServices.DepartmentBudgetLimitGetByFiscalYear(year);
            return Json(data);
        }
        [HttpPost]
        [Route("/Plan/Setup/FundTypeSetup")]
        public IActionResult FundTypeSetup(FundTypeRequest request)
        {
            var data = _SecServices.FundTypeSetup(request);
            return Json(data);
        }
        [HttpPost]
        [Route("/Plan/Setup/MissionSetup")]
        public IActionResult MissionSetup(MissionRequest request)
        {
            var data = _SecServices.MissionSetup(request);
            return Json(data);
        }

        [HttpPost]
        [Route("/Plan/Setup/FundSourceSetup")]
        public IActionResult FundSourceSetup(FundSourceRequest request)
        {
            var data = _SecServices.FundSourceSetup(request);
            return Json(data);
        }
        [HttpGet]
        [Route("/Plan/Setup/FundTypeSetup/GetByFiscalYear/{year}")]
        public IActionResult FundTypeSetupGetByFiscalYear(int year)
        {
            var data = _SecServices.FundTypeSetupByFiscalYear(year);
            return Json(data);
        }
        [HttpGet]
        [Route("/Plan/Setup/FundSourceSetup/GetByFiscalYear/{year}")]
        public IActionResult FundSourceSetupByFiscalYear(int year)
        {
            var data = _SecServices.FundSourceSetupByFiscalYear(year);
            return Json(data);
        }
        [HttpGet]
        [Route("/Plan/Setup/MissionSetup/GetByFiscalYear/{year}")]
        public IActionResult MissionSetupByFiscalYear(int year)
        {
            var data = _SecServices.MissionSetupByFiscalYear(year);
            return Json(data);
        }

        [HttpPost]
        [Route("/Plan/Setup/GovernmentDisbursementGoalSetup")]
        public IActionResult GovernmentDisbursementGoalSetup(GovernmentDisbursementGoal request)
        {
            var data = _SecServices.GovernmentDisbursementGoalSetup(request);
            return Json("GovernmentDisbursementGoalSetup");
        }
        [HttpGet]
        [Route("/Plan/Setup/GovernmentDisbursementGoalSetup/GetByFiscalYear/{year}")]
        public IActionResult GovernmentDisbursementGoalView(int year)
        {
            var data = _SecServices.GovernmentDisbursementGoalByFiscalYear(year);
            return Json(data);
        }


        [HttpPost]
        [Route("/Plan/Setup/PlanCRUDPolicySetup")]
        public IActionResult PlanCRUDPolicySetup(PlanCrudpolicy request)
        {
            var data = _SecServices.PlanCRUDPolicySetup( request);
            return Json(data);
        }
        [HttpGet]
        [Route("/Plan/Setup/PlanCRUDPolicySetup/GetPolicy/{year}")]
        public IActionResult PlanCRUDPolicySetupGetPolicy(int year)
        {
            var data = _SecServices.GetPolicy(year);
            return Json(data);
        }
        [HttpPost]
        [Route("/Plan/Setup/PlanCRUDPolicySetup/SaveButton")]
        public IActionResult PlanCRUDPolicySaveButton_Click_add(PlanCrudpolicy _PlanCrudpolicy)
        {
            var response = _SecServices.AddUpdatePlanCrudpolicy(_PlanCrudpolicy);
            return Json(response);
        }



        //[HttpGet]
        //[Route("/Plan/Setup/PlanDepartmentStaffPermissionForPlanAndProcure")]
        //public IActionResult PlanDepartmentStaffPermissionForPlanAndProcure()
        //{
        //    return Json("PlanDepartmentStaffPermissionForPlanAndProcure");
        //}



        [HttpGet]
        [Route("/Plan/Setup/PlanItemTypeSetup")]
        public IActionResult PlanItemTypeSetup(PlanItemTypeRequest request)
        {
            var data = _SecServices.PlanItemTypes(request);
            return Json(data);
        }



        [HttpPost]
        [Route("/Plan/Setup/PlanPersonSetup")]
        public IActionResult PlanPersonSetup(PlanPersonRequest request)
        {
            var data = _SecServices.PlanPerson( request);
            return Json(data);
        }



        [HttpPost]
        [Route("/Plan/Setup/PlanTypeSetup")]
        public IActionResult PlanTypeSetup(PlanTypeRequest request)
        {
            var data = _SecServices.PlanTypeSetup(request);
            return Json(data);
        }




        [HttpGet]
        [Route("/Plan/Setup/PlanWeightSetup")]
        public IActionResult PlanWeightSetup()
        {
            return Json("PlanWeightSetup");
        }


     

        [HttpGet]
        [Route("/Plan/Setup/PrinciplePlanTagSetup")]
        public IActionResult PrinciplePlanTag()
        {
            var data = _SecServices.PrinciplePlanTagSetup();
            return Json(data);
        }

        [HttpPost]
        [Route("/Plan/Setup/PrinciplePlanTagSetup/Setup")]
        public IActionResult PrinciplePlanTagSetup(PrinciplePlanTagsRequest request)
        {
            var data = _SecServices.PrinciplePlanTagSetupData(request);
            return Json(data);
        }

        [HttpPost]
        [Route("/Plan/Setup/StrategicIndicatorSetup")]
        public IActionResult StrategicIndicatorSetup(StrategicIndicatorRequest request)
        {
            var data = _SecServices.StrategicIndicatorSetup(request);
            return Json(data);
        }
        [HttpGet]
        [Route("/Plan/Setup/StrategicIndicatorSetup/FiscalYear/{year}")]
        public IActionResult StrategicIndicatorSetupByFiscalYear(int year)
        {
            var data = _SecServices.StrategicIndicatorSetupByFiscalYear(year);
            return Json(data);
        }
        [HttpGet]
        [Route("/Plan/Setup/StrategicIndicatorSetup/StrategyId/{StrategyId}")]
        public IActionResult StrategicIndicatorGetbyStrategyId(int StrategyId)
        {
            var data = _SecServices.StrategicIndicatorGetbyStrategyId(StrategyId);
            return Json(data);
        }
        [HttpGet]
        [Route("/Plan/Setup/StrategySetup/FiscalYear/{year}")]
        public IActionResult StrategySetupByFiscalYear(int year)
        {
            var data = _SecServices.StrategySetupByFiscalYear(year);
            return Json(data);
        }
        [HttpGet]
        [Route("/Plan/Setup/StrategyBudget/FiscalYear/{year}")]
        public IActionResult StrategyBudgetByFiscalYear(int year)
        {
            var data = _SecServices.StrategyBudgetByFiscalYear(year);
            return Json(data);
        }
        [HttpGet]
        [Route("/Plan/Setup/StrategySetup/FiscalYearandStrategyId/{year}/{id}")]
        public IActionResult StrategySetupByFiscalYearandStrategyId(int year, int id)
        {
            var data = _SecServices.StrategySetupByFiscalYearandStrategyId(year,id);
            return Json(data);
        }
        [HttpGet]
        [Route("/Plan/Setup/StrategyBudget/FiscalYearandStrategyId/{year}/{id}")]
        public IActionResult StrategyBudgetByFiscalYearandStrategyId(int year, int id)
        {
            var data = _SecServices.StrategyBudgetByFiscalYearandStrategyId(year, id);
            return Json(data);
        }
        [HttpPost]
        [Route("/Plan/Setup/StrategySetup")]
        public IActionResult StrategySetup(StrategySetupModel request)
        {
            var data = _SecServices.StrategySetup(request);
            return Json(data);
        }
        [HttpPost]
        [Route("/Plan/Setup/StrategyBudgetSetup")]
        public IActionResult StrategyBudgetSetup(StrategyBudgetDto request)
        {
            var data = _SecServices.StrategyBudgetSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/Plan/Setup/StrategySetup/DeleteStrategy/{Id}")]
        public IActionResult DeleteStrategy(int Id)
        {

            var data = _SecServices.DeleteStrategy(Id);

            return Json(data);
        }
        [HttpDelete]
        [Route("/Plan/Setup/StrategyBudget/DeleteStrategy/{Id}")]
        public IActionResult DeleteStrategyBudget(int Id)
        {

            var data = _SecServices.DeleteStrategyBudget(Id);

            return Json(data);
        }
        [HttpDelete]
        [Route("/Plan/Setup/StrategicIndicatorSetup/DeleteStrategicIndicator/{Id}")]
        public IActionResult DeleteStrategicIndicator(int Id)
        {

            var data = _SecServices.DeleteStrategicIndicator(Id);

            return Json(data);
        }
        [HttpDelete]
        [Route("/Plan/Setup/PlanTypeSetup/DeletePlanType/{Id}")]
        public IActionResult DeletePlanType(int Id)
        {

            var data = _SecServices.DeletePlanType(Id);

            return Json(data);
        }
        [HttpDelete]
        [Route("/Plan/Setup/DepartmentSetup/DeleteDepartment/{Id}")]
        public IActionResult DeleteDepartment(int Id)
        {

            var data = _SecServices.DeleteDepartment(Id);

            return Json(data);
        }
        [HttpDelete]
        [Route("/Plan/Setup/FundTypeSetup/DeleteFundType/{Id}")]
        public IActionResult DeleteFundType(int Id)
        {

            var data = _SecServices.DeleteFundType(Id);

            return Json(data);
        }
        [HttpDelete]
        [Route("/Plan/Setup/BudgetSetup/DeleteBudgetType/{Id}")]
        public IActionResult DeleteBudgetType(int Id)
        {

            var data = _SecServices.DeleteBudgetType(Id);

            return Json(data);
        }
        [HttpDelete]
        [Route("/Plan/Setup/PlanCoreSetup/DeletePlanCore/{Id}")]
        public IActionResult DeletePlanCore(int Id)
        {

            var data = _SecServices.DeletePlanCore(Id);

            return Json(data);
        }
        [HttpDelete]
        [Route("/Plan/Setup/PlanCoreSetup/DeleteResponsiblePerson/{Id}")]
        public IActionResult DeleteResponsiblePerson(int Id)
        {

            var data = _SecServices.DeleteResponsiblePerson(Id);

            return Json(data);
        }
        [HttpDelete]
        [Route("/Plan/Setup/FundSourceSetup/DeleteFundSource/{Id}")]
        public IActionResult DeleteFundSource(int Id)
        {

            var data = _SecServices.DeleteFundSource(Id);

            return Json(data);
        }
        [HttpDelete]
        [Route("/Plan/Setup/MissionSetup/DeleteMission/{Id}")]
        public IActionResult DeleteMission(int Id)
        {

            var data = _SecServices.DeleteMission(Id);

            return Json(data);
        }
        #endregion
        //[HttpGet]
        //[Route("Plan/Setup/GetByFiscalYear{year}")]
        //public IActionResult GetByFiscalYear(int year)
        //{
        //    _Logger.LogInformation("sql");
        //    var data = _Service.BudgetTypeByYear(year);
        //    var _BudgetType = new List<BudgetTypeDto>();
        //    foreach (var item in data)
        //    {
        //        _BudgetType.Add(new BudgetTypeDto
        //        {
        //            Id = item.Id,
        //            Name = item.Name,
        //            Active = item.Active,
        //            FiscalYear = item.FiscalYear,
        //            ParentBudgetTypeId = item.ParentBudgetTypeId,
        //            ReferenceOldId = item.ReferenceOldId,
        //            ExpenseTypeEnum = item.ExpenseTypeEnum,
        //            GovExpenseTypeEnum = item.GovExpenseTypeEnum,

        //        });

        //    }
        //    return Json(_BudgetType);
        //}


    }
}
