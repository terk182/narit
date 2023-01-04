using narit_mis_api.Models;
using Microsoft.AspNetCore.Mvc;
using App.FIN;
using App.FIN.Dtos;
using App.SEC.Models.Requests;
using App.FIN.Models.Requests;

namespace narit_mis_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FinController : Controller
    {
        protected readonly IFinServices _FinServices;

        private readonly ILogger _Logger;

        public FinController(ILogger<FinController> logger, IFinServices FinServices)
        {
            _FinServices = FinServices;

            _Logger = logger;

            //_configuration = Configuration;
            // connecttion = _configuration.GetConnectionString("Defaultconnectton");
        }
        #region Operate
        [HttpGet]
        [Route("Finance/MainFinancePage")]
        public IActionResult MainFinancePage()
        {
            return Json("MainFinancePage");
        }

        [HttpGet]
        [Route("Finance/Operate/ApproveRequestFormWithFrame")]
        public IActionResult ApproveRequestFormWithFrame()
        {
            return Json("ApproveRequestFormWithFrame");
        }

        [HttpGet]
        [Route("Finance/Operate/EditDeniedRequestFormPlanViewDate")]
        public IActionResult EditDeniedRequestFormPlanViewDate()
        {
            return Json("EditDeniedRequestFormPlanViewDate");
        }

        [HttpGet]
        [Route("Finance/Operate/EditExtraWithdrawalForm")]
        public IActionResult EditExtraWithdrawalForm()
        {
            return Json("EditExtraWithdrawalForm");
        }

        [HttpGet]
        [Route("Finance/Operate/EditFinancialReimbursementForm")]
        public IActionResult EditFinancialReimbursementForm()
        {
            return Json("EditFinancialReimbursementForm");
        }

        [HttpGet]
        [Route("Finance/Operate/EditGeneralExpenseCancelForm")]
        public IActionResult EditGeneralExpenseCancelForm()
        {
            return Json("EditGeneralExpenseCancelForm");
        }

        [HttpGet]
        [Route("Finance/Operate/EditGeneralExpenseReturnForm")]
        public IActionResult EditGeneralExpenseReturnForm()
        {
            return Json("EditGeneralExpenseReturnForm");
        }

        [HttpGet]
        [Route("Finance/Operate/EditMultiplePaymentRecord")]
        public IActionResult EditMultiplePaymentRecord()
        {
            return Json("EditMultiplePaymentRecord");
        }

        [HttpGet]
        [Route("Finance/Operate/EditPaymentRecord")]
        public IActionResult EditPaymentRecord()
        {
            return Json("EditPaymentRecord");
        }

        [HttpGet]
        [Route("Finance/Operate/EditPlanStatementTemporaryInvolveList")]
        public IActionResult EditPlanStatementTemporaryInvolveList()
        {
            return Json("EditPlanStatementTemporaryInvolveList");
        }

        [HttpGet]
        [Route("Finance/Operate/EditProcureLoaningCancelForm")]
        public IActionResult EditProcureLoaningCancelForm()
        {
            return Json("EditProcureLoaningCancelForm");
        }

        [HttpGet]
        [Route("Finance/Operate/EditProcureLoaningMemoForm")]
        public IActionResult EditProcureLoaningMemoForm()
        {
            return Json("EditProcureLoaningMemoForm");
        }

        [HttpGet]
        [Route("Finance/Operate/EditProcureLoaningMultiplePaymentRecord")]
        public IActionResult EditProcureLoaningMultiplePaymentRecord()
        {
            return Json("EditProcureLoaningMultiplePaymentRecord");
        }

        [HttpGet]
        [Route("Finance/Operate/EditProcureLoaningReturnForm")]
        public IActionResult EditProcureLoaningReturnForm()
        {
            return Json("EditProcureLoaningReturnForm");
        }


        [HttpGet]
        [Route("Finance/Operate/EditProcureLoaningWithdrawalForm")]
        public IActionResult EditProcureLoaningWithdrawalForm()
        {
            return Json("EditProcureLoaningWithdrawalForm");
        }

        [HttpGet]
        [Route("Finance/Operate/EditProcurePaymentRecord")]
        public IActionResult EditProcurePaymentRecord()
        {
            return Json("EditProcurePaymentRecord");
        }

        [HttpGet]
        [Route("Finance/Operate/EditProcureReimbursementMemoForm")]
        public IActionResult EditProcureReimbursementMemoForm()
        {
            return Json("EditProcureReimbursementMemoForm");
        }


        [HttpGet]
        [Route("Finance/Operate/EditProcureSettleMemoForm")]
        public IActionResult EditProcureSettleMemoForm()
        {
            return Json("EditProcureSettleMemoForm");
        }


        [HttpGet]
        [Route("Finance/Operate/EditProcureSettleReceiptForm")]
        public IActionResult EditProcureSettleReceiptForm()
        {
            return Json("EditProcureSettleReceiptForm");
        }


        [HttpGet]
        [Route("Finance/Operate/EditProtectBudget")]
        public IActionResult EditProtectBudget()
        {
            return Json("EditProtectBudget");
        }

        [HttpGet]
        [Route("Finance/Operate/EditReserveBudgetByForm")]
        public IActionResult EditReserveBudgetByForm()
        {
            return Json("EditReserveBudgetByForm");
        }

        [HttpGet]
        [Route("Finance/Operate/EditReserveBudgetFormMonthlyReason")]
        public IActionResult EditReserveBudgetFormMonthlyReason()
        {
            return Json("EditReserveBudgetFormMonthlyReason");
        }

        [HttpGet]
        [Route("Finance/Operate/EditReturnBudgetDateFromApproveForm")]
        public IActionResult EditReturnBudgetDateFromApproveForm()
        {
            return Json("EditReturnBudgetDateFromApproveForm");
        }

        [HttpGet]
        [Route("Finance/Operate/EditStatementCalculationDateList")]
        public IActionResult EditStatementCalculationDateList()
        {
            return Json("EditStatementCalculationDateList");
        }

        [HttpGet]
        [Route("Finance/Operate/EditTemporaryInvolvePlanStatement")]
        public IActionResult EditTemporaryInvolvePlanStatement()
        {
            return Json("EditTemporaryInvolvePlanStatement");
        }

        [HttpGet]
        [Route("Finance/Operate/EditUndefineReserveBudget")]
        public IActionResult EditUndefineReserveBudget()
        {
            return Json("EditUndefineReserveBudget");
        }

        [HttpGet]
        [Route("Finance/Operate/EditWithdrawalForm")]
        public IActionResult EditWithdrawalForm()
        {
            return Json("EditWithdrawalForm");
        }

        [HttpGet]
        [Route("Finance/Operate/SelectPlanForEditStatementTemporaryInvolveList")]
        public IActionResult SelectPlanForEditStatementTemporaryInvolveList()
        {
            return Json("SelectPlanForEditStatementTemporaryInvolveList");
        }

        [HttpGet]
        [Route("Finance/Operate/SelectPlanForStatementCalculationDateList")]
        public IActionResult SelectPlanForStatementCalculationDateList()
        {
            return Json("SelectPlanForStatementCalculationDateList");
        }

        [HttpGet]
        [Route("Finance/Operate/ViewApproveDocForProcureLoaning")]
        public IActionResult ViewApproveDocForProcureLoaning()
        {
            return Json("ViewApproveDocForProcureLoaning");
        }

        [HttpGet]
        [Route("Finance/Operate/ViewApproveItemsForProcureLoaning")]
        public IActionResult ViewApproveItemsForProcureLoaning()
        {
            return Json("ViewApproveItemsForProcureLoaning");
        }

        [HttpGet]
        [Route("Finance/Operate/ViewFinancialReimbursementFormList")]
        public IActionResult ViewFinancialReimbursementFormList()
        {
            return Json("ViewFinancialReimbursementFormList");
        }

        [HttpGet]
        [Route("Finance/Operate/ViewFormForApprovalByFinance")]
        public IActionResult ViewFormForApprovalByFinance()
        {
            var data = _FinServices.ViewFormForApprovalByFinance();
            return Json(data);
        }

        [HttpPost]
        [Route("Finance/Operate/ViewFormForApprovalByFinanceChecker")]
        public IActionResult ViewFormForApprovalByFinanceChecker(DocumentFormRequest request)
        {
            var data = _FinServices.DocumentForm(request);
            return Json(data);
        }

        [HttpGet]
        [Route("Finance/Operate/ViewFormForApprovalByHeadOfFinance")]
        public IActionResult ViewFormForApprovalByHeadOfFinance()
        {
            var data = _FinServices.ViewFormForApprovalByHeadOfFinance();
            return Json(data);
        }

        [HttpGet]
        [Route("Finance/Operate/ViewFormForApprovalBySecretary")]
        public IActionResult ViewFormForApprovalBySecretary()
        {
            return Json("ViewFormForApprovalBySecretary");
        }

        [HttpGet]
        [Route("Finance/Operate/ViewGEMemoFormListForFinancialReimbursementForm")]
        public IActionResult ViewGEMemoFormListForFinancialReimbursementForm()
        {
            return Json("ViewGEMemoFormListForFinancialReimbursementForm");
        }

        [HttpGet]
        [Route("Finance/Operate/ViewPaymentRecordList")]
        public IActionResult ViewPaymentRecordList()
        {
            return Json("ViewPaymentRecordList");
        }

        [HttpGet]
        [Route("Finance/Operate/ViewPlanStatementTemporaryInvolveList")]
        public IActionResult ViewPlanStatementTemporaryInvolveList()
        {
            return Json("ViewPlanStatementTemporaryInvolveList");
        }

        [HttpGet]
        [Route("Finance/Operate/ViewProcureLoaningFormForSettlement")]
        public IActionResult ViewProcureLoaningFormForSettlement()
        {
            return Json("ViewProcureLoaningFormForSettlement");
        }

        [HttpGet]
        [Route("Finance/Operate/ViewProcureLoaningMemoFormList")]
        public IActionResult ViewProcureLoaningMemoFormList()
        {
            return Json("ViewProcureLoaningMemoFormList");
        }

        [HttpGet]
        [Route("Finance/Operate/ViewProcureLoaningMemoFormListForApproval")]
        public IActionResult ViewProcureLoaningMemoFormListForApproval()
        {
            var data = _FinServices.ViewProcureLoaningMemoFormListForApproval();
            return Json(data);
        }

        [HttpGet]
        [Route("Finance/Operate/ViewProcureLoaningWithdrawalFormForSettle")]
        public IActionResult ViewProcureLoaningWithdrawalFormForSettle()
        {
            return Json("ViewProcureLoaningWithdrawalFormForSettle");
        }

        [HttpGet]
        [Route("Finance/Operate/ViewProcureReimbursementMemoFormList")]
        public IActionResult ViewProcureReimbursementMemoFormList()
        {
            return Json("ViewProcureReimbursementMemoFormList");
        }

        [HttpGet]
        [Route("Finance/Operate/ViewProcureReimbursementMemoFormListForApproval")]
        public IActionResult ViewProcureReimbursementMemoFormListForApproval()
        {
            var data = _FinServices.ViewProcureReimbursementMemoFormListForApproval();
            return Json(data);
        }

        [HttpGet]
        [Route("Finance/Operate/ViewProcureSettleMemoFormList")]
        public IActionResult ViewProcureSettleMemoFormList()
        {
            return Json("ViewProcureSettleMemoFormList");
        }

        [HttpGet]
        [Route("Finance/Operate/ViewProcureSettleMemoFormListForApproval")]
        public IActionResult ViewProcureSettleMemoFormListForApproval()
        {
            var data = _FinServices.ViewProcureSettleMemoFormListForApproval();
            return Json(data);
        }

        [HttpGet]
        [Route("Finance/Operate/ViewProcureSettleReceiptFormList")]
        public IActionResult ViewProcureSettleReceiptFormList()
        {
            return Json("ViewProcureSettleReceiptFormList");
        }

        [HttpGet]
        [Route("Finance/Operate/ViewProcureSettleReceiptFormListForApproval")]
        public IActionResult ViewProcureSettleReceiptFormListForApproval()
        {
            var data = _FinServices.ViewProcureSettleReceiptFormListForApproval();
            return Json(data);
        }
        [HttpPost]
        [Route("Finance/Operate/ViewRequestFormList")]
        public IActionResult ViewRequestFormList(ViewRequestFormListMainRequest request)
        {
            var data = _FinServices.ViewRequestFormList(request);
            return Json(data);
        }

        [HttpPost]
        [Route("Finance/Operate/ViewRequestFormListForFinancialApproval")]
        public IActionResult ViewRequestFormListForFinancialApproval(ViewRequestFormListRequest request)
        {
            var data = _FinServices.ViewRequestFormListForFinancialApproval(request);
            return Json(data);
        }

        [HttpGet]
        [Route("Finance/Operate/ViewReserveBudgetFormList")]
        public IActionResult ViewReserveBudgetFormList()
        {
            return Json("ViewReserveBudgetFormList");
        }

        [HttpGet]
        [Route("Finance/Operate/ViewUndefineReserveBudgetList")]
        public IActionResult ViewUndefineReserveBudgetList()
        {
            return Json("ViewUndefineReserveBudgetList");
        }
        #endregion

        [HttpGet]
        [Route("Finance/Report/FinanceFormReportStream")]
        public IActionResult FinanceFormReportStream()
        {
            return Json("FinanceFormReportStream");
        }

        [HttpGet]
        [Route("Finance/Report/FinanceFormReportViewer")]
        public IActionResult FinanceFormReportViewer()
        {
            return Json("FinanceFormReportViewer");
        }

        [HttpGet]
        [Route("Finance/Report/FinancialReserveStatementMonthlyBriefReportByBudgetType")]
        public IActionResult FinancialReserveStatementMonthlyBriefReportByBudgetType()
        {
            return Json("FinancialReserveStatementMonthlyBriefReportByBudgetType");
        }

        [HttpGet]
        [Route("Finance/Report/FinancialReserveStatementMonthlyReportByBudgetType")]
        public IActionResult FinancialReserveStatementMonthlyReportByBudgetType()
        {
            return Json("FinancialReserveStatementMonthlyReportByBudgetType");
        }

        [HttpGet]
        [Route("Finance/Report/FinancialReserveStatementMonthlyReportByPlanCore")]
        public IActionResult FinancialReserveStatementMonthlyReportByPlanCore()
        {
            return Json("FinancialReserveStatementMonthlyReportByPlanCore");
        }

        [HttpGet]
        [Route("Finance/Report/FinancialReserveStatementMonthlyReportByPlanType")]
        public IActionResult FinancialReserveStatementMonthlyReportByPlanType()
        {
            return Json("FinancialReserveStatementMonthlyReportByPlanType");
        }

        [HttpGet]
        [Route("Finance/Report/FinancialReserveStatementYearEndBriefReportByBudgetType")]
        public IActionResult FinancialReserveStatementYearEndBriefReportByBudgetType()
        {
            return Json("FinancialReserveStatementYearEndBriefReportByBudgetType");
        }

        [HttpGet]
        [Route("Finance/Report/FinancialReserveStatementYearEndReportByBudgetType")]
        public IActionResult FinancialReserveStatementYearEndReportByBudgetType()
        {
            return Json("FinancialReserveStatementYearEndReportByBudgetType");
        }

        [HttpGet]
        [Route("Finance/Report/FinancialReserveStatementYearEndReportByPlanCore")]
        public IActionResult FinancialReserveStatementYearEndReportByPlanCore()
        {
            return Json("FinancialReserveStatementYearEndReportByPlanCore");
        }

        [HttpGet]
        [Route("Finance/Report/FinancialReserveStatementYearEndReportByPlanType")]
        public IActionResult FinancialReserveStatementYearEndReportByPlanType()
        {
            return Json("FinancialReserveStatementYearEndReportByPlanType");
        }

        [HttpGet]
        [Route("Finance/Report/FinancialStatementReportByPlanActivity")]
        public IActionResult FinancialStatementReportByPlanActivity()
        {
            return Json("FinancialStatementReportByPlanActivity");
        }

        [HttpGet]
        [Route("Finance/Report/FinancialStatementReportByPlanCore")]
        public IActionResult FinancialStatementReportByPlanCore()
        {
            return Json("FinancialStatementReportByPlanCore");
        }

        [HttpGet]
        [Route("Finance/Report/FinancialStatementReportByPlanItem")]
        public IActionResult FinancialStatementReportByPlanItem()
        {
            return Json("FinancialStatementReportByPlanItem");
        }

        [HttpGet]
        [Route("Finance/Report/FinancialUserNotificationMailReport")]
        public IActionResult FinancialUserNotificationMailReport()
        {
            return Json("FinancialUserNotificationMailReport");
        }

        [HttpGet]
        [Route("Finance/Report/GroupSelectorForFinancialStatementReport")]
        public IActionResult GroupSelectorForFinancialStatementReport()
        {
            return Json("GroupSelectorForFinancialStatementReport");
        }

        [HttpGet]
        [Route("Finance/Report/PlanCoreFinancialByQuarterReport")]
        public IActionResult PlanCoreFinancialByQuarterReport()
        {
            return Json("PlanCoreFinancialByQuarterReport");
        }

        [HttpGet]
        [Route("Finance/Report/PlanCoreListFinancialStatementReport")]
        public IActionResult PlanCoreListFinancialStatementReport()
        {
            return Json("PlanCoreListFinancialStatementReport");
        }

        [HttpPost]
        [Route("Finance/Report/PlanFormFinancialStatusReport")]
        public IActionResult PlanFormFinancialStatusReport(PlanFormFinancialStatusReportRequest request)
        {
            var data = _FinServices.PlanFormFinancialStatusReport(request);
            return Json(data);
        }

        [HttpGet]
        [Route("Finance/Report/ReserveBudgetForecastReport")]
        public IActionResult ReserveBudgetForecastReport()
        {
            return Json("ReserveBudgetForecastReport");
        }

        [HttpGet]
        [Route("/FIN/Procure/Setup/SetRegisterProcureItemType/getAllRegis")]
        public IActionResult getAllRegis()
        {
            var data = _FinServices.getAllRegis();
            return Json(data);
        }

        [HttpPost]
        [Route("/FIN/Procure/Setup/SetRegisterProcureItemType")]
        public IActionResult ProcureItemTypeSetup(ProcureItemTypeRequest request)
        {
            var data = _FinServices.ProcureItemTypeSetup(request);
            return Json(data);
        }

        [HttpPost]
        [Route("/FIN/Procure/Setup/SetupSupplierDetail")]
        public IActionResult SupplierDetailSetup(SupplierRequest request)
        {
            var data = _FinServices.SupplierDetailSetup(request);
            return Json(data);
        }

        [HttpPost]
        [Route("/FIN/Procure/Setup/ProcureStoreLocationSetup")]
        public IActionResult ProcureStoreLocationSetup(ProcureStoreLocationRequest request)
        {
            var data = _FinServices.ProcureStoreLocationSetup(request);
            return Json(data);
        }
        //[HttpGet]
        //[Route("/FIN/Procure/Setup/SetRegisterProcureItemType/GetById/{Id}")]
        //public IActionResult getById(int Id)
        //{

        //    var data = _FinServices.getById(Id);

        //    return Json(data);
        //}

        [HttpGet]
        [Route("/FIN/Procure/Setup/ViewSupplierListForSetup/getAllSupplier")]
        public IActionResult getAllSupplier()
        {
            var data = _FinServices.getAllSupplier();
            return Json(data);
        }

        [HttpGet]
        [Route("/FIN/Procure/Setup/ViewSupplierListForSetup/getSupplierbyName")]
        public IActionResult getSupplierbyName(string name)
        {
            var data = _FinServices.getSupplierbyName(name);
            return Json(data);
        }

        [HttpGet]
        [Route("/FIN/Procure/Setup/ProcureStoreLocationSetup/getAllStoreLocation")]
        public IActionResult getAllStoreLocation()
        {
            var data = _FinServices.getAllStoreLocation();
            return Json(data);
        }

        [HttpGet]
        [Route("/FIN/Procure/Report/RegisterProcureItemSearch/{checkBox}/{fiscalYear}/{departmentId}")]
        public IActionResult RegisterProcureItemSearch(int checkBox, int fiscalYear, int departmentId)
        {
            var data = _FinServices.RegisterProcureItemSearch(checkBox, fiscalYear, departmentId);
            return Json(data);
        }

        [HttpGet]
        [Route("/FIN/Procure/Report/ShowRegisterProcureItemListByDepartment/{checkBox}/{fiscalYear}/{departmentId}")]
        public IActionResult ShowRegisterProcureItemListByDepartment(int checkBox, int fiscalYear, int departmentId)
        {
            var data = _FinServices.ShowRegisterProcureItemListByDepartment(checkBox, fiscalYear, departmentId);
            return Json(data);
        }

        [HttpGet]
        [Route("/FIN/Procure/Report/SearchProcureDocForTrackingRoute/{document}/{fiscalYear}")]
        public IActionResult SearchProcureDocForTrackingRoute(int document, string documentNumber, int fiscalYear)
        {
            var data = _FinServices.SearchProcureDocForTrackingRoute(document, documentNumber, fiscalYear);
            return Json(data);
        }
    }
}
