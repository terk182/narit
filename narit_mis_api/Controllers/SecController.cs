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
        [Route("/Plan/Operate/EditScheduleFisicalYear")]
        public IActionResult GetScheduleFisicalYear()
        {
            var data = _SecServices.GetScheduleFisicalYear();
            return Json(data);
        }

        [HttpPost]
        [Route("/Plan/Operate/EditScheduleFisicalYearByYear")]
        public IActionResult EditScheduleFisicalYear(string name, bool active)
        {
            var data = _SecServices.EditScheduleFisicalYear(name, active);
            return Json(data);
        }
        [HttpGet]
        [Route("/Plan/Operate/EditScheduleFisicalYear/GetbyYear/{year}")]
        public IActionResult GetScheduleFisicalYearbyYear(int year)
        {
            var data = _SecServices.GetScheduleFisicalYearbyYear(year);
            return Json(data);
        }
        [HttpPost]
        [Route("/Plan/Operate/ScheduleFisicalYearSetUp")]
        public IActionResult ScheduleFisicalYearSetUp(ScheduleFisicalYear request)
        {
            var data = _SecServices.ScheduleFisicalYearSetUp(request);
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
        [Route("/Plan/Operate/EditPlan/GetPlanCorefromParentPlanCore/{plancoreId}")]
        public IActionResult GetPlanCorefromParentPlanCore(int plancoreId)
        {
            var data = _SecServices.GetPlanCorefromParentPlanCore(plancoreId);
            return Json(data);
        }
        [HttpGet]
        [Route("/Plan/Operate/EditPlan/GetPlanCoreDetail/{plancoreId}")]
        public IActionResult GetPlanCoreDetail(int plancoreId)
        {
            var data = _SecServices.GetPlanCoreDetail(plancoreId);
            return Json(data);
        }
        [HttpGet]
        [Route("/Plan/Operate/EditPlan/GetPlanActivityfromPlanCoreId/{plancoreId}")]
        public IActionResult GetPlanActivityfromPlanCoreId(int plancoreId)
        {
            var data = _SecServices.GetPlanActivityfromPlanCoreId(plancoreId);
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
        [Route("/Plan/Operate/DepartmentNameGetByDepartmentid/{id}")]
        public IActionResult DepartmentNameGetByDepartmentid(int id)
        {
            var data = _SecServices.DepartmentNameGetByDepartmentid(id);
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
       

        [HttpGet]
        [Route("/Plan/Operate/PlanTypeNameGetByPlanTypeid/GetByPlanTypeid/{id}")]
        public IActionResult PlanTypeNameGetByPlanTypeid(int id)
        {
            var data = _SecServices.PlanTypeNameGetByPlanTypeid(id);
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
        [Route("/Plan/Setup/GetStrategicIndicatorbyStrategyId/{StrategyId}")]
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

        /////////////////////////////////new new new by ardin/////////////////////////////////
        //MainGovtStatement
        [HttpGet]
        [Route("/Sec/MainGovtStatement/GetAll")]
        public IActionResult GetAllMainGovtStatement()
        {
            var data = _SecServices.GetAllMainGovtStatement();
            return Json(data);
        }
        [HttpGet]
        [Route("/Sec/MainGovtStatement/GetbyFisicalYear/{FisicalYear}")]
        public IActionResult GetMainGovtStatementbyFisicalYear(int FisicalYear)
        {
            var data = _SecServices.GetMainGovtStatementbyFisicalYear(FisicalYear);
            return Json(data);
        }
        [HttpGet]
        [Route("/Sec/MainGovtStatement/GetbyId/{MainGovtStatementId}")]
        public IActionResult GetMainGovtStatementbyId(int MainGovtStatementId)
        {
            var data = _SecServices.GetMainGovtStatementbyId(MainGovtStatementId);
            return Json(data);
        }
        [HttpPost]
        [Route("/Sec/MainGovtStatement/Setup")]
        public IActionResult MainGovtStatementSetup(MainGovtStatement request)
        {
            var data = _SecServices.MainGovtStatementSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/Sec/MainGovtStatement/Delete/{MainGovtStatementId}")]
        public IActionResult DeleteMainGovtStatement(int MainGovtStatementId)
        {

            var data = _SecServices.DeleteMainGovtStatement(MainGovtStatementId);

            return Json(data);
        }
        //GovtStrategic
        [HttpGet]
        [Route("/GovtStrategic/GetAll")]
        public IActionResult GetAllGovtStrategic()
        {
            var data = _SecServices.GetAllGovtStrategic();
            return Json(data);
        }
        [HttpGet]
        [Route("/GovtStrategic/GetbyId/{GovtStrategicId}")]
        public IActionResult GetGovtStrategicbyId(int GovtStrategicId)
        {
            var data = _SecServices.GetGovtStrategicbyId(GovtStrategicId);
            return Json(data);
        }
        [HttpPost]
        [Route("/GovtStrategic/Setup")]
        public IActionResult GovtStrategicSetup(GovtStrategic request)
        {
            var data = _SecServices.GovtStrategicSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/GovtStrategic/Delete/{GovtStrategicId}")]
        public IActionResult DeleteGovtStrategic(int GovtStrategicId)
        {

            var data = _SecServices.DeleteGovtStrategic(GovtStrategicId);

            return Json(data);
        }
        //GovtPlan
        [HttpGet]
        [Route("/GovtPlan/GetAll")]
        public IActionResult GetAllGovtPlan()
        {
            var data = _SecServices.GetAllGovtPlan();
            return Json(data);
        }
        [HttpGet]
        [Route("/GovtPlan/GetbyId/{GovtPlanId}")]
        public IActionResult GetGovtPlanbyId(int GovtPlanId)
        {
            var data = _SecServices.GetGovtPlanbyId(GovtPlanId);
            return Json(data);
        }
        [HttpPost]
        [Route("/GovtPlan/Setup")]
        public IActionResult GovtPlanSetup(GovtPlan request)
        {
            var data = _SecServices.GovtPlanSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/GovtPlan/Delete/{GovtPlanId}")]
        public IActionResult DeleteGovtPlan(int GovtPlanId)
        {

            var data = _SecServices.DeleteGovtPlan(GovtPlanId);

            return Json(data);
        }
        //MainProject
        [HttpGet]
        [Route("/MainProject/GetAll")]
        public IActionResult GetAllMainProject()
        {
            var data = _SecServices.GetAllMainProject();
            return Json(data);
        }
        [HttpGet]
        [Route("/MainProject/GetbyId/{MainProjectId}")]
        public IActionResult GetMainProjectbyId(int MainProjectId)
        {
            var data = _SecServices.GetMainProjectbyId(MainProjectId);
            return Json(data);
        }
        [HttpPost]
        [Route("/MainProject/Setup")]
        public IActionResult MainProjectSetup(MainProject request)
        {
            var data = _SecServices.MainProjectSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/MainProject/Delete/{MainProjectId}")]
        public IActionResult DeleteMainProject(int MainProjectId)
        {

            var data = _SecServices.DeleteMainProject(MainProjectId);

            return Json(data);
        }
        //MainActivity
        [HttpGet]
        [Route("/MainActivity/GetAll")]
        public IActionResult GetAllMainActivity()
        {
            var data = _SecServices.GetAllMainActivity();
            return Json(data);
        }
        [HttpGet]
        [Route("/MainActivity/GetbyId/{MainActivityId}")]
        public IActionResult GetMainActivitybyId(int MainActivityId)
        {
            var data = _SecServices.GetMainActivitybyId(MainActivityId);
            return Json(data);
        }
        [HttpPost]
        [Route("/MainActivity/Setup")]
        public IActionResult MainActivitySetup(MainActivity request)
        {
            var data = _SecServices.MainActivitySetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/MainActivity/Delete/{MainActivityId}")]
        public IActionResult DeleteMainActivity(int MainActivityId)
        {

            var data = _SecServices.DeleteMainActivity(MainActivityId);

            return Json(data);
        }
        //StrategicIssue
        [HttpGet]
        [Route("/StrategicIssue/GetAll")]
        public IActionResult GetAllStrategicIssue()
        {
            var data = _SecServices.GetAllStrategicIssue();
            return Json(data);
        }
        [HttpGet]
        [Route("/StrategicIssue/GetbyId/{StrategicIssueId}")]
        public IActionResult GetStrategicIssuebyId(int StrategicIssueId)
        {
            var data = _SecServices.GetStrategicIssuebyId(StrategicIssueId);
            return Json(data);
        }
        [HttpPost]
        [Route("/StrategicIssue/Setup")]
        public IActionResult StrategicIssueSetup(StrategicIssue request)
        {
            var data = _SecServices.StrategicIssueSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/StrategicIssue/Delete/{StrategicIssueId}")]
        public IActionResult DeleteStrategicIssue(int StrategicIssueId)
        {

            var data = _SecServices.DeleteStrategicIssue(StrategicIssueId);

            return Json(data);
        }
        ////Strategy1
        //[HttpGet]
        //[Route("/Strategy1/GetAll")]
        //public IActionResult GetAllStrategy1()
        //{
        //    var data = _SecServices.GetAllStrategy1();
        //    return Json(data);
        //}
        //[HttpGet]
        //[Route("/Strategy1/GetbyId/{Strategy1Id}")]
        //public IActionResult GetStrategy1byId(int Strategy1Id)
        //{
        //    var data = _SecServices.GetStrategy1byId(Strategy1Id);
        //    return Json(data);
        //}
        //[HttpPost]
        //[Route("/Strategy1/Setup")]
        //public IActionResult Strategy1Setup(Strategy1 request)
        //{
        //    var data = _SecServices.Strategy1Setup(request);
        //    return Json(data);
        //}
        //[HttpDelete]
        //[Route("/Strategy1/Delete/{Strategy1Id}")]
        //public IActionResult DeleteStrategy1(int Strategy1Id)
        //{

        //    var data = _SecServices.DeleteStrategy1(Strategy1Id);

        //    return Json(data);
        //}
        ////Measure
        //[HttpGet]
        //[Route("/Measure/GetAll")]
        //public IActionResult GetAllMeasure()
        //{
        //    var data = _SecServices.GetAllMeasure();
        //    return Json(data);
        //}
        //[HttpGet]
        //[Route("/Measure/GetbyId/{MeasureId}")]
        //public IActionResult GetMeasurebyId(int MeasureId)
        //{
        //    var data = _SecServices.GetMeasurebyId(MeasureId);
        //    return Json(data);
        //}
        //[HttpPost]
        //[Route("/Measure/Setup")]
        //public IActionResult MeasureSetup(Measure request)
        //{
        //    var data = _SecServices.MeasureSetup(request);
        //    return Json(data);
        //}
        //[HttpDelete]
        //[Route("/Measure/Delete/{MeasureId}")]
        //public IActionResult DeleteMeasure(int MeasureId)
        //{

        //    var data = _SecServices.DeleteMeasure(MeasureId);

        //    return Json(data);
        //}
        //AnnualBudget
        [HttpGet]
        [Route("/AnnualBudget/GetAll")]
        public IActionResult GetAllAnnualBudget()
        {
            var data = _SecServices.GetAllAnnualBudget();
            return Json(data);
        }
        [HttpGet]
        [Route("/AnnualBudget/GetbyFisicalYear/{FisicalYear}")]
        public IActionResult GetAnnualBudgetbyFisicalYear(int FisicalYear)
        {
            var data = _SecServices.GetAnnualBudgetbyFisicalYear(FisicalYear);
            return Json(data);
        }
        [HttpGet]
        [Route("/AnnualBudget/GetbyId/{AnnualBudgetId}")]
        public IActionResult GetAnnualBudgetbyId(int AnnualBudgetId)
        {
            var data = _SecServices.GetAnnualBudgetbyId(AnnualBudgetId);
            return Json(data);
        }
        [HttpPost]
        [Route("/AnnualBudget/Setup")]
        public IActionResult AnnualBudgetSetup(AnnualBudget request)
        {
            var data = _SecServices.AnnualBudgetSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/AnnualBudget/Delete/{AnnualBudgetId}")]
        public IActionResult DeleteAnnualBudget(int AnnualBudgetId)
        {

            var data = _SecServices.DeleteAnnualBudget(AnnualBudgetId);

            return Json(data);
        }
        //SubAnnualBudget
        [HttpGet]
        [Route("/SubAnnualBudget/GetAll")]
        public IActionResult GetAllSubAnnualBudget()
        {
            var data = _SecServices.GetAllSubAnnualBudget();
            return Json(data);
        }
        [HttpGet]
        [Route("/SubAnnualBudget/GetbyFisicalYear/{FisicalYear}")]
        public IActionResult GetSubAnnualBudgetbyFisicalYear(int FisicalYear)
        {
            var data = _SecServices.GetSubAnnualBudgetbyFisicalYear(FisicalYear);
            return Json(data);
        }
        [HttpGet]
        [Route("/SubAnnualBudget/GetbyId/{SubAnnualBudgetId}")]
        public IActionResult GetSubAnnualBudgetbyId(int SubAnnualBudgetId)
        {
            var data = _SecServices.GetSubAnnualBudgetbyId(SubAnnualBudgetId);
            return Json(data);
        }
        [HttpPost]
        [Route("/SubAnnualBudget/Setup")]
        public IActionResult SubAnnualBudgetSetup(SubAnnualBudget request)
        {
            var data = _SecServices.SubAnnualBudgetSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/SubAnnualBudget/Delete/{SubAnnualBudgetId}")]
        public IActionResult DeleteSubAnnualBudget(int SubAnnualBudgetId)
        {

            var data = _SecServices.DeleteSubAnnualBudget(SubAnnualBudgetId);

            return Json(data);
        }
        //CapticalType
        [HttpGet]
        [Route("/CapticalType/GetAll")]
        public IActionResult GetAllCapticalType()
        {
            var data = _SecServices.GetAllCapticalType();
            return Json(data);
        }
        [HttpGet]
        [Route("/CapticalType/GetbyFisicalYear/{FisicalYear}")]
        public IActionResult GetCapticalTypebyFisicalYear(int FisicalYear)
        {
            var data = _SecServices.GetCapticalTypebyFisicalYear(FisicalYear);
            return Json(data);
        }
        [HttpGet]
        [Route("/CapticalType/GetbyId/{CapticalTypeId}")]
        public IActionResult GetCapticalTypebyId(int CapticalTypeId)
        {
            var data = _SecServices.GetCapticalTypebyId(CapticalTypeId);
            return Json(data);
        }
        [HttpPost]
        [Route("/CapticalType/Setup")]
        public IActionResult CapticalTypeSetup(CapticalType request)
        {
            var data = _SecServices.CapticalTypeSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/CapticalType/Delete/{CapticalTypeId}")]
        public IActionResult DeleteCapticalType(int CapticalTypeId)
        {

            var data = _SecServices.DeleteCapticalType(CapticalTypeId);

            return Json(data);
        }
        //Project
        [HttpGet]
        [Route("/Project/GetAll")]
        public IActionResult GetAllProject()
        {
            var data = _SecServices.GetAllProject();
            return Json(data);
        }
        [HttpGet]
        [Route("/Project/GetbyFisicalYear/{FisicalYear}")]
        public IActionResult GetProjectbyFisicalYear(int FisicalYear)
        {
            var data = _SecServices.GetProjectbyFisicalYear(FisicalYear);
            return Json(data);
        }
        [HttpGet]
        [Route("/Project/GetbyId/{ProjectId}")]
        public IActionResult GetProjectbyId(int ProjectId)
        {
            var data = _SecServices.GetProjectbyId(ProjectId);
            return Json(data);
        }
        [HttpGet]
        [Route("/Project/GetsubProjectorProjectActivitybyProjectId/{ProjectId}")]
        public IActionResult GetsubProjectorProjectActivitybyProjectId(int ProjectId)
        {
            var data = _SecServices.GetsubProjectorProjectActivitybyProjectId(ProjectId);
            return Json(data);
        }
        [HttpPost]
        [Route("/Project/Setup")]
        public IActionResult ProjectSetup(Project request)
        {
            var data = _SecServices.ProjectSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/Project/Delete/{ProjectId}")]
        public IActionResult DeleteProject(int ProjectId)
        {

            var data = _SecServices.DeleteProject(ProjectId);

            return Json(data);
        }
        //ProjectCaptical
        [HttpGet]
        [Route("/ProjectCaptical/GetAll")]
        public IActionResult GetAllProjectCaptical()
        {
            var data = _SecServices.GetAllProjectCaptical();
            return Json(data);
        }
        [HttpGet]
        [Route("/ProjectCaptical/GetbyId/{ProjectCapticalId}")]
        public IActionResult GetProjectCapticalbyId(int ProjectCapticalId)
        {
            var data = _SecServices.GetProjectCapticalbyId(ProjectCapticalId);
            return Json(data);
        }
        [HttpPost]
        [Route("/ProjectCaptical/Setup")]
        public IActionResult ProjectCapticalSetup(ProjectCaptical request)
        {
            var data = _SecServices.ProjectCapticalSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/ProjectCaptical/Delete/{ProjectCapticalId}")]
        public IActionResult DeleteProjectCaptical(int ProjectCapticalId)
        {

            var data = _SecServices.DeleteProjectCaptical(ProjectCapticalId);

            return Json(data);
        }
        //ProjectResponsiblePerson
        [HttpGet]
        [Route("/ProjectResponsiblePerson/GetAll")]
        public IActionResult GetAllProjectResponsiblePersons()
        {
            var data = _SecServices.GetAllProjectResponsiblePersons();
            return Json(data);
        }
        [HttpGet]
        [Route("/ProjectResponsiblePerson/GetbyId/{ProjectResponsiblePersonsId}")]
        public IActionResult GetProjectResponsiblePersonsbyId(int ProjectResponsiblePersonsId)
        {
            var data = _SecServices.GetProjectResponsiblePersonsbyId(ProjectResponsiblePersonsId);
            return Json(data);
        }
        [HttpGet]
        [Route("/ProjectResponsiblePerson/GetbyProjectId/{ProjectId}")]
        public IActionResult GetProjectResponsiblePersonsbyProjectId(int ProjectId)
        {
            var data = _SecServices.GetProjectResponsiblePersonsbyProjectId(ProjectId);
            return Json(data);
        }
        [HttpPost]
        [Route("/ProjectResponsiblePerson/Setup")]
        public IActionResult ProjectResponsiblePersonsSetup(ProjectResponsiblePerson request)
        {
            var data = _SecServices.ProjectResponsiblePersonsSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/ProjectResponsiblePerson/Delete/{ProjectResponsiblePersonsId}")]
        public IActionResult DeleteProjectResponsiblePersons(int ProjectResponsiblePersonsId)
        {

            var data = _SecServices.DeleteProjectResponsiblePersons(ProjectResponsiblePersonsId);

            return Json(data);
        }
        //IndicatorsStrategyForProject
        [HttpGet]
        [Route("/IndicatorsStrategyForProject/GetAll")]
        public IActionResult GetAllIndicatorsStrategyForProject()
        {
            var data = _SecServices.GetAllIndicatorsStrategyForProject();
            return Json(data);
        }
        [HttpGet]
        [Route("/IndicatorsStrategyForProject/GetbyId/{IndicatorsStrategyForProjectId}")]
        public IActionResult GetIndicatorsStrategyForProjectbyId(int IndicatorsStrategyForProjectId)
        {
            var data = _SecServices.GetIndicatorsStrategyForProjectbyId(IndicatorsStrategyForProjectId);
            return Json(data);
        }
        [HttpGet]
        [Route("/IndicatorsStrategyForProject/GetbyProjectId/{ProjectId}")]
        public IActionResult GetIndicatorsStrategyForProjectbyProjectId(int ProjectId)
        {
            var data = _SecServices.GetIndicatorsStrategyForProjectbyProjectId(ProjectId);
            return Json(data);
        }
        [HttpPost]
        [Route("/IndicatorsStrategyForProject/Setup")]
        public IActionResult IndicatorsStrategyForProjectSetup(IndicatorsStrategyForProject request)
        {
            var data = _SecServices.IndicatorsStrategyForProjectSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/IndicatorsStrategyForProject/Delete/{IndicatorsStrategyForProjectId}")]
        public IActionResult DeleteIndicatorsStrategyForProject(int IndicatorsStrategyForProjectId)
        {

            var data = _SecServices.DeleteIndicatorsStrategyForProject(IndicatorsStrategyForProjectId);

            return Json(data);
        }
        //ExternalBudgetStrategy
        [HttpGet]
        [Route("/ExternalBudgetStrategy/GetAll")]
        public IActionResult GetAllExternalBudgetStrategy()
        {
            var data = _SecServices.GetAllExternalBudgetStrategy();
            return Json(data);
        }
        [HttpGet]
        [Route("/ExternalBudgetStrategy/GetbyFisicalYear/{FisicalYear}")]
        public IActionResult GetExternalBudgetStrategybyFisicalYear(int FisicalYear)
        {
            var data = _SecServices.GetExternalBudgetStrategybyFisicalYear(FisicalYear);
            return Json(data);
        }
        [HttpGet]
        [Route("/ExternalBudgetStrategy/GetbyId/{ExternalBudgetStrategyId}")]
        public IActionResult GetExternalBudgetStrategybyId(int ExternalBudgetStrategyId)
        {
            var data = _SecServices.GetExternalBudgetStrategybyId(ExternalBudgetStrategyId);
            return Json(data);
        }
        [HttpPost]
        [Route("/ExternalBudgetStrategy/Setup")]
        public IActionResult ExternalBudgetStrategySetup(ExternalBudgetStrategy request)
        {
            var data = _SecServices.ExternalBudgetStrategySetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/ExternalBudgetStrategy/Delete/{ExternalBudgetStrategyId}")]
        public IActionResult DeleteExternalBudgetStrategy(int ExternalBudgetStrategyId)
        {

            var data = _SecServices.DeleteExternalBudgetStrategy(ExternalBudgetStrategyId);

            return Json(data);
        }
        //InternalStrategy
        [HttpGet]
        [Route("/InternalStrategy/GetAll")]
        public IActionResult GetAllInternalStrategy()
        {
            var data = _SecServices.GetAllInternalStrategy();
            return Json(data);
        }
        [HttpGet]
        [Route("/InternalStrategy/GetbyFisicalYear/{FisicalYear}")]
        public IActionResult GetInternalStrategybyFisicalYear(int FisicalYear)
        {
            var data = _SecServices.GetInternalStrategybyFisicalYear(FisicalYear);
            return Json(data);
        }
        [HttpGet]
        [Route("/InternalStrategy/GetbyId/{InternalStrategyId}")]
        public IActionResult GetInternalStrategybyId(int InternalStrategyId)
        {
            var data = _SecServices.GetInternalStrategybyId(InternalStrategyId);
            return Json(data);
        }
        [HttpPost]
        [Route("/InternalStrategy/Setup")]
        public IActionResult InternalStrategySetup(InternalStrategy request)
        {
            var data = _SecServices.InternalStrategySetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/InternalStrategy/Delete/{InternalStrategyId}")]
        public IActionResult DeleteInternalStrategy(int InternalStrategyId)
        {

            var data = _SecServices.DeleteInternalStrategy(InternalStrategyId);

            return Json(data);
        }
        //ProjectActivity
        [HttpGet]
        [Route("/ProjectActivity/GetAll")]
        public IActionResult GetAllProjectActivity()
        {
            var data = _SecServices.GetAllProjectActivity();
            return Json(data);
        }
        [HttpGet]
        [Route("/ProjectActivity/GetbyId/{ProjectActivityId}")]
        public IActionResult GetProjectActivitybyId(int ProjectActivityId)
        {
            var data = _SecServices.GetProjectActivitybyId(ProjectActivityId);
            return Json(data);
        }
        [HttpGet]
        [Route("/ProjectActivity/GetProjectActivityforProjectbyId/{ProjectId}")]
        public IActionResult GetProjectActivityforProjectbyId(int ProjectId)
        {
            var data = _SecServices.GetProjectActivityforProjectbyId(ProjectId);
            return Json(data);
        }
        [HttpGet]
        [Route("/ProjectActivity/GetbySubProjectId/{SubProjectId}")]
        public IActionResult GetProjectActivityfromSubProjectId(int SubProjectId)
        {
            var data = _SecServices.GetProjectActivityfromSubProjectId(SubProjectId);
            return Json(data);
        }
        [HttpPost]
        [Route("/ProjectActivity/Setup")]
        public IActionResult ProjectActivitySetup(ProjectActivity request)
        {
            var data = _SecServices.ProjectActivitySetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/ProjectActivity/Delete/{ProjectActivityId}")]
        public IActionResult DeleteProjectActivity(int ProjectActivityId)
        {

            var data = _SecServices.DeleteProjectActivity(ProjectActivityId);

            return Json(data);
        }
        //SubProject
        [HttpGet]
        [Route("/SubProject/GetAll")]
        public IActionResult GetAllSubProject()
        {
            var data = _SecServices.GetAllSubProject();
            return Json(data);
        }
        [HttpGet]
        [Route("/SubProject/GetbyId/{SubProjectId}")]
        public IActionResult GetSubProjectbyId(int SubProjectId)
        {
            var data = _SecServices.GetSubProjectbyId(SubProjectId);
            return Json(data);
        }
        [HttpGet]
        [Route("/SubProject/GetSubProjectforProjectbyId/{ProjectId}")]
        public IActionResult GetSubProjectforProjectbyId(int ProjectId)
        {
            var data = _SecServices.GetSubProjectforProjectbyId(ProjectId);
            return Json(data);
        }
        [HttpPost]
        [Route("/SubProject/Setup")]
        public IActionResult SubProjectSetup(SubProject request)
        {
            var data = _SecServices.SubProjectSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/SubProject/Delete/{SubProjectId}")]
        public IActionResult DeleteSubProject(int SubProjectId)
        {

            var data = _SecServices.DeleteSubProject(SubProjectId);

            return Json(data);
        }
        //ProjectActivityResponsiblePerson
        [HttpGet]
        [Route("/ProjectActivityResponsiblePerson/GetAll")]
        public IActionResult GetAllProjectActivityResponsiblePerson()
        {
            var data = _SecServices.GetAllProjectActivityResponsiblePerson();
            return Json(data);
        }
        [HttpGet]
        [Route("/ProjectActivityResponsiblePerson/GetbyId/{ProjectActivityResponsiblePersonId}")]
        public IActionResult GetProjectActivityResponsiblePersonbyId(int ProjectActivityResponsiblePersonId)
        {
            var data = _SecServices.GetProjectActivityResponsiblePersonbyId(ProjectActivityResponsiblePersonId);
            return Json(data);
        }
        [HttpGet]
        [Route("/ProjectActivityResponsiblePerson/GetbyProjectId/{ProjectActivityId}")]
        public IActionResult GetProjectActivityResponsiblePersonsbyProjectId(int ProjectActivityId)
        {
            var data = _SecServices.GetProjectActivityResponsiblePersonsbyProjectId(ProjectActivityId);
            return Json(data);
        }
        [HttpPost]
        [Route("/ProjectActivityResponsiblePerson/Setup")]
        public IActionResult ProjectActivityResponsiblePersonSetup(ProjectActivityResponsiblePerson request)
        {
            var data = _SecServices.ProjectActivityResponsiblePersonSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/ProjectActivityResponsiblePerson/Delete/{ProjectActivityResponsiblePersonId}")]
        public IActionResult DeleteProjectActivityResponsiblePerson(int ProjectActivityResponsiblePersonId)
        {

            var data = _SecServices.DeleteProjectActivityResponsiblePerson(ProjectActivityResponsiblePersonId);

            return Json(data);
        }
        //SubProjectResponsiblePerson
        [HttpGet]
        [Route("/SubProjectResponsiblePerson/GetAll")]
        public IActionResult GetAllSubProjectResponsiblePerson()
        {
            var data = _SecServices.GetAllSubProjectResponsiblePerson();
            return Json(data);
        }
        [HttpGet]
        [Route("/SubProjectResponsiblePerson/GetbyId/{SubProjectResponsiblePersonId}")]
        public IActionResult GetSubProjectResponsiblePersonbyId(int SubProjectResponsiblePersonId)
        {
            var data = _SecServices.GetSubProjectResponsiblePersonbyId(SubProjectResponsiblePersonId);
            return Json(data);
        }
        [HttpGet]
        [Route("/SubProjectResponsiblePerson/GetbySubProjectId/{SubProjectId}")]
        public IActionResult GetSubProjectResponsiblePersonsbyProjectId(int SubProjectId)
        {
            var data = _SecServices.GetSubProjectResponsiblePersonsbySubProjectId(SubProjectId);
            return Json(data);
        }
        [HttpPost]
        [Route("/SubProjectResponsiblePerson/Setup")]
        public IActionResult SubProjectResponsiblePersonSetup(SubProjectResponsiblePerson request)
        {
            var data = _SecServices.SubProjectResponsiblePersonSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/SubProjectResponsiblePerson/Delete/{SubProjectResponsiblePersonId}")]
        public IActionResult DeleteSubProjectResponsiblePerson(int SubProjectResponsiblePersonId)
        {

            var data = _SecServices.DeleteSubProjectResponsiblePerson(SubProjectResponsiblePersonId);

            return Json(data);
        }
        //IndicatorsStrategyForProjectActivity
        [HttpGet]
        [Route("/IndicatorsStrategyForProjectActivity/GetAll")]
        public IActionResult GetAllIndicatorsStrategyForProjectActivity()
        {
            var data = _SecServices.GetAllIndicatorsStrategyForProjectActivity();
            return Json(data);
        }
        [HttpGet]
        [Route("/IndicatorsStrategyForProjectActivity/GetbyId/{IndicatorsStrategyForProjectActivityId}")]
        public IActionResult GetIndicatorsStrategyForProjectActivitybyId(int IndicatorsStrategyForProjectActivityId)
        {
            var data = _SecServices.GetIndicatorsStrategyForProjectActivitybyId(IndicatorsStrategyForProjectActivityId);
            return Json(data);
        }
        [HttpGet]
        [Route("/IndicatorsStrategyForProjectActivity/GetbyProjectActivityId/{ProjectActivityId}")]
        public IActionResult GetIndicatorsStrategyForProjectActivitybyProjectActivityId(int ProjectActivityId)
        {
            var data = _SecServices.GetIndicatorsStrategyForProjectActivitybyProjectActivityId(ProjectActivityId);
            return Json(data);
        }
        [HttpPost]
        [Route("/IndicatorsStrategyForProjectActivity/Setup")]
        public IActionResult IndicatorsStrategyForProjectActivitySetup(IndicatorsStrategyForProjectActivity request)
        {
            var data = _SecServices.IndicatorsStrategyForProjectActivitySetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/IndicatorsStrategyForProjectActivity/Delete/{IndicatorsStrategyForProjectActivityId}")]
        public IActionResult DeleteIndicatorsStrategyForProjectActivity(int IndicatorsStrategyForProjectActivityId)
        {

            var data = _SecServices.DeleteIndicatorsStrategyForProjectActivity(IndicatorsStrategyForProjectActivityId);

            return Json(data);
        }
        //IndicatorsStrategyForSubProject
        [HttpGet]
        [Route("/IndicatorsStrategyForSubProject/GetAll")]
        public IActionResult GetAllIndicatorsStrategyForSubProject()
        {
            var data = _SecServices.GetAllIndicatorsStrategyForSubProject();
            return Json(data);
        }
        [HttpGet]
        [Route("/IndicatorsStrategyForSubProject/GetbyId/{IndicatorsStrategyForSubProjectId}")]
        public IActionResult GetIndicatorsStrategyForSubProjectbyId(int IndicatorsStrategyForSubProjectId)
        {
            var data = _SecServices.GetIndicatorsStrategyForSubProjectbyId(IndicatorsStrategyForSubProjectId);
            return Json(data);
        }
        [HttpGet]
        [Route("/IndicatorsStrategyForSubProject/GetbySubProjectId/{SubProjectId}")]
        public IActionResult GetIndicatorsStrategyForSubProjectbySubProjectId(int SubProjectId)
        {
            var data = _SecServices.GetIndicatorsStrategyForSubProjectbySubProjectId(SubProjectId);
            return Json(data);
        }
        [HttpPost]
        [Route("/IndicatorsStrategyForSubProject/Setup")]
        public IActionResult IndicatorsStrategyForSubProjectSetup(IndicatorsStrategyForSubProject request)
        {
            var data = _SecServices.IndicatorsStrategyForSubProjectSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/IndicatorsStrategyForSubProject/Delete/{IndicatorsStrategyForSubProjectId}")]
        public IActionResult DeleteIndicatorsStrategyForSubProject(int IndicatorsStrategyForSubProjectId)
        {

            var data = _SecServices.DeleteIndicatorsStrategyForSubProject(IndicatorsStrategyForSubProjectId);

            return Json(data);
        }
        //ListBudgetForActivity
        [HttpGet]
        [Route("/ListBudgetForActivity/GetAll")]
        public IActionResult GetAllListBudgetForActivity()
        {
            var data = _SecServices.GetAllListBudgetForActivity();
            return Json(data);
        }
        [HttpGet]
        [Route("/ListBudgetForActivity/GetbyId/{ListBudgetForActivityId}")]
        public IActionResult GetListBudgetForActivitybyId(int ListBudgetForActivityId)
        {
            var data = _SecServices.GetListBudgetForActivitybyId(ListBudgetForActivityId);
            return Json(data);
        }
        [HttpGet]
        [Route("/ListBudgetForActivity/GetbyProjectActivityId/{ProjectActivityId}")]
        public IActionResult GetListBudgetForActivitybyProjectActivityId(int ProjectActivityId)
        {
            var data = _SecServices.GetListBudgetForActivitybyProjectActivityId(ProjectActivityId);
            return Json(data);
        }
        [HttpGet]
        [Route("/ListBudgetForActivity/GetbysubProjectId/{subProjectId}")]
        public IActionResult GetListBudgetForActivitybysubProjectId(int subProjectId)
        {
            var data = _SecServices.GetListBudgetForActivitybysubProjectId(subProjectId);
            return Json(data);
        }
        [HttpPost]
        [Route("/ListBudgetForActivity/Setup")]
        public IActionResult ListBudgetForActivitySetup(ListBudgetForActivity request)
        {
            var data = _SecServices.ListBudgetForActivitySetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/ListBudgetForActivity/Delete/{ListBudgetForActivityId}")]
        public IActionResult DeleteListBudgetForActivity(int ListBudgetForActivityId)
        {

            var data = _SecServices.DeleteListBudgetForActivity(ListBudgetForActivityId);

            return Json(data);
        }
        //BudgetDisbursementPlan
        [HttpGet]
        [Route("/BudgetDisbursementPlan/GetAll")]
        public IActionResult GetAllBudgetDisbursementPlan()
        {
            var data = _SecServices.GetAllBudgetDisbursementPlan();
            return Json(data);
        }
        [HttpGet]
        [Route("/BudgetDisbursementPlan/GetbyId/{BudgetDisbursementPlanId}")]
        public IActionResult GetBudgetDisbursementPlanbyId(int BudgetDisbursementPlanId)
        {
            var data = _SecServices.GetBudgetDisbursementPlanbyId(BudgetDisbursementPlanId);
            return Json(data);
        }
        [HttpPost]
        [Route("/BudgetDisbursementPlan/Setup")]
        public IActionResult BudgetDisbursementPlanSetup(BudgetDisbursementPlan request)
        {
            var data = _SecServices.BudgetDisbursementPlanSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/BudgetDisbursementPlan/Delete/{BudgetDisbursementPlanId}")]
        public IActionResult DeleteBudgetDisbursementPlan(int BudgetDisbursementPlanId)
        {

            var data = _SecServices.DeleteBudgetDisbursementPlan(BudgetDisbursementPlanId);

            return Json(data);
        }
    }
}
