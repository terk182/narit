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
using narit_mis_api.Models;
using System;
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
        


        #region HR 
        
        [HttpGet]
        [Route("/HR/MainHRPage")]
        public IActionResult MainHRPage()
        {
            return Json("MainHRPage");
        }

        #endregion

        #region HR Operate
        [HttpGet]
        [Route("/HR/Operate/ApproveWorkShiftExtraAllowancePage")]
        public IActionResult ApproveWorkShiftExtraAllowancePage()
        {
            return Json("ApproveWorkShiftExtraAllowancePage");
        }



        [HttpGet]
        [Route("/HR/Operate/AutoAdjustDailyAttendance")]
        public IActionResult AutoAdjustDailyAttendance()
        {
            return Json("AutoAdjustDailyAttendance");
        }


        [HttpGet]
        [Route("/HR/Operate/EditCompetencyEvaluationForm")]
        public IActionResult EditCompetencyEvaluationForm()
        {
            return Json("EditCompetencyEvaluationForm");
        }


        [HttpGet]
        [Route("/HR/Operate/EditContractEndEvaluationForm")]
        public IActionResult EditContractEndEvaluationForm()
        {
            return Json("EditContractEndEvaluationForm");
        }



        [HttpGet]
        [Route("/HR/Operate/EditDailyAttendance")]
        public IActionResult EditDailyAttendance()
        {
            return Json("EditDailyAttendance");
        }


        [HttpGet]
        [Route("/HR/Operate/EditDailyAttendanceListview")]
        public IActionResult EditDailyAttendanceListview()
        {
            return Json("EditDailyAttendanceListview");
        }


        [HttpGet]
        [Route("/HR/Operate/EditDailyAttendanceRequestForm")]
        public IActionResult EditDailyAttendanceRequestForm()
        {
            return Json("EditDailyAttendanceRequestForm");
        }


        [HttpGet]
        [Route("/HR/Operate/EditDevelopmentGroupCancellationForm")]
        public IActionResult EditDevelopmentGroupCancellationForm()
        {
            return Json("EditDevelopmentGroupCancellationForm");
        }



        [HttpGet]
        [Route("/HR/Operate/EditDevelopmentGroupForm")]
        public IActionResult EditDevelopmentGroupForm()
        {
            return Json("EditDevelopmentGroupForm");
        }


        [HttpGet]
        [Route("/HR/Operate/EditDevelopmentRecordFollowUpForm")]
        public IActionResult EditDevelopmentRecordFollowUpForm()
        {
            return Json("EditDevelopmentRecordFollowUpForm");
        }


        [HttpGet]
        [Route("/HR/Operate/EditEmploymentContract")]
        public IActionResult EditEmploymentContract()
        {
            return Json("EditEmploymentContract");
        }


        [HttpGet]
        [Route("/HR/Operate/EditGroupStaffWorkShift")]
        public IActionResult EditGroupStaffWorkShift()
        {
            return Json("EditGroupStaffWorkShift");
        }


        [HttpGet]
        [Route("/HR/Operate/EditJobDescription")]
        public IActionResult EditJobDescription()
        {
            return Json("EditJobDescription");
        }


        [HttpGet]
        [Route("/HR/Operate/EditJobPositionDetail")]
        public IActionResult EditJobPositionDetail()
        {
            return Json("EditJobPositionDetail");
        }



        [HttpGet]
        [Route("/HR/Operate/EditJobResponsibilityEvaluationForm")]
        public IActionResult EditJobResponsibilityEvaluationForm()
        {
            return Json("EditJobResponsibilityEvaluationForm");
        }



        [HttpGet]
        [Route("/HR/Operate/EditLeaveCancellationForm")]
        public IActionResult EditLeaveCancellationForm()
        {
            return Json("EditLeaveCancellationForm");
        }



        [HttpGet]
        [Route("/HR/Operate/EditLeaveForm")]
        public IActionResult EditLeaveForm()
        {
            return Json("EditLeaveForm");
        }


        [HttpGet]
        [Route("/HR/Operate/EditMedicalReimbursementForm")]
        public IActionResult EditMedicalReimbursementForm()
        {
            return Json("EditMedicalReimbursementForm");
        }



        [HttpGet]
        [Route("/HR/Operate/EditOutsideDutyGroup")]
        public IActionResult EditOutsideDutyGroup()
        {
            return Json("EditOutsideDutyGroup");
        }



        [HttpGet]
        [Route("/HR/Operate/EditOutsideDutyGroupCancellationForm")]
        public IActionResult EditOutsideDutyGroupCancellationForm()
        {
            return Json("EditOutsideDutyGroupCancellationForm");
        }


        [HttpGet]
        [Route("/HR/Operate/EditOverTimeRequestForm")]
        public IActionResult EditOverTimeRequestForm()
        {
            return Json("EditOverTimeRequestForm");
        }



        [HttpGet]
        [Route("/HR/Operate/EditOverTimeRequestFormGroup")]
        public IActionResult EditOverTimeRequestFormGroup()
        {
            return Json("EditOverTimeRequestFormGroup");
        }

        [HttpGet]
        [Route("/HR/Operate/EditOverTimeRequestResultFormGroup")]
        public IActionResult EditOverTimeRequestResultFormGroup()
        {
            return Json("EditOverTimeRequestResultFormGroup");
        }



        [HttpGet]
        [Route("/HR/Operate/EditPerformanceYearlyEvaluationForm")]
        public IActionResult EditPerformanceYearlyEvaluationForm()
        {
            return Json("EditPerformanceYearlyEvaluationForm");
        }



        [HttpGet]
        [Route("/HR/Operate/EditPostDevelopmentRecordEvaluationForm")]
        public IActionResult EditPostDevelopmentRecordEvaluationForm()
        {
            return Json("EditPostDevelopmentRecordEvaluationForm");
        }



        [HttpGet]
        [Route("/HR/Operate/EditProbationEvaluationForm")]
        public IActionResult EditProbationEvaluationForm()
        {
            return Json("EditProbationEvaluationForm");
        }


        [HttpGet]
        [Route("/HR/Operate/EditSecondment")]
        public IActionResult EditSecondment()
        {
            return Json("EditSecondment");
        }



        [HttpGet]
        [Route("/HR/Operate/EditStaffAbilityInformation")]
        public IActionResult EditStaffAbilityInformation()
        {
            return Json("EditStaffAbilityInformation");
        }



        [HttpGet]
        [Route("/HR/Operate/EditStaffAddressInformation")]
        public IActionResult EditStaffAddressInformation()
        {
            return Json("EditStaffAddressInformation");
        }



        [HttpGet]
        [Route("/HR/Operate/EditStaffData")]
        public IActionResult EditStaffData()
        {
            return Json("EditStaffData");
        }



        [HttpGet]
        [Route("/HR/Operate/EditStaffEducationInformation")]
        public IActionResult EditStaffEducationInformation()
        {
            return Json("EditStaffEducationInformation");
        }


        [HttpGet]
        [Route("/HR/Operate/EditStaffFamilyInformation")]
        public IActionResult EditStaffFamilyInformation()
        {
            return Json("EditStaffFamilyInformation");
        }


        [HttpGet]
        [Route("/HR/Operate/EditStaffInformation")]
        public IActionResult EditStaffInformation()
        {
            return Json("EditStaffInformation");
        }



        [HttpGet]
        [Route("/HR/Operate/EditStaffInsigniaInformation")]
        public IActionResult EditStaffInsigniaInformation()
        {
            return Json("EditStaffInsigniaInformation");
        }


        [HttpGet]
        [Route("/HR/Operate/EditStaffPastDevelopment")]
        public IActionResult EditStaffPastDevelopment()
        {
            return Json("EditStaffPastDevelopment");
        }


        [HttpGet]
        [Route("/HR/Operate/EditStaffSalaryList")]
        public IActionResult EditStaffSalaryList()
        {
            return Json("EditStaffSalaryList");
        }



        [HttpGet]
        [Route("/HR/Operate/EditStaffWorkHistory")]
        public IActionResult EditStaffWorkHistory()
        {
            return Json("EditStaffWorkHistory");
        }



        [HttpGet]
        [Route("/HR/Operate/EditStaffWorkShift")]
        public IActionResult EditStaffWorkShift()
        {
            return Json("EditStaffWorkShift");
        }



        [HttpGet]
        [Route("/HR/Operate/EditStaffWorkShiftByTablix")]
        public IActionResult EditStaffWorkShiftByTablix()
        {
            return Json("EditStaffWorkShiftByTablix");
        }



        [HttpGet]
        [Route("/HR/Operate/EditSyllabus")]
        public IActionResult EditSyllabus()
        {
            return Json("EditSyllabus");
        }



        [HttpGet]
        [Route("/HR/Operate/EditWorkShiftSwitchForm")]
        public IActionResult EditWorkShiftSwitchForm()
        {
            return Json("EditWorkShiftSwitchForm");
        }


        [HttpGet]
        [Route("/HR/Operate/GenericStaffInfoNestedMasterPage")]
        public IActionResult GenericStaffInfoNestedMasterPage()
        {
            return Json("GenericStaffInfoNestedMasterPage");
        }



        [HttpGet]
        [Route("/HR/Operate/HolidaySetup")]
        public IActionResult HolidaySetup()
        {
            return Json("HolidaySetup");
        }



        [HttpGet]
        [Route("/HR/Operate/HRDownloadFile")]
        public IActionResult HRDownloadFile()
        {
            return Json("HRDownloadFile");
        }


        [HttpGet]
        [Route("/HR/Operate/HRSecureCodeForm")]
        public IActionResult HRSecureCodeForm()
        {
            return Json("HRSecureCodeForm");
        }


        [HttpGet]
        [Route("/HR/Operate/HRSecureCodeForm_ApprovedDoc")]
        public IActionResult HRSecureCodeForm_ApprovedDoc()
        {
            return Json("HRSecureCodeForm_ApprovedDoc");
        }



        [HttpGet]
        [Route("/HR/Operate/ManualAdjustDailyAttendance")]
        public IActionResult ManualAdjustDailyAttendance()
        {
            return Json("ManualAdjustDailyAttendance");
        }



        [HttpGet]
        [Route("/HR/Operate/ManualAdjustOverTimeResult")]
        public IActionResult ManualAdjustOverTimeResult()
        {
            return Json("ManualAdjustOverTimeResult");
        }


        [HttpGet]
        [Route("/HR/Operate/MedicalReimbursementRightCheck")]
        public IActionResult MedicalReimbursementRightCheck()
        {
            return Json("MedicalReimbursementRightCheck");
        }



        [HttpGet]
        [Route("/HR/Operate/SelectMultipleStaffList")]
        public IActionResult SelectMultipleStaffList()
        {
            return Json("SelectMultipleStaffList");
        }



        [HttpGet]
        [Route("/HR/Operate/SpecificFingerPrintDBReaderPage")]
        public IActionResult SpecificFingerPrintDBReaderPage()
        {
            return Json("SpecificFingerPrintDBReaderPage");
        }


        [HttpGet]
        [Route("/HR/Operate/ViewDailyAttendanceRequestFormList")]
        public IActionResult ViewDailyAttendanceRequestFormList()
        {
            return Json("ViewDailyAttendanceRequestFormList");
        }


        [HttpGet]
        [Route("/HR/Operate/ViewDevelopmentGroupListForCancellation")]
        public IActionResult ViewDevelopmentGroupListForCancellation()
        {
            return Json("ViewDevelopmentGroupListForCancellation");
        }



        [HttpGet]
        [Route("/HR/Operate/ViewDevelopmentRecordGroupCostList")]
        public IActionResult ViewDevelopmentRecordGroupCostList()
        {
            return Json("ViewDevelopmentRecordGroupCostList");
        }



        [HttpGet]
        [Route("/HR/Operate/ViewDevelopmentRecordGroupList")]
        public IActionResult ViewDevelopmentRecordGroupList()
        {
            return Json("ViewDevelopmentRecordGroupList");
        }


        [HttpGet]
        [Route("/HR/Operate/ViewEmploymentContractList")]
        public IActionResult ViewEmploymentContractList()
        {
            return Json("ViewEmploymentContractList");
        }


        [HttpGet]
        [Route("/HR/Operate/ViewFormForApprovalByHR")]
        public IActionResult ViewFormForApprovalByHR()
        {
            return Json("ViewFormForApprovalByHR");
        }



        [HttpGet]
        [Route("/HR/Operate/ViewHolidayList")]
        public IActionResult ViewHolidayList()
        {
            return Json("ViewHolidayList");
        }



        [HttpGet]
        [Route("/HR/Operate/ViewHREvaluationFormForApprove")]
        public IActionResult ViewHREvaluationFormForApprove()
        {
            return Json("ViewHREvaluationFormForApprove");
        }



        [HttpGet]
        [Route("/HR/Operate/ViewHREvaluationFormList")]
        public IActionResult ViewHREvaluationFormList()
        {
            return Json("ViewHREvaluationFormList");
        }



        [HttpGet]
        [Route("/HR/Operate/ViewHRFormForApprove")]
        public IActionResult ViewHRFormForApprove()
        {
            return Json("ViewHRFormForApprove");
        }



        [HttpGet]
        [Route("/HR/Operate/ViewHRFormForApproveByUnitChief")]
        public IActionResult ViewHRFormForApproveByUnitChief()
        {
            return Json("ViewHRFormForApproveByUnitChief");
        }


        [HttpGet]
        [Route("/HR/Operate/ViewIndividualAddressList")]
        public IActionResult ViewIndividualAddressList()
        {
            return Json("ViewIndividualAddressList");
        }



        [HttpGet]
        [Route("/HR/Operate/ViewIndividualDevelopmentList")]
        public IActionResult ViewIndividualDevelopmentList()
        {
            return Json("ViewIndividualDevelopmentList");
        }



        [HttpGet]
        [Route("/HR/Operate/ViewIndividualEducationList")]
        public IActionResult ViewIndividualEducationList()
        {
            return Json("ViewIndividualEducationList");
        }



        [HttpGet]
        [Route("/HR/Operate/ViewIndividualFamilyList")]
        public IActionResult ViewIndividualFamilyList()
        {
            return Json("ViewIndividualFamilyList");
        }



        [HttpGet]
        [Route("/HR/Operate/ViewIndividualInsigniaList")]
        public IActionResult ViewIndividualInsigniaList()
        {
            return Json("ViewIndividualInsigniaList");
        }



        [HttpGet]
        [Route("/HR/Operate/ViewIndividualPastDevelopmentList")]
        public IActionResult ViewIndividualPastDevelopmentList()
        {
            return Json("ViewIndividualPastDevelopmentList");
        }



        [HttpGet]
        [Route("/HR/Operate/ViewIndividualStaffWorkShift")]
        public IActionResult ViewIndividualStaffWorkShift()
        {
            return Json("ViewIndividualStaffWorkShift");
        }



        [HttpGet]
        [Route("/HR/Operate/ViewIndividualWorkAttendanceList")]
        public IActionResult ViewIndividualWorkAttendanceList()
        {
            return Json("ViewIndividualWorkAttendanceList");
        }



        [HttpGet]
        [Route("/HR/Operate/ViewIndividualWorkHistoryList")]
        public IActionResult ViewIndividualWorkHistoryList()
        {
            return Json("ViewIndividualWorkHistoryList");
        }


        [HttpGet]
        [Route("/HR/Operate/ViewJobDescriptionList")]
        public IActionResult ViewJobDescriptionList()
        {
            return Json("ViewJobDescriptionList");
        }



        [HttpGet]
        [Route("/HR/Operate/ViewJobPositionList")]
        public IActionResult ViewJobPositionList()
        {
            return Json("ViewJobPositionList");
        }



        [HttpGet]
        [Route("/HR/Operate/ViewLeaveCancellationFormList")]
        public IActionResult ViewLeaveCancellationFormList()
        {
            return Json("ViewLeaveCancellationFormList");
        }


        [HttpGet]
        [Route("/HR/Operate/ViewLeaveList")]
        public IActionResult ViewLeaveList()
        {
            return Json("ViewLeaveList");
        }



        [HttpGet]
        [Route("/HR/Operate/ViewLeaveListForCancellation")]
        public IActionResult ViewLeaveListForCancellation()
        {
            return Json("ViewLeaveListForCancellation");
        }


        [HttpGet]
        [Route("/HR/Operate/ViewMedicalReimbursementList")]
        public IActionResult ViewMedicalReimbursementList()
        {
            return Json("ViewMedicalReimbursementList");
        }



        [HttpGet]
        [Route("/HR/Operate/ViewOutsideDutyGroupList")]
        public IActionResult ViewOutsideDutyGroupList()
        {
            return Json("ViewOutsideDutyGroupList");
        }



        [HttpGet]
        [Route("/HR/Operate/ViewOutsideDutyGroupListForCancellation")]
        public IActionResult ViewOutsideDutyGroupListForCancellation()
        {
            return Json("ViewOutsideDutyGroupListForCancellation");
        }



        [HttpGet]
        [Route("/HR/Operate/ViewOverTimeRequestFormList")]
        public IActionResult ViewOverTimeRequestFormList()
        {
            return Json("ViewOverTimeRequestFormList");
        }


        [HttpGet]
        [Route("/HR/Operate/ViewPlanItemSelectionForHRForm")]
        public IActionResult ViewPlanItemSelectionForHRForm()
        {
            return Json("ViewPlanItemSelectionForHRForm");
        }



        [HttpGet]
        [Route("/HR/Operate/ViewSecondmentList")]
        public IActionResult ViewSecondmentList()
        {
            return Json("ViewSecondmentList");
        }



        [HttpGet]
        [Route("/HR/Operate/ViewStaffAddressesList")]
        public IActionResult ViewStaffAddressesList()
        {
            return Json("ViewStaffAddressesList");
        }



        [HttpGet]
        [Route("/HR/Operate/ViewStaffAndRelativeForMedicalReimbursement")]
        public IActionResult ViewStaffAndRelativeForMedicalReimbursement()
        {
            return Json("ViewStaffAndRelativeForMedicalReimbursement");
        }



        [HttpGet]
        [Route("/HR/Operate/ViewStaffDevelopmentList")]
        public IActionResult ViewStaffDevelopmentList()
        {
            return Json("ViewStaffDevelopmentList");
        }



        [HttpGet]
        [Route("/HR/Operate/ViewStaffEducationList")]
        public IActionResult ViewStaffEducationList()
        {
            return Json("ViewStaffEducationList");
        }



        [HttpGet]
        [Route("/HR/Operate/ViewStaffFamilyList")]
        public IActionResult ViewStaffFamilyList()
        {
            return Json("ViewStaffFamilyList");
        }


        [HttpGet]
        [Route("/HR/Operate/ViewStaffInformationList")]
        public IActionResult ViewStaffInformationList()
        {
            return Json("ViewStaffInformationList");
        }


        [HttpGet]
        [Route("/HR/Operate/ViewStaffInsigniaList")]
        public IActionResult ViewStaffInsigniaList()
        {
            return Json("ViewStaffInsigniaList");
        }



        [HttpGet]
        [Route("/HR/Operate/ViewStaffList")]
        public IActionResult ViewStaffList()
        {
            return Json("ViewStaffList");
        }


      

        [HttpGet]
        [Route("/HR/Operate/ViewStaffPastDevelopmentList")]
        public IActionResult ViewStaffPastDevelopmentList()
        {
            return Json("ViewStaffPastDevelopmentList");
        }



        [HttpGet]
        [Route("/HR/Operate/ViewStaffWorkAttendanceList")]
        public IActionResult ViewStaffWorkAttendanceList()
        {
            return Json("ViewStaffWorkAttendanceList");
        }


        [HttpGet]
        [Route("/HR/Operate/ViewStaffWorkHistoryList")]
        public IActionResult ViewStaffWorkHistoryList()
        {
            return Json("ViewStaffWorkHistoryList");
        }


        [HttpGet]
        [Route("/HR/Operate/ViewStaffWorkShiftList")]
        public IActionResult ViewStaffWorkShiftList()
        {
            return Json("ViewStaffWorkShiftList");
        }



        [HttpGet]
        [Route("/HR/Operate/ViewSyllabusesList")]
        public IActionResult ViewSyllabusesList()
        {
            return Json("ViewSyllabusesList");
        }



        [HttpGet]
        [Route("/HR/Operate/ViewWorkShiftSwitchFormList")]
        public IActionResult ViewWorkShiftSwitchFormList()
        {
            return Json("ViewWorkShiftSwitchFormList");
        }




        #endregion



        #region HR report
        [HttpGet]
        [Route("/HR/Report/AddressReport")]
        public IActionResult AddressReport()
        {
            return Json("AddressReport");
        }


        [HttpGet]
        [Route("/HR/Report/BasicStaffInformationReport")]
        public IActionResult BasicStaffInformationReport()
        {
            return Json("BasicStaffInformationReport");
        }



        [HttpGet]
        [Route("/HR/Report/DailyAttendanceMonthlyReport")]
        public IActionResult DailyAttendanceMonthlyReport()
        {
            return Json("DailyAttendanceMonthlyReport");
        }



        [HttpGet]
        [Route("/HR/Report/DevelopmentRecordReport")]
        public IActionResult DevelopmentRecordReport()
        {
            return Json("DevelopmentRecordReport");
        }


        [HttpGet]
        [Route("/HR/Report/EducationRecordReport")]
        public IActionResult EducationRecordReport()
        {
            return Json("EducationRecordReport");
        }


        [HttpGet]
        [Route("/HR/Report/FingerPrintDBReaderResultReport")]
        public IActionResult FingerPrintDBReaderResultReport()
        {
            return Json("FingerPrintDBReaderResultReport");
        }



        [HttpGet]
        [Route("/HR/Report/HREvaluationResultReport")]
        public IActionResult HREvaluationResultReport()
        {
            return Json("HREvaluationResultReport");
        }


        [HttpGet]
        [Route("/HR/Report/HRFormReportViewer")]
        public IActionResult HRFormReportViewer()
        {
            return Json("HRFormReportViewer");
        }



        [HttpGet]
        [Route("/HR/Report/HRReportStream")]
        public IActionResult HRReportStream()
        {
            return Json("HRReportStream");
        }


        [HttpGet]
        [Route("/HR/Report/IndividualGeneralHRDataReport")]
        public IActionResult IndividualGeneralHRDataReport()
        {
            return Json("IndividualGeneralHRDataReport");
        }



        [HttpGet]
        [Route("/HR/Report/IndividualMonthlyWorkAttendanceReport")]
        public IActionResult IndividualMonthlyWorkAttendanceReport()
        {
            return Json("IndividualMonthlyWorkAttendanceReport");
        }



        [HttpGet]
        [Route("/HR/Report/InsigniaReportByRank")]
        public IActionResult InsigniaReportByRank()
        {
            return Json("InsigniaReportByRank");
        }



        [HttpGet]
        [Route("/HR/Report/LeaveReport")]
        public IActionResult LeaveReport()
        {
            return Json("LeaveReport");
        }



        [HttpGet]
        [Route("/HR/Report/ManpowerByDepartment")]
        public IActionResult ManpowerByDepartment()
        {
            return Json("ManpowerByDepartment");
        }



        [HttpGet]
        [Route("/HR/Report/ManpowerMonthlyReport")]
        public IActionResult ManpowerMonthlyReport()
        {
            return Json("ManpowerMonthlyReport");
        }



        [HttpGet]
        [Route("/HR/Report/MedicalReimbursementSendPaymentReport")]
        public IActionResult MedicalReimbursementSendPaymentReport()
        {
            return Json("MedicalReimbursementSendPaymentReport");
        }



        [HttpGet]
        [Route("/HR/Report/OutsideDutyGroupReport")]
        public IActionResult OutsideDutyGroupReport()
        {
            return Json("OutsideDutyGroupReport");
        }



        [HttpGet]
        [Route("/HR/Report/OverTimeReportByMonth")]
        public IActionResult OverTimeReportByMonth()
        {
            return Json("OverTimeReportByMonth");
        }



        [HttpGet]
        [Route("/HR/Report/OverTimeResultReport")]
        public IActionResult OverTimeResultReport()
        {
            return Json("OverTimeResultReport");
        }



        [HttpGet]
        [Route("/HR/Report/OverTimeResultReportList")]
        public IActionResult OverTimeResultReportList()
        {
            return Json("OverTimeResultReportList");
        }



        [HttpGet]
        [Route("/HR/Report/OverTimeSummarizeReport")]
        public IActionResult OverTimeSummarizeReport()
        {
            return Json("OverTimeSummarizeReport");
        }



        [HttpGet]
        [Route("/HR/Report/PeriodWorkAttendanceReport")]
        public IActionResult PeriodWorkAttendanceReport()
        {
            return Json("PeriodWorkAttendanceReport");
        }



        [HttpGet]
        [Route("/HR/Report/PeriodWorkAttendanceReportByTime")]
        public IActionResult PeriodWorkAttendanceReportByTime()
        {
            return Json("PeriodWorkAttendanceReportByTime");
        }



        [HttpGet]
        [Route("/HR/Report/RemainLeaveDayReport")]
        public IActionResult RemainLeaveDayReport()
        {
            return Json("RemainLeaveDayReport");
        }



        [HttpGet]
        [Route("/HR/Report/SecondmentReport")]
        public IActionResult SecondmentReport()
        {
            return Json("SecondmentReport");
        }



        [HttpGet]
        [Route("/HR/Report/StaffByDepartmentReport")]
        public IActionResult StaffByDepartmentReport()
        {
            return Json("StaffByDepartmentReport");
        }



        [HttpGet]
        [Route("/HR/Report/StaffByJobPositionTypeReport")]
        public IActionResult StaffByJobPositionTypeReport()
        {
            return Json("StaffByJobPositionTypeReport");
        }



        [HttpGet]
        [Route("/HR/Report/StaffByPlanCoreReport")]
        public IActionResult StaffByPlanCoreReport()
        {
            return Json("StaffByPlanCoreReport");
        }



        [HttpGet]
        [Route("/HR/Report/StaffResignedReport")]
        public IActionResult StaffResignedReport()
        {
            return Json("StaffResignedReport");
        }



        [HttpGet]
        [Route("/HR/Report/UnsualStaffWorkAttendanceReport")]
        public IActionResult UnsualStaffWorkAttendanceReport()
        {
            return Json("UnsualStaffWorkAttendanceReport");
        }


     

        [HttpGet]
        [Route("/HR/Report/ViewFingerPrintDBRawData")]
        public IActionResult ViewFingerPrintDBRawData()
        {
            return Json("ViewFingerPrintDBRawData");
        }




        [HttpGet]
        [Route("/HR/Report/WorkShiftExtraAllowanceReport")]
        public IActionResult WorkShiftExtraAllowanceReport()
        {
            return Json("WorkShiftExtraAllowanceReport");
        }




        #endregion



        #region HR setup
        [HttpGet]
        [Route("/HR/Setup/AddressStyleSetup")]
        public IActionResult AddressStyleSetup()
        {
            return Json("AddressStyleSetup");
        }


        [HttpGet]
        [Route("/HR/Setup/AddressTypeSetup")]
        public IActionResult AddressTypeSetup()
        {
            return Json("AddressTypeSetup");
        }


        [HttpGet]
        [Route("/HR/Setup/AutoInsertDailyAttendanceSetup")]
        public IActionResult AutoInsertDailyAttendanceSetup()
        {
            return Json("AutoInsertDailyAttendanceSetup");
        }



        [HttpGet]
        [Route("/HR/Setup/CompetencyEvaluationExpectScoreSetup")]
        public IActionResult CompetencyEvaluationExpectScoreSetup()
        {
            return Json("CompetencyEvaluationExpectScoreSetup");
        }



        [HttpGet]
        [Route("/HR/Setup/CompetencyTopicItemSetup")]
        public IActionResult CompetencyTopicItemSetup()
        {
            return Json("CompetencyTopicItemSetup");
        }



        [HttpGet]
        [Route("/HR/Setup/DevelopmentTypeSetup")]
        public IActionResult DevelopmentTypeSetup()
        {
            return Json("DevelopmentTypeSetup");
        }



        [HttpGet]
        [Route("/HR/Setup/EducationLevelSetup")]
        public IActionResult EducationLevelSetup()
        {
            return Json("EducationLevelSetup");
        }



        [HttpGet]
        [Route("/HR/Setup/EvaluatorSetup")]
        public IActionResult EvaluatorSetup()
        {
            return Json("EvaluatorSetup");
        }


        [HttpGet]
        [Route("/HR/Setup/FamilialRelationshipSetup")]
        public IActionResult FamilialRelationshipSetup()
        {
            return Json("FamilialRelationshipSetup");
        }



        [HttpGet]
        [Route("/HR/Setup/FingerPrintDBConnectorSetup")]
        public IActionResult FingerPrintDBConnectorSetup()
        {
            return Json("FingerPrintDBConnectorSetup");
        }



        [HttpGet]
        [Route("/HR/Setup/FingerPrintReaderSensorSetup")]
        public IActionResult FingerPrintReaderSensorSetup()
        {
            return Json("FingerPrintReaderSensorSetup");
        }



        [HttpGet]
        [Route("/HR/Setup/HRDepartmentSetup")]
        public IActionResult HRDepartmentSetup()
        {
            return Json("HRDepartmentSetup");
        }



        [HttpGet]
        [Route("/HR/Setup/HRDepartmentStaffPermissionForHRSetup")]
        public IActionResult HRDepartmentStaffPermissionForHRSetup()
        {
            return Json("HRDepartmentStaffPermissionForHRSetup");
        }



        [HttpGet]
        [Route("/HR/Setup/IndividualBossSetup")]
        public IActionResult IndividualBossSetup()
        {
            return Json("IndividualBossSetup");
        }


        [HttpGet]
        [Route("/HR/Setup/InsigniaRankSetup")]
        public IActionResult InsigniaRankSetup()
        {
            return Json("InsigniaRankSetup");
        }



        [HttpGet]
        [Route("/HR/Setup/JobFunctionalPositionSetup")]
        public IActionResult JobFunctionalPositionSetup()
        {
            return Json("JobFunctionalPositionSetup");
        }



        [HttpGet]
        [Route("/HR/Setup/JobPositionGroupSetup")]
        public IActionResult JobPositionGroupSetup()
        {
            return Json("JobPositionGroupSetup");
        }



        [HttpGet]
        [Route("/HR/Setup/JobPositionKeyCompetencySetup")]
        public IActionResult JobPositionKeyCompetencySetup()
        {
            return Json("JobPositionKeyCompetencySetup");
        }


        [HttpGet]
        [Route("/HR/Setup/JobPositionLevelSetup")]
        public IActionResult JobPositionLevelSetup()
        {
            return Json("JobPositionLevelSetup");
        }


        [HttpGet]
        [Route("/HR/Setup/JobPositionSetup")]
        public IActionResult JobPositionSetup()
        {
            return Json("JobPositionSetup");
        }


        [HttpGet]
        [Route("/HR/Setup/JobPositionTypeSetup")]
        public IActionResult JobPositionTypeSetup()
        {
            return Json("JobPositionTypeSetup");
        }


        [HttpGet]
        [Route("/HR/Setup/LeaveArchievedRecordOverrideSetup")]
        public IActionResult LeaveArchievedRecordOverrideSetup()
        {
            return Json("LeaveArchievedRecordOverrideSetup");
        }



        [HttpGet]
        [Route("/HR/Setup/LeaveTypeLimitSetup")]
        public IActionResult LeaveTypeLimitSetup()
        {
            return Json("LeaveTypeLimitSetup");
        }



        [HttpGet]
        [Route("/HR/Setup/LeaveTypeLimitSetup_Old")]
        public IActionResult LeaveTypeLimitSetup_Old()
        {
            return Json("LeaveTypeLimitSetup_Old");
        }



        [HttpGet]
        [Route("/HR/Setup/LeaveTypeSetup")]
        public IActionResult LeaveTypeSetup()
        {
            return Json("LeaveTypeSetup");
        }


    

        [HttpGet]
        [Route("/HR/Setup/NameTitleSetup")]
        public IActionResult NameTitleSetup()
        {
            return Json("NameTitleSetup");
        }



        [HttpGet]
        [Route("/HR/Setup/NationalitySetup")]
        public IActionResult NationalitySetup()
        {
            return Json("NationalitySetup");
        }



        [HttpGet]
        [Route("/HR/Setup/OverTimeMultiplyRateSetup")]
        public IActionResult OverTimeMultiplyRateSetup()
        {
            return Json("OverTimeMultiplyRateSetup");
        }



        [HttpGet]
        [Route("/HR/Setup/OverTimeRatePerHourSetup")]
        public IActionResult OverTimeRatePerHourSetup()
        {
            return Json("OverTimeRatePerHourSetup");
        }



        [HttpGet]
        [Route("/HR/Setup/PerformanceYearlyEvaluationWeightSetup")]
        public IActionResult PerformanceYearlyEvaluationWeightSetup()
        {
            return Json("PerformanceYearlyEvaluationWeightSetup");
        }



        [HttpGet]
        [Route("/HR/Setup/RaceSetup")]
        public IActionResult RaceSetup()
        {
            return Json("RaceSetup");
        }



        [HttpGet]
        [Route("/HR/Setup/ReligionSetup")]
        public IActionResult ReligionSetup()
        {
            return Json("ReligionSetup");
        }



        [HttpGet]
        [Route("/HR/Setup/SendWeeklyAbsentNotificationEMailSetup")]
        public IActionResult SendWeeklyAbsentNotificationEMailSetup()
        {
            return Json("SendWeeklyAbsentNotificationEMailSetup");
        }




        [HttpGet]
        [Route("/HR/Setup/StaffOverTimeRatePerHourList")]
        public IActionResult StaffOverTimeRatePerHourList()
        {
            return Json("StaffOverTimeRatePerHourList");
        }



        [HttpGet]
        [Route("/HR/Setup/StaffSignatureSetup")]
        public IActionResult StaffSignatureSetup()
        {
            return Json("StaffSignatureSetup");
        }



        [HttpGet]
        [Route("/HR/Setup/TempYearlyEvaluation5859ScoreSetup")]
        public IActionResult TempYearlyEvaluation5859ScoreSetup()
        {
            return Json("TempYearlyEvaluation5859ScoreSetup");
        }



        [HttpGet]
        [Route("/HR/Setup/UnitChiefSetup")]
        public IActionResult UnitChiefSetup()
        {
            return Json("UnitChiefSetup");
        }



        [HttpGet]
        [Route("/HR/Setup/WorkShiftDataSetup")]
        public IActionResult WorkShiftDataSetup()
        {
            return Json("WorkShiftDataSetup");
        }


     

        [HttpGet]
        [Route("/HR/Setup/WorkShiftExtraAllowanceSetup")]
        public IActionResult WorkShiftExtraAllowanceSetup()
        {
            return Json("WorkShiftExtraAllowanceSetup");
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


        [HttpGet]
        [Route("/Plan/Operate/EditBudgetTransferForm")]
        public IActionResult EditBudgetTransferForm()
        {
            return Json("EditBudgetTransferForm");
        }



        [HttpGet]
        [Route("/Plan/Operate/EditChangedPlanItemRecord")]
        public IActionResult EditChangedPlanItemRecord()
        {
            return Json("EditChangedPlanItemRecord");
        }



        [HttpGet]
        [Route("/Plan/Operate/EditDirectExpenseMemoForm")]
        public IActionResult EditDirectExpenseMemoForm()
        {
            return Json("EditDirectExpenseMemoForm");
        }



        [HttpGet]
        [Route("/Plan/Operate/EditGeneralExpenseExtendForm")]
        public IActionResult EditGeneralExpenseExtendForm()
        {
            return Json("EditGeneralExpenseExtendForm");
        }



        [HttpGet]
        [Route("/Plan/Operate/EditGeneralExpenseForOutsideDutyOrDevForm")]
        public IActionResult EditGeneralExpenseForOutsideDutyOrDevForm()
        {
            return Json("EditGeneralExpenseForOutsideDutyOrDevForm");
        }



        [HttpGet]
        [Route("/Plan/Operate/EditGeneralExpenseMemoForm")]
        public IActionResult EditGeneralExpenseMemoForm()
        {
            return Json("EditGeneralExpenseMemoForm");
        }



        [HttpGet]
        [Route("/Plan/Operate/EditGeneralExpensePersonalBorrowForm")]
        public IActionResult EditGeneralExpensePersonalBorrowForm()
        {
            return Json("EditGeneralExpensePersonalBorrowForm");
        }



        [HttpGet]
        [Route("/Plan/Operate/EditGeneralExpenseSettleAsBudgetForm")]
        public IActionResult EditGeneralExpenseSettleAsBudgetForm()
        {
            return Json("EditGeneralExpenseSettleAsBudgetForm");
        }



        [HttpGet]
        [Route("/Plan/Operate/EditGeneralExpenseSettleForm")]
        public IActionResult EditGeneralExpenseSettleForm()
        {
            return Json("EditGeneralExpenseSettleForm");
        }



        [HttpGet]
        [Route("/Plan/Operate/EditMonthlyForecastAdjustment")]
        public IActionResult EditMonthlyForecastAdjustment()
        {
            return Json("EditMonthlyForecastAdjustment");
        }



        [HttpGet]
        [Route("/Plan/Operate/EditOutsideDutyReportForm")]
        public IActionResult EditOutsideDutyReportForm()
        {
            return Json("EditOutsideDutyReportForm");
        }


      

        [HttpGet]
        [Route("/Plan/Operate/EditPerformanceIndicatorResult")]
        public IActionResult EditPerformanceIndicatorResult()
        {
            return Json("EditPerformanceIndicatorResult");
        }



        [HttpGet]
        [Route("/Plan/Operate/EditPlan/{PlanCoreId}")]
        public IActionResult EditPlan(int PlanCoreId)
        {
            var data = _SecServices.GetEditPlan(PlanCoreId);
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
        

        [HttpGet]
        [Route("/Plan/Operate/EditPlanActivity")]
        public IActionResult EditPlanActivity()
        {
            return Json("EditPlanActivity");
        }



        [HttpGet]
        [Route("/Plan/Operate/EditPlanActivityOperationPeriod")]
        public IActionResult EditPlanActivityOperationPeriod()
        {
            return Json("EditPlanActivityOperationPeriod");
        }



        [HttpGet]
        [Route("/Plan/Operate/EditPlanActivityOperationPeriodOnList")]
        public IActionResult EditPlanActivityOperationPeriodOnList()
        {
            return Json("EditPlanActivityOperationPeriodOnList");
        }



        [HttpGet]
        [Route("/Plan/Operate/EditPlanActivityOperationPeriodResult/{PlanActivityId}")]
        public IActionResult EditPlanActivityOperationPeriodResult(int PlanActivityId)
        {
            var data = _SecServices.EditPlanActivityOperationPeriodResult(PlanActivityId);
            return Json(data);
        }


        [HttpGet]
        [Route("/Plan/Operate/EditPlanItem")]
        public IActionResult EditPlanItem()
        {
            return Json("EditPlanItem");
        }


        [HttpGet]
        [Route("/Plan/Operate/EditPlanMonthlyOperation")]
        public IActionResult EditPlanMonthlyOperation()
        {
            return Json("EditPlanMonthlyOperation");
        }



        [HttpGet]
        [Route("/Plan/Operate/EditPlanOperationPeriod")]
        public IActionResult EditPlanOperationPeriod()
        {
            return Json("EditPlanOperationPeriod");
        }



        [HttpGet]
        [Route("/Plan/Operate/EditReceivedReservedBudgetByPlanActivity")]
        public IActionResult EditReceivedReservedBudgetByPlanActivity()
        {
            return Json("EditReceivedReservedBudgetByPlanActivity");
        }



        [HttpGet]
        [Route("/Plan/Operate/EditSettleReceiptForm")]
        public IActionResult EditSettleReceiptForm()
        {
            return Json("EditSettleReceiptForm");
        }



        [HttpGet]
        [Route("/Plan/Operate/SearchPlanActivity")]
        public IActionResult SearchPlanActivity()
        {
            return Json("SearchPlanActivity");
        }



        [HttpGet]
        [Route("/Plan/Operate/SearchPlanForActivity")]
        public IActionResult SearchPlanForActivity()
        {
            return Json("SearchPlanForActivity");
        }


        [HttpGet]
        [Route("/Plan/Operate/SearchPlanItem")]
        public IActionResult SearchPlanItem()
        {
            return Json("SearchPlanItem");
        }


        [HttpGet]
        [Route("/Plan/Operate/SelectGeneralExpenseForPersonalBorrowing")]
        public IActionResult SelectGeneralExpenseForPersonalBorrowing()
        {
            return Json("SelectGeneralExpenseForPersonalBorrowing");
        }


        [HttpGet]
        [Route("/Plan/Operate/SelectGEPersonalBorrowFormForExtend")]
        public IActionResult SelectGEPersonalBorrowFormForExtend()
        {
            return Json("SelectGEPersonalBorrowFormForExtend");
        }



        [HttpGet]
        [Route("/Plan/Operate/SelectSupplierListForForm")]
        public IActionResult SelectSupplierListForForm()
        {
            return Json("SelectSupplierListForForm");
        }



        [HttpGet]
        [Route("/Plan/Operate/SelectViewPlanForActivityByDepartment/GetByFiscalYear/{year}")]
        public IActionResult SelectViewPlanForActivityByDepartment(int year)
        {
            var data = _SecServices.DepartmentGetByFiscalYear(year);
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
        [Route("/Plan/Operate/ViewChangedPlanItemRecordList")]
        public IActionResult ViewChangedPlanItemRecordList()
        {
            return Json("ViewChangedPlanItemRecordList");
        }



        [HttpPost]
        [Route("/Plan/Operate/ViewDirectExpenseMemoFormList")]
        public IActionResult ViewDirectExpenseMemoFormList(ViewDirectExpenseMemoFormListRequest request)
        {
            var data = _SecServices.ViewDirectExpenseMemoFormList(request);
            return Json(data);
        }



        [HttpGet]
        [Route("/Plan/Operate/ViewFormForApprovalByDocChecker")]
        public IActionResult ViewFormForApprovalByDocChecker()
        {
            return Json("ViewFormForApprovalByDocChecker");
        }



        [HttpGet]
        [Route("/Plan/Operate/ViewFormForApprovalByUnitChief")]
        public IActionResult ViewFormForApprovalByUnitChief()
        {
            return Json("ViewFormForApprovalByUnitChief");
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



        [HttpGet]
        [Route("/Plan/Operate/ViewGeneralExpenseMemoFormForSettle")]
        public IActionResult ViewGeneralExpenseMemoFormForSettle()
        {
            return Json("ViewGeneralExpenseMemoFormForSettle");
        }



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



        [HttpGet]
        [Route("/Plan/Operate/ViewGeneralExpenseMemoFormListForExtend")]
        public IActionResult ViewGeneralExpenseMemoFormListForExtend()
        {
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



        [HttpGet]
        [Route("/Plan/Operate/ViewGeneralExpenseSettleAsBudgetFormList")]
        public IActionResult ViewGeneralExpenseSettleAsBudgetFormList()
        {
            var data = _SecServices.ViewGeneralExpenseSettleAsBudgetFormList();
            return Json(data);
        }



        [HttpGet]
        [Route("/Plan/Operate/ViewGeneralExpenseSettleFormList")]
        public IActionResult ViewGeneralExpenseSettleFormList()
        {
            return Json("ViewGeneralExpenseSettleFormList");
        }



        [HttpPost]
        [Route("/Plan/Operate/ViewGeneralExpenseSettleFormListForApproval")]
        public IActionResult ViewGeneralExpenseSettleFormListForApproval(ViewGeneralExpenseSettleFormListRequest request)
        {
            var data = _SecServices.ViewGeneralExpenseSettleFormListForApproval(request);
            return Json(data);
        }


        [HttpGet]
        [Route("/Plan/Operate/ViewMonthlyForecastAdjustmentList")]
        public IActionResult ViewMonthlyForecastAdjustmentList()
        {
            return Json("ViewMonthlyForecastAdjustmentList");
        }



        [HttpGet]
        [Route("/Plan/Operate/ViewOutsideDutyReportFormList")]
        public IActionResult ViewOutsideDutyReportFormList()
        {
            return Json("ViewOutsideDutyReportFormList");
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

        [HttpGet]
        [Route("/Plan/Setup/CostTypeSetup")]
        public IActionResult CostTypeSetup()
        {
            return Json("CostTypeSetup");
        }



        [HttpPost]
        [Route("/Plan/Setup/DepartmentSetup")]
        public IActionResult DepartmentSetup(DepartmentRequest request)
        {
            var data = _SecServices.DepartmentSetup(request);
            return Json(data);
        }
        [HttpGet]
        [Route("/Plan/Setup/DepartmentSetup/GetByFiscalYear/{year}")]
        public IActionResult DepartmentSetupGetByFiscalYear(int year)
        {
            var data = _SecServices.DepartmentListGetByFiscalYear(year);
            return Json(data);
        }

        [HttpPost]
        [Route("/Plan/Setup/FundTypeSetup")]
        public IActionResult FundTypeSetup(FundTypeRequest request)
        {
            var data = _SecServices.FundTypeSetup(request);
            return Json(data);
        }

        [HttpGet]
        [Route("/Plan/Setup/FundTypeSetup/GetByFiscalYear/{year}")]
        public IActionResult FundTypeSetupGetByFiscalYear(int year)
        {
            var data = _SecServices.FundTypeSetupByFiscalYear(year);
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


        [HttpGet]
        [Route("/Plan/Setup/PlanCRUDPolicySetup")]
        public IActionResult PlanCRUDPolicySetup()
        {
            return Json("PlanCRUDPolicySetup");
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



        [HttpGet]
        [Route("/Plan/Setup/PlanDepartmentStaffPermissionForPlanAndProcure")]
        public IActionResult PlanDepartmentStaffPermissionForPlanAndProcure()
        {
            return Json("PlanDepartmentStaffPermissionForPlanAndProcure");
        }



        [HttpGet]
        [Route("/Plan/Setup/PlanItemTypeSetup")]
        public IActionResult PlanItemTypeSetup()
        {
            return Json("PlanItemTypeSetup");
        }



        [HttpGet]
        [Route("/Plan/Setup/PlanPersonSetup")]
        public IActionResult PlanPersonSetup()
        {
            return Json("PlanPersonSetup");
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
        [Route("/Plan/Setup/StrategySetup/FiscalYear/{year}")]
        public IActionResult StrategySetupByFiscalYear(int year)
        {
            var data = _SecServices.StrategySetupByFiscalYear(year);
            return Json(data);
        }

        [HttpPost]
        [Route("/Plan/Setup/StrategySetup")]
        public IActionResult StrategySetup(StrategySetupModel request)
        {
            var data = _SecServices.StrategySetup(request);
            return Json(data);
        }
        
        [HttpDelete]
        [Route("/Plan/Setup/StrategySetup/DeleteStrategy/{Id}")]
        public IActionResult DeleteStrategy(int Id)
        {

            var data = _SecServices.DeleteStrategy(Id);

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
