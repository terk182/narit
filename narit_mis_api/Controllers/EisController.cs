using App.Accommodations.Model.Requests;
using App.Accommodations;
using Microsoft.AspNetCore.Mvc;
using narit_mis_api.Models;
using App.EIS;
using App.EIS.Dtos;
using App.PathDetail;
using App.PathDetail.Models;

namespace narit_mis_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EisController : Controller
    {

        protected readonly IPathDetailService _ServiceJson;
        protected readonly IEisServices _Service;
            private readonly ILogger _Logger;
            
            public EisController(ILogger<EisController> logger, IEisServices Service, IPathDetailService PathDetailService)
        {
            _Service = Service;
            _ServiceJson = PathDetailService;
            _Logger = logger;

                //_configuration = Configuration;
                // connecttion = _configuration.GetConnectionString("Defaultconnectton");
            }
        #region Executive

      

 

        [HttpGet]
        [Route("Executive/pageload")]
        public IActionResult getExecutiveList()
        {
            //var dummy = new List<SiteMapNode>();
            //dummy.Add(new SiteMapNode
            //{
            //    th_title = ""
            //});
            var data = _ServiceJson.Sitemap("./json/sitemap.json");
            var main = data.Find(x => x.th_title == "ผู้บริหาร")!;
            var sub =  main.siteMapNode[0].siteMapNode;
            return Json(sub != null? sub:"error");
           
        }
       
        //[HttpGet]
        //[Route("Executive/Report/GovernmentDisbursementGoalReport/{year}")]
        //public IActionResult GovernmentDisbursementGoalReport(int year)
        //{
        //    var data = _Service.planCoreList(year);

        //    return Json(data);
        //}


        [HttpGet]
        [Route("Executive/MainExecutivePage")]
        public IActionResult MainExecutivePage()
        {
            return Json("MainExecutivePage");
        }

        [HttpGet]
        [Route("Executive/Operate/EditProcureComitteeGroup")]
        public IActionResult EditProcureComitteeGroup()
        {
            return Json("EditProcureComitteeGroup");
        }


        [HttpGet]
        [Route("Executive/Operate/ViewProcureComitteeGroupList")]
        public IActionResult ViewProcureComitteeGroupList()
        {
            return Json("ViewProcureComitteeGroupList");
        }

        [HttpGet]
        [Route("Executive/Report/BudgetTransferDashboard")]
        public IActionResult BudgetTransferDashboard()
        {
            return Json("BudgetTransferDashboard");
        }

    
        [HttpGet]
        [Route("Executive/Report/CurrentReserveStatementConclusionReport")]
        public IActionResult CurrentReserveStatementConclusionReport()
        {
            return Json("CurrentReserveStatementConclusionReport");
        }


        [HttpGet]
        [Route("Executive/Report/DepartmentDashboard")]
        public IActionResult DepartmentDashboard()
        {
            return Json("DepartmentDashboard");
        }


        [HttpGet]
        [Route("Executive/Report/ExecutiveMainReport_Reserved")]
        public IActionResult ExecutiveMainReport_Reserved()
        {
            return Json("ExecutiveMainReport_Reserved");
        }


        [HttpGet]
        [Route("Executive/Report/ExecutivePlanCoreGroupReport_Reserved")]
        public IActionResult ExecutivePlanCoreGroupReport_Reserved()
        {
            return Json("ExecutivePlanCoreGroupReport_Reserved");
        }


        [HttpGet]
        [Route("Executive/Report/GovernmentDisbursementGoalReport")]
        public IActionResult GovernmentDisbursementGoalReport()
        {
            return Json("GovernmentDisbursementGoalReport");
        }


        [HttpGet]
        [Route("Executive/Report/ManagementDashboard")]
        public IActionResult ManagementDashboard()
        {
            return Json("ManagementDashboard");
        }


        [HttpGet]
        [Route("Executive/Report/MedicalReimbursementDashboard")]
        public IActionResult MedicalReimbursementDashboard()
        {
            return Json("MedicalReimbursementDashboard");
        }


        [HttpGet]
        [Route("Executive/Report/PlanActivityDashboard")]
        public IActionResult PlanActivityDashboard()
        {
            return Json("PlanActivityDashboard");
        }


        [HttpGet]
        [Route("Executive/Report/PlanCoreDashboard")]
        public IActionResult PlanCoreDashboard()
        {
            return Json("PlanCoreDashboard");
        }


        [HttpGet]
        [Route("Executive/Report/PlanCoreListByPerformanceDashboard")]
        public IActionResult PlanCoreListByPerformanceDashboard()
        {
            return Json("PlanCoreListByPerformanceDashboard");
        }


        [HttpGet]
        [Route("Executive/Report/PlanOperationFinancialResultDashboard")]
        public IActionResult PlanOperationFinancialResultDashboard()
        {
            return Json("PlanOperationFinancialResultDashboard");
        }


        [HttpGet]
        [Route("Executive/Report/PlanOperationResultDashboard")]
        public IActionResult PlanOperationResultDashboard()
        {
            return Json("PlanOperationResultDashboard");
        }


        [HttpGet]
        [Route("Executive/Report/PlanTypeDashboard")]
        public IActionResult PlanTypeDashboard()
        {
            return Json("PlanTypeDashboard");
        }


        [HttpGet]
        [Route("Executive/Report/ProcureComitteeByPersonReport")]
        public IActionResult ProcureComitteeByPersonReport()
        {
            return Json("ProcureComitteeByPersonReport");
        }



        [HttpGet]
        [Route("Executive/Report/ProcureComitteeGroupReport")]
        public IActionResult ProcureComitteeGroupReport()
        {
            return Json("ProcureComitteeGroupReport");
        }


        [HttpGet]
        [Route("Executive/Report/ProcureDashboard")]
        public IActionResult ProcureDashboard()
        {
            return Json("ProcureDashboard");
        }


        [HttpGet]
        [Route("Executive/Report/StrategiesDashboard")]
        public IActionResult StrategiesDashboard()
        {
            return Json("StrategiesDashboard");
        }



        #endregion
        #region Operation

        [HttpGet]
        [Route("Operation/Operate/AddStepOperation")]
        public IActionResult AddStepOperation()
        {
            return Json("AddStepOperation");
        }

        [HttpGet]
        [Route("Operation/Operate/AddStepOperationMobile")]
        public IActionResult AddStepOperationMobile()
        {
            return Json("AddStepOperationMobile");
        }


        [HttpGet]
        [Route("Operation/Operate/AddTrackingItem")]
        public IActionResult AddTrackingItem()
        {
            return Json("AddTrackingItem");
        }


        [HttpGet]
        [Route("Operation/Operate/EditBillingDrinkingWaterForm")]
        public IActionResult EditBillingDrinkingWaterForm()
        {
            return Json("EditBillingDrinkingWaterForm");
        }


        [HttpGet]
        [Route("Operation/Operate/EditBillingElectricForm")]
        public IActionResult EditBillingElectricForm()
        {
            return Json("EditBillingElectricForm");
        }


        [HttpGet]
        [Route("Operation/Operate/EditBillingGarbageForm")]
        public IActionResult EditBillingGarbageForm()
        {
            return Json("EditBillingGarbageForm");
        }


        [HttpGet]
        [Route("Operation/Operate/EditBillingTelephoneForm")]
        public IActionResult EditBillingTelephoneForm()
        {
            return Json("EditBillingTelephoneForm");
        }


        [HttpGet]
        [Route("Operation/Operate/EditBillingWaterForm")]
        public IActionResult EditBillingWaterForm()
        {
            return Json("EditBillingWaterForm");
        }



        [HttpGet]
        [Route("Operation/Operate/OperationFileStream")]
        public IActionResult OperationFileStream()
        {
            return Json("OperationFileStream.ashx");
        }




        [HttpGet]
        [Route("Operation/Operate/ProcureTrackingItemRoute")]
        public IActionResult ProcureTrackingItemRoute()
        {
            return Json("ProcureTrackingItemRoute");
        }


        [HttpGet]
        [Route("Operation/Operate/ProcureTrackingItemRouteMobile")]
        public IActionResult ProcureTrackingItemRouteMobile()
        {
            return Json("ProcureTrackingItemRouteMobile");
        }


        [HttpGet]
        [Route("Operation/Operate/SelectProcureComitteeGroupForTrackingGroup")]
        public IActionResult SelectProcureComitteeGroupForTrackingGroup()
        {
            return Json("SelectProcureComitteeGroupForTrackingGroup");
        }


        [HttpGet]
        [Route("Operation/Operate/ViewBillingFormList")]
        public IActionResult ViewBillingFormList()
        {
            return Json("ViewBillingFormList");
        }

        [HttpGet]
        [Route("Operation/Operate/ViewPlanItemSelectionForAddTrackingItem")]
        public IActionResult ViewPlanItemSelectionForAddTrackingItem()
        {
            return Json("ViewPlanItemSelectionForAddTrackingItem");
        }


        [HttpGet]
        [Route("Operation/Operate/ViewTrackingItemList")]
        public IActionResult ViewTrackingItemList()
        {
            return Json("ViewTrackingItemList");
        }


        [HttpGet]
        [Route("Operation/Report/BillingDashboard")]
        public IActionResult BillingDashboard()
        {
            return Json("BillingDashboard");
        }


        [HttpGet]
        [Route("Operation/Report/OperationFormReportViewer")]
        public IActionResult OperationFormReportViewer()
        {
            return Json("OperationFormReportViewer");
        }

        [HttpGet]
        [Route("Operation/Report/OperationReportStream")]
        public IActionResult OperationReportStream()
        {
            return Json("OperationReportStream.ashx");
        }


        [HttpGet]
        [Route("Operation/Report/ProcureTrackingByStepGroupDashboard")]
        public IActionResult ProcureTrackingByStepGroupDashboard()
        {
            return Json("ProcureTrackingByStepGroupDashboard");
        }

        [HttpGet]
        [Route("Operation/Report/ProcureTrackingDashboard")]
        public IActionResult ProcureTrackingDashboard()
        {
            return Json("ProcureTrackingDashboard");
        }


        [HttpGet]
        [Route("Operation/Report/ProcureTrackingReport")]
        public IActionResult ProcureTrackingReport()
        {
            return Json("ProcureTrackingReport");
        }

        [HttpGet]
        [Route("Operation/Setup/BillingLocationSetup/getAllBillingLocation")]
        public IActionResult getAllBillingLocation()
        {
            var data = _Service.getAllBillingLocation();
            return Json(data);
        }


        [HttpGet]
        [Route("Operation/Setup/BuildingPlanSetting/getAllBuildingPlan")]
        public IActionResult getAllBuildingPlan()
        {
            var data = _Service.getAllBuildingPlan();
            return Json(data);
        }



        #endregion

        [HttpGet]
            #region CollaborationNetwork
            
                   [HttpGet]
        [Route("CollaborationNetwork/Operate/CollaborationNetwork")]
        public IActionResult CollaborationNetwork()
        {
            return Json("CollaborationNetwork");
        }


        [HttpGet]
        [Route("CollaborationNetwork/Operate/DetailCollaborateReport")]
        public IActionResult DetailCollaborateReport()
        {
            return Json("DetailCollaborateReport");
        }

        [HttpGet]
        [Route("CollaborationNetwork/Operate/DownloadFile")]
        public IActionResult DownloadFile()
        {
            return Json("DownloadFile");
        }

        [HttpGet]
        [Route("CollaborationNetwork/Operate/EditCollaborateReport")]
        public IActionResult EditCollaborateReport()
        {
            return Json("EditCollaborateReport");
        }

       


        [HttpGet]
        [Route("CollaborationNetwork/Operate/EditOrganization")]
        public IActionResult EditOrganization()
        {
            return Json("EditOrganization");
        }


         

        [HttpGet]
        [Route("CollaborationNetwork/Operate/OperationFileStream")]
        public IActionResult Operate_OperationFileStream()
        {
            return Json("OperationFileStream.ashx");
        }


    
        [HttpGet]
        [Route("CollaborationNetwork/Operate/OrganizationDashborad")]
        public IActionResult OrganizationDashborad()
        {
            return Json("OrganizationDashborad");
        }


        [HttpGet]
        [Route("CollaborationNetwork/Operate/ViewCollaborateReport")]
        public IActionResult ViewCollaborateReport()
        {
            return Json("ViewCollaborateReport");
        }


        [HttpGet]
        [Route("CollaborationNetwork/Report/CollaborationNetworkReportStream")]
        public IActionResult CollaborationNetworkReportStream()
        {
            return Json("CollaborationNetworkReportStream.ashx");
        }




       

       
        [HttpGet]
        [Route("CollaborationNetwork/Setup/AccommodationSetup")]
        public IActionResult AccommodationSetup()
        {
            return Json("AccommodationSetup");
        }

        [HttpGet]
        [Route("CollaborationNetwork/Setup/AgreementSetup")]
        public IActionResult AgreementSetup()
        {
            return Json("AgreementSetup");
        }



        [HttpGet]
        [Route("CollaborationNetwork/Setup/ContactPersonSetup")]
        public IActionResult ContactPersonSetup()
        {
            return Json("ContactPersonSetup");
        }


      

        [HttpGet]
        [Route("CollaborationNetwork/Setup/CountrySetup")]
        public IActionResult CountrySetup()
        {
            return Json("CountrySetup");
        }


       

        #endregion

    }
}
