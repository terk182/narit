using App.NewCGIMIS;
using App.NewCGIMIS.Models.Requests;
using App.Plan;
using App.SEC;
using App.SEC.Dtos;
using Microsoft.AspNetCore.Mvc;
using narit_mis_api.Models;

namespace narit_mis_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AAA_NewCGIMISController : Controller
    {
        protected readonly INewCGIMISServices _Services;
        private readonly ILogger _Logger;
        private readonly ISecServices _SecService;
        public AAA_NewCGIMISController(ILogger<AAA_NewCGIMISController> logger, INewCGIMISServices Services, ISecServices SecServices)
        {
            _Services = Services;
            _Logger = logger;
            _SecService = SecServices;
        }
        /////////////////////////////////new new new by ardin/////////////////////////////////
        #region MainGovtStatement
        //MainGovtStatement
        [HttpGet]
        [Route("/MainGovtStatement/GetAll")]
        public IActionResult GetAllMainGovtStatement()
        {
            var data = _Services.GetAllMainGovtStatement();
            return Json(data);
        }
        [HttpGet]
        [Route("/MainGovtStatement/GetbyFisicalYear/{FisicalYear}")]
        public IActionResult GetMainGovtStatementbyFisicalYear(int FisicalYear)
        {
            var data = _Services.GetMainGovtStatementbyFisicalYear(FisicalYear);
            return Json(data);
        }
        [HttpGet]
        [Route("/MainGovtStatement/GetbyId/{MainGovtStatementId}")]
        public IActionResult GetMainGovtStatementbyId(int MainGovtStatementId)
        {
            var data = _Services.GetMainGovtStatementbyId(MainGovtStatementId);
            return Json(data);
        }
        [HttpPost]
        [Route("/MainGovtStatement/Setup")]
        public IActionResult MainGovtStatementSetup(MainGovtStatement request)
        {
            var data = _Services.MainGovtStatementSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/MainGovtStatement/Delete/{MainGovtStatementId}")]
        public IActionResult DeleteMainGovtStatement(int MainGovtStatementId)
        {

            var data = _Services.DeleteMainGovtStatement(MainGovtStatementId);

            return Json(data);
        }
        #endregion
        #region GovtStrategic
        //GovtStrategic
        [HttpGet]
        [Route("/GovtStrategic/GetAll")]
        public IActionResult GetAllGovtStrategic()
        {
            var data = _Services.GetAllGovtStrategic();
            return Json(data);
        }
        [HttpGet]
        [Route("/GovtStrategic/GetbyId/{GovtStrategicId}")]
        public IActionResult GetGovtStrategicbyId(int GovtStrategicId)
        {
            var data = _Services.GetGovtStrategicbyId(GovtStrategicId);
            return Json(data);
        }
        [HttpPost]
        [Route("/GovtStrategic/Setup")]
        public IActionResult GovtStrategicSetup(GovtStrategic request)
        {
            var data = _Services.GovtStrategicSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/GovtStrategic/Delete/{GovtStrategicId}")]
        public IActionResult DeleteGovtStrategic(int GovtStrategicId)
        {

            var data = _Services.DeleteGovtStrategic(GovtStrategicId);

            return Json(data);
        }
        #endregion
        # region GovtPlan
        //GovtPlan
        [HttpGet]
        [Route("/GovtPlan/GetAll")]
        public IActionResult GetAllGovtPlan()
        {
            var data = _Services.GetAllGovtPlan();
            return Json(data);
        }
        [HttpGet]
        [Route("/GovtPlan/GetbyId/{GovtPlanId}")]
        public IActionResult GetGovtPlanbyId(int GovtPlanId)
        {
            var data = _Services.GetGovtPlanbyId(GovtPlanId);
            return Json(data);
        }
        [HttpPost]
        [Route("/GovtPlan/Setup")]
        public IActionResult GovtPlanSetup(GovtPlan request)
        {
            var data = _Services.GovtPlanSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/GovtPlan/Delete/{GovtPlanId}")]
        public IActionResult DeleteGovtPlan(int GovtPlanId)
        {

            var data = _Services.DeleteGovtPlan(GovtPlanId);

            return Json(data);
        }
        #endregion
        #region MainProject
        //MainProject
        [HttpGet]
        [Route("/MainProject/GetAll")]
        public IActionResult GetAllMainProject()
        {
            var data = _Services.GetAllMainProject();
            return Json(data);
        }
        [HttpGet]
        [Route("/MainProject/GetbyId/{MainProjectId}")]
        public IActionResult GetMainProjectbyId(int MainProjectId)
        {
            var data = _Services.GetMainProjectbyId(MainProjectId);
            return Json(data);
        }
        [HttpPost]
        [Route("/MainProject/Setup")]
        public IActionResult MainProjectSetup(MainProject request)
        {
            var data = _Services.MainProjectSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/MainProject/Delete/{MainProjectId}")]
        public IActionResult DeleteMainProject(int MainProjectId)
        {

            var data = _Services.DeleteMainProject(MainProjectId);

            return Json(data);
        }
        #endregion
        #region MainActivity
        //MainActivity
        [HttpGet]
        [Route("/MainActivity/GetAll")]
        public IActionResult GetAllMainActivity()
        {
            var data = _Services.GetAllMainActivity();
            return Json(data);
        }
        [HttpGet]
        [Route("/MainActivity/GetbyId/{MainActivityId}")]
        public IActionResult GetMainActivitybyId(int MainActivityId)
        {
            var data = _Services.GetMainActivitybyId(MainActivityId);
            return Json(data);
        }
        [HttpPost]
        [Route("/MainActivity/Setup")]
        public IActionResult MainActivitySetup(MainActivity request)
        {
            var data = _Services.MainActivitySetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/MainActivity/Delete/{MainActivityId}")]
        public IActionResult DeleteMainActivity(int MainActivityId)
        {

            var data = _Services.DeleteMainActivity(MainActivityId);

            return Json(data);
        }
        #endregion
        #region ScheduleFisicalYears
        //ScheduleFisicalYears
        [HttpGet]
        [Route("/ScheduleFisicalYear/GetAll")]
        public IActionResult GetScheduleFisicalYear()
        {
            var data = _Services.GetScheduleFisicalYear();
            return Json(data);
        }
        [HttpGet]
        [Route("/ScheduleFisicalYear/GetbyFisicalYear/{FisicalYear}")]
        public IActionResult GetScheduleFisicalYearbyYear(int FisicalYear)
        {
            var data = _Services.GetScheduleFisicalYearbyYear(FisicalYear);
            return Json(data);
        }
        [HttpPost]
        [Route("/ScheduleFisicalYear/EditByYear")]
        public IActionResult EditScheduleFisicalYear(string name, bool active)
        {
            var data = _Services.EditScheduleFisicalYear(name, active);
            return Json(data);
        }
        [HttpPost]
        [Route("/ScheduleFisicalYear/SetUp")]
        public IActionResult ScheduleFisicalYearSetUp(ScheduleFisicalYear request)
        {
            var data = _Services.ScheduleFisicalYearSetUp(request);
            return Json(data);
        }
        #endregion
        #region StrategicIssue
        //StrategicIssue
        [HttpGet]
        [Route("/StrategicIssue/GetAll")]
        public IActionResult GetAllStrategicIssue()
        {
            var data = _Services.GetAllStrategicIssue();
            return Json(data);
        }
        [HttpGet]
        [Route("/StrategicIssue/GetbyId/{StrategicIssueId}")]
        public IActionResult GetStrategicIssuebyId(int StrategicIssueId)
        {
            var data = _Services.GetStrategicIssuebyId(StrategicIssueId);
            return Json(data);
        }
        [HttpPost]
        [Route("/StrategicIssue/Setup")]
        public IActionResult StrategicIssueSetup(StrategicIssue request)
        {
            var data = _Services.StrategicIssueSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/StrategicIssue/Delete/{StrategicIssueId}")]
        public IActionResult DeleteStrategicIssue(int StrategicIssueId)
        {

            var data = _Services.DeleteStrategicIssue(StrategicIssueId);

            return Json(data);
        }
        #endregion
        #region ExternalBudgetStrategy
        //ExternalBudgetStrategy
        [HttpGet]
        [Route("/ExternalBudgetStrategy/GetAll")]
        public IActionResult GetAllExternalBudgetStrategy()
        {
            var data = _Services.GetAllExternalBudgetStrategy();
            return Json(data);
        }
        [HttpGet]
        [Route("/ExternalBudgetStrategy/GetbyFisicalYear/{FisicalYear}")]
        public IActionResult GetExternalBudgetStrategybyFisicalYear(int FisicalYear)
        {
            var data = _Services.GetExternalBudgetStrategybyFisicalYear(FisicalYear);
            return Json(data);
        }
        [HttpGet]
        [Route("/ExternalBudgetStrategy/GetbyId/{ExternalBudgetStrategyId}")]
        public IActionResult GetExternalBudgetStrategybyId(int ExternalBudgetStrategyId)
        {
            var data = _Services.GetExternalBudgetStrategybyId(ExternalBudgetStrategyId);
            return Json(data);
        }
        [HttpPost]
        [Route("/ExternalBudgetStrategy/Setup")]
        public IActionResult ExternalBudgetStrategySetup(ExternalBudgetStrategy request)
        {
            var data = _Services.ExternalBudgetStrategySetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/ExternalBudgetStrategy/Delete/{ExternalBudgetStrategyId}")]
        public IActionResult DeleteExternalBudgetStrategy(int ExternalBudgetStrategyId)
        {

            var data = _Services.DeleteExternalBudgetStrategy(ExternalBudgetStrategyId);

            return Json(data);
        }
        #endregion
        #region InternalStrategy
        //InternalStrategy
        [HttpGet]
        [Route("/InternalStrategy/GetAll")]
        public IActionResult GetAllInternalStrategy()
        {
            var data = _Services.GetAllInternalStrategy();
            return Json(data);
        }
        [HttpGet]
        [Route("/InternalStrategy/GetbyFisicalYear/{FisicalYear}")]
        public IActionResult GetInternalStrategybyFisicalYear(int FisicalYear)
        {
            var data = _Services.GetInternalStrategybyFisicalYear(FisicalYear);
            return Json(data);
        }
        [HttpGet]
        [Route("/InternalStrategy/GetbyId/{InternalStrategyId}")]
        public IActionResult GetInternalStrategybyId(int InternalStrategyId)
        {
            var data = _Services.GetInternalStrategybyId(InternalStrategyId);
            return Json(data);
        }
        [HttpPost]
        [Route("/InternalStrategy/Setup")]
        public IActionResult InternalStrategySetup(InternalStrategy request)
        {
            var data = _Services.InternalStrategySetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/InternalStrategy/Delete/{InternalStrategyId}")]
        public IActionResult DeleteInternalStrategy(int InternalStrategyId)
        {

            var data = _Services.DeleteInternalStrategy(InternalStrategyId);

            return Json(data);
        }
        #endregion
        #region PlanType
        //PlanType
        [HttpGet]
        [Route("/PlanType/GetAll")]
        public IActionResult PlanTypeGetAll()
        {
            var data = _Services.PlanTypeGetAll();
            return Json(data);
        }
        [HttpGet]
        [Route("/PlanType/GetbyFisicalYear/{FisicalYear}")]
        public IActionResult PlanTypeGetByFiscalYear(int FisicalYear)
        {
            var data = _Services.PlanTypeGetByFiscalYear(FisicalYear);
            return Json(data);
        }
        [HttpGet]
        [Route("/PlanType/GetbyFisicalYearandPlanTypeId/{FisicalYear}/{PlanTypeId}")]
        public IActionResult PlanTypeGetByFiscalYearandPlanTypeid(int FisicalYear, int PlanTypeId)
        {
            var data = _Services.PlanTypeGetByFiscalYearandPlanTypeid(FisicalYear, PlanTypeId);
            return Json(data);
        }
        [HttpGet]
        [Route("/PlanType/GetPlanTypeDetailbyPlanTypeId/{PlanTypeId}")]
        public IActionResult PlanTypeDetailGetByPlanTypeid(int PlanTypeId)
        {
            var data = _Services.PlanTypeDetailGetByPlanTypeid(PlanTypeId);
            return Json(data);
        }
        [HttpGet]
        [Route("/PlanType/GetPlanTypeName/{PlanTypeId}")]
        public IActionResult PlanTypeNameGetByPlanTypeid(int PlanTypeId)
        {
            var data = _Services.PlanTypeNameGetByPlanTypeid(PlanTypeId);
            return Json(data);
        }
        [HttpPost]
        [Route("/PlanType/Setup")]
        public IActionResult PlanTypeSetup(NewPlanTypeRequest request)
        {
            var data = _Services.PlanTypeSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/PlanType/Delete/{PlanTypeId}")]
        public IActionResult DeletePlanType(int PlanTypeId)
        {

            var data = _Services.DeletePlanType(PlanTypeId);

            return Json(data);
        }
        #endregion
        #region Mission
        //Mission
        [HttpGet]
        [Route("/Mission/GetbyFisicalYear/{FisicalYear}")]
        public IActionResult MissionSetupByFiscalYear(int FisicalYear)
        {
            var data = _Services.MissionSetupByFiscalYear(FisicalYear);
            return Json(data);
        }
        [HttpPost]
        [Route("/Mission/Setup")]
        public IActionResult MissionSetup(Mission request)
        {
            var data = _Services.MissionSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/Mission/Delete/{MissionId}")]
        public IActionResult DeleteMission(int MissionId)
        {

            var data = _Services.DeleteMission(MissionId);

            return Json(data);
        }
        #endregion
        #region Department
        //Department
        [HttpGet]
        [Route("/Department/GetAll")]
        public IActionResult GetAllDepartment()
        {
            var data = _Services.GetAllDepartment();
            return Json(data);
        }
        [HttpGet]
        [Route("/Department/GetbyFisicalYear/{FisicalYear}")]
        public IActionResult GetDepartmentbyFisicalYear(int FisicalYear)
        {
            var data = _Services.GetDepartmentbyFisicalYear(FisicalYear);
            return Json(data);
        }
        [HttpGet]
        [Route("/Department/GetbyId/{DepartmentId}")]
        public IActionResult GetDepartmentbyId(int DepartmentId)
        {
            var data = _Services.GetDepartmentbyId(DepartmentId);
            return Json(data);
        }
        [HttpPost]
        [Route("/Department/Setup")]
        public IActionResult DepartmentSetup(Department request)
        {
            var data = _Services.DepartmentSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/Department/Delete/{DepartmentId}")]
        public IActionResult DeleteDepartment(int DepartmentId)
        {

            var data = _Services.DeleteDepartment(DepartmentId);

            return Json(data);
        }
#endregion
        #region AnnualBudget
        //AnnualBudget
        [HttpGet]
        [Route("/AnnualBudget/GetAll")]
        public IActionResult GetAllAnnualBudget()
        {
            var data = _Services.GetAllAnnualBudget();
            return Json(data);
        }
        [HttpGet]
        [Route("/AnnualBudget/GetbyFisicalYear/{FisicalYear}")]
        public IActionResult GetAnnualBudgetbyFisicalYear(int FisicalYear)
        {
            var data = _Services.GetAnnualBudgetbyFisicalYear(FisicalYear);
            return Json(data);
        }
        [HttpGet]
        [Route("/AnnualBudget/GetbyId/{AnnualBudgetId}")]
        public IActionResult GetAnnualBudgetbyId(int AnnualBudgetId)
        {
            var data = _Services.GetAnnualBudgetbyId(AnnualBudgetId);
            return Json(data);
        }
        [HttpPost]
        [Route("/AnnualBudget/Setup")]
        public IActionResult AnnualBudgetSetup(AnnualBudget request)
        {
            var data = _Services.AnnualBudgetSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/AnnualBudget/Delete/{AnnualBudgetId}")]
        public IActionResult DeleteAnnualBudget(int AnnualBudgetId)
        {

            var data = _Services.DeleteAnnualBudget(AnnualBudgetId);

            return Json(data);
        }
        #endregion
        #region SubAnnualBudget
        //SubAnnualBudget
        [HttpGet]
        [Route("/SubAnnualBudget/GetAll")]
        public IActionResult GetAllSubAnnualBudget()
        {
            var data = _Services.GetAllSubAnnualBudget();
            return Json(data);
        }
        [HttpGet]
        [Route("/SubAnnualBudget/GetbyFisicalYear/{FisicalYear}")]
        public IActionResult GetSubAnnualBudgetbyFisicalYear(int FisicalYear)
        {
            var data = _Services.GetSubAnnualBudgetbyFisicalYear(FisicalYear);
            return Json(data);
        }
        [HttpGet]
        [Route("/SubAnnualBudget/GetbyId/{SubAnnualBudgetId}")]
        public IActionResult GetSubAnnualBudgetbyId(int SubAnnualBudgetId)
        {
            var data = _Services.GetSubAnnualBudgetbyId(SubAnnualBudgetId);
            return Json(data);
        }
        [HttpPost]
        [Route("/SubAnnualBudget/Setup")]
        public IActionResult SubAnnualBudgetSetup(SubAnnualBudget request)
        {
            var data = _Services.SubAnnualBudgetSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/SubAnnualBudget/Delete/{SubAnnualBudgetId}")]
        public IActionResult DeleteSubAnnualBudget(int SubAnnualBudgetId)
        {

            var data = _Services.DeleteSubAnnualBudget(SubAnnualBudgetId);

            return Json(data);
        }
        #endregion
        #region CapticalType
        //CapticalType
        [HttpGet]
        [Route("/CapticalType/GetAll")]
        public IActionResult GetAllCapticalType()
        {
            var data = _Services.GetAllCapticalType();
            return Json(data);
        }
        [HttpGet]
        [Route("/CapticalType/GetbyFisicalYear/{FisicalYear}")]
        public IActionResult GetCapticalTypebyFisicalYear(int FisicalYear)
        {
            var data = _Services.GetCapticalTypebyFisicalYear(FisicalYear);
            return Json(data);
        }
        [HttpGet]
        [Route("/CapticalType/GetbyId/{CapticalTypeId}")]
        public IActionResult GetCapticalTypebyId(int CapticalTypeId)
        {
            var data = _Services.GetCapticalTypebyId(CapticalTypeId);
            return Json(data);
        }
        [HttpPost]
        [Route("/CapticalType/Setup")]
        public IActionResult CapticalTypeSetup(CapticalType request)
        {
            var data = _Services.CapticalTypeSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/CapticalType/Delete/{CapticalTypeId}")]
        public IActionResult DeleteCapticalType(int CapticalTypeId)
        {

            var data = _Services.DeleteCapticalType(CapticalTypeId);

            return Json(data);
        }
        #endregion
        #region Project
        //Project
        [HttpGet]
        [Route("/Project/GetAll")]
        public IActionResult GetAllProject()
        {
            var data = _Services.GetAllProject();
            return Json(data);
        }
        [HttpGet]
        [Route("/Project/GetbyFisicalYear/{FisicalYear}")]
        public IActionResult GetProjectbyFisicalYear(int FisicalYear)
        {
            var data = _Services.GetProjectbyFisicalYear(FisicalYear);
            return Json(data);
        }
        [HttpGet]
        [Route("/Project/GetbyId/{ProjectId}")]
        public IActionResult GetProjectbyId(int ProjectId)
        {
            var data = _Services.GetProjectbyId(ProjectId);
            return Json(data);
        }
        [HttpGet]
        [Route("/Project/GetsubProjectorProjectActivitybyProjectId/{ProjectId}")]
        public IActionResult GetsubProjectorProjectActivitybyProjectId(int ProjectId)
        {
            var data = _Services.GetsubProjectorProjectActivitybyProjectId(ProjectId);
            return Json(data);
        }
        [HttpPost]
        [Route("/Project/Setup")]
        public IActionResult ProjectSetup(Project request)
        {
            var data = _Services.ProjectSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/Project/Delete/{ProjectId}")]
        public IActionResult DeleteProject(int ProjectId)
        {

            var data = _Services.DeleteProject(ProjectId);

            return Json(data);
        }
        #endregion
        #region ProjectCaptical
        //ProjectCaptical
        [HttpGet]
        [Route("/ProjectCaptical/GetAll")]
        public IActionResult GetAllProjectCaptical()
        {
            var data = _Services.GetAllProjectCaptical();
            return Json(data);
        }
        [HttpGet]
        [Route("/ProjectCaptical/GetbyId/{ProjectCapticalId}")]
        public IActionResult GetProjectCapticalbyId(int ProjectCapticalId)
        {
            var data = _Services.GetProjectCapticalbyId(ProjectCapticalId);
            return Json(data);
        }
        [HttpPost]
        [Route("/ProjectCaptical/Setup")]
        public IActionResult ProjectCapticalSetup(ProjectCaptical request)
        {
            var data = _Services.ProjectCapticalSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/ProjectCaptical/Delete/{ProjectCapticalId}")]
        public IActionResult DeleteProjectCaptical(int ProjectCapticalId)
        {

            var data = _Services.DeleteProjectCaptical(ProjectCapticalId);

            return Json(data);
        }
        #endregion
        #region ProjectResponsiblePerson
        //ProjectResponsiblePerson
        [HttpGet]
        [Route("/ProjectResponsiblePerson/GetAll")]
        public IActionResult GetAllProjectResponsiblePersons()
        {
            var data = _Services.GetAllProjectResponsiblePersons();
            return Json(data);
        }
        [HttpGet]
        [Route("/ProjectResponsiblePerson/GetbyId/{ProjectResponsiblePersonsId}")]
        public IActionResult GetProjectResponsiblePersonsbyId(int ProjectResponsiblePersonsId)
        {
            var data = _Services.GetProjectResponsiblePersonsbyId(ProjectResponsiblePersonsId);
            return Json(data);
        }
        [HttpGet]
        [Route("/ProjectResponsiblePerson/GetbyProjectId/{ProjectId}")]
        public IActionResult GetProjectResponsiblePersonsbyProjectId(int ProjectId)
        {
            var data = _Services.GetProjectResponsiblePersonsbyProjectId(ProjectId);
            return Json(data);
        }
        [HttpPost]
        [Route("/ProjectResponsiblePerson/Setup")]
        public IActionResult ProjectResponsiblePersonsSetup(ProjectResponsiblePerson request)
        {
            var data = _Services.ProjectResponsiblePersonsSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/ProjectResponsiblePerson/Delete/{ProjectResponsiblePersonsId}")]
        public IActionResult DeleteProjectResponsiblePersons(int ProjectResponsiblePersonsId)
        {

            var data = _Services.DeleteProjectResponsiblePersons(ProjectResponsiblePersonsId);

            return Json(data);
        }
        #endregion
        #region IndicatorsStrategyForProject
        //IndicatorsStrategyForProject
        [HttpGet]
        [Route("/IndicatorsStrategyForProject/GetAll")]
        public IActionResult GetAllIndicatorsStrategyForProject()
        {
            var data = _Services.GetAllIndicatorsStrategyForProject();
            return Json(data);
        }
        [HttpGet]
        [Route("/IndicatorsStrategyForProject/GetbyId/{IndicatorsStrategyForProjectId}")]
        public IActionResult GetIndicatorsStrategyForProjectbyId(int IndicatorsStrategyForProjectId)
        {
            var data = _Services.GetIndicatorsStrategyForProjectbyId(IndicatorsStrategyForProjectId);
            return Json(data);
        }
        [HttpGet]
        [Route("/IndicatorsStrategyForProject/GetbyProjectId/{ProjectId}")]
        public IActionResult GetIndicatorsStrategyForProjectbyProjectId(int ProjectId)
        {
            var data = _Services.GetIndicatorsStrategyForProjectbyProjectId(ProjectId);
            return Json(data);
        }
        [HttpPost]
        [Route("/IndicatorsStrategyForProject/Setup")]
        public IActionResult IndicatorsStrategyForProjectSetup(IndicatorsStrategyForProject request)
        {
            var data = _Services.IndicatorsStrategyForProjectSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/IndicatorsStrategyForProject/Delete/{IndicatorsStrategyForProjectId}")]
        public IActionResult DeleteIndicatorsStrategyForProject(int IndicatorsStrategyForProjectId)
        {

            var data = _Services.DeleteIndicatorsStrategyForProject(IndicatorsStrategyForProjectId);

            return Json(data);
        }
        #endregion
        #region ProjectActivity
        //ProjectActivity
        [HttpGet]
        [Route("/ProjectActivity/GetAll")]
        public IActionResult GetAllProjectActivity()
        {
            var data = _Services.GetAllProjectActivity();
            return Json(data);
        }
        [HttpGet]
        [Route("/ProjectActivity/GetbyId/{ProjectActivityId}")]
        public IActionResult GetProjectActivitybyId(int ProjectActivityId)
        {
            var data = _Services.GetProjectActivitybyId(ProjectActivityId);
            return Json(data);
        }
        [HttpGet]
        [Route("/ProjectActivity/GetProjectActivityforProjectbyId/{ProjectId}")]
        public IActionResult GetProjectActivityforProjectbyId(int ProjectId)
        {
            var data = _Services.GetProjectActivityforProjectbyId(ProjectId);
            return Json(data);
        }
        [HttpGet]
        [Route("/ProjectActivity/GetbySubProjectId/{SubProjectId}")]
        public IActionResult GetProjectActivityfromSubProjectId(int SubProjectId)
        {
            var data = _Services.GetProjectActivityfromSubProjectId(SubProjectId);
            return Json(data);
        }
        [HttpPost]
        [Route("/ProjectActivity/Setup")]
        public IActionResult ProjectActivitySetup(ProjectActivity request)
        {
            var data = _Services.ProjectActivitySetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/ProjectActivity/Delete/{ProjectActivityId}")]
        public IActionResult DeleteProjectActivity(int ProjectActivityId)
        {

            var data = _Services.DeleteProjectActivity(ProjectActivityId);

            return Json(data);
        }
        #endregion
        #region ProjectActivityResponsiblePerson
        //ProjectActivityResponsiblePerson
        [HttpGet]
        [Route("/ProjectActivityResponsiblePerson/GetAll")]
        public IActionResult GetAllProjectActivityResponsiblePerson()
        {
            var data = _Services.GetAllProjectActivityResponsiblePerson();
            return Json(data);
        }
        [HttpGet]
        [Route("/ProjectActivityResponsiblePerson/GetbyId/{ProjectActivityResponsiblePersonId}")]
        public IActionResult GetProjectActivityResponsiblePersonbyId(int ProjectActivityResponsiblePersonId)
        {
            var data = _Services.GetProjectActivityResponsiblePersonbyId(ProjectActivityResponsiblePersonId);
            return Json(data);
        }
        [HttpGet]
        [Route("/ProjectActivityResponsiblePerson/GetbyProjectId/{ProjectActivityId}")]
        public IActionResult GetProjectActivityResponsiblePersonsbyProjectId(int ProjectActivityId)
        {
            var data = _Services.GetProjectActivityResponsiblePersonsbyProjectId(ProjectActivityId);
            return Json(data);
        }
        [HttpPost]
        [Route("/ProjectActivityResponsiblePerson/Setup")]
        public IActionResult ProjectActivityResponsiblePersonSetup(ProjectActivityResponsiblePerson request)
        {
            var data = _Services.ProjectActivityResponsiblePersonSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/ProjectActivityResponsiblePerson/Delete/{ProjectActivityResponsiblePersonId}")]
        public IActionResult DeleteProjectActivityResponsiblePerson(int ProjectActivityResponsiblePersonId)
        {

            var data = _Services.DeleteProjectActivityResponsiblePerson(ProjectActivityResponsiblePersonId);

            return Json(data);
        }
        #endregion
        #region IndicatorsStrategyForProjectActivity
        //IndicatorsStrategyForProjectActivity
        [HttpGet]
        [Route("/IndicatorsStrategyForProjectActivity/GetAll")]
        public IActionResult GetAllIndicatorsStrategyForProjectActivity()
        {
            var data = _Services.GetAllIndicatorsStrategyForProjectActivity();
            return Json(data);
        }
        [HttpGet]
        [Route("/IndicatorsStrategyForProjectActivity/GetbyId/{IndicatorsStrategyForProjectActivityId}")]
        public IActionResult GetIndicatorsStrategyForProjectActivitybyId(int IndicatorsStrategyForProjectActivityId)
        {
            var data = _Services.GetIndicatorsStrategyForProjectActivitybyId(IndicatorsStrategyForProjectActivityId);
            return Json(data);
        }
        [HttpGet]
        [Route("/IndicatorsStrategyForProjectActivity/GetbyProjectActivityId/{ProjectActivityId}")]
        public IActionResult GetIndicatorsStrategyForProjectActivitybyProjectActivityId(int ProjectActivityId)
        {
            var data = _Services.GetIndicatorsStrategyForProjectActivitybyProjectActivityId(ProjectActivityId);
            return Json(data);
        }
        [HttpPost]
        [Route("/IndicatorsStrategyForProjectActivity/Setup")]
        public IActionResult IndicatorsStrategyForProjectActivitySetup(IndicatorsStrategyForProjectActivity request)
        {
            var data = _Services.IndicatorsStrategyForProjectActivitySetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/IndicatorsStrategyForProjectActivity/Delete/{IndicatorsStrategyForProjectActivityId}")]
        public IActionResult DeleteIndicatorsStrategyForProjectActivity(int IndicatorsStrategyForProjectActivityId)
        {

            var data = _Services.DeleteIndicatorsStrategyForProjectActivity(IndicatorsStrategyForProjectActivityId);

            return Json(data);
        }
        #endregion
        #region SubProject
        //SubProject
        [HttpGet]
        [Route("/SubProject/GetAll")]
        public IActionResult GetAllSubProject()
        {
            var data = _Services.GetAllSubProject();
            return Json(data);
        }
        [HttpGet]
        [Route("/SubProject/GetbyId/{SubProjectId}")]
        public IActionResult GetSubProjectbyId(int SubProjectId)
        {
            var data = _Services.GetSubProjectbyId(SubProjectId);
            return Json(data);
        }
        [HttpGet]
        [Route("/SubProject/GetSubProjectforProjectbyId/{ProjectId}")]
        public IActionResult GetSubProjectforProjectbyId(int ProjectId)
        {
            var data = _Services.GetSubProjectforProjectbyId(ProjectId);
            return Json(data);
        }
        [HttpPost]
        [Route("/SubProject/Setup")]
        public IActionResult SubProjectSetup(SubProject request)
        {
            var data = _Services.SubProjectSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/SubProject/Delete/{SubProjectId}")]
        public IActionResult DeleteSubProject(int SubProjectId)
        {

            var data = _Services.DeleteSubProject(SubProjectId);

            return Json(data);
        }
        #endregion
        #region SubProjectResponsiblePerson
        //SubProjectResponsiblePerson
        [HttpGet]
        [Route("/SubProjectResponsiblePerson/GetAll")]
        public IActionResult GetAllSubProjectResponsiblePerson()
        {
            var data = _Services.GetAllSubProjectResponsiblePerson();
            return Json(data);
        }
        [HttpGet]
        [Route("/SubProjectResponsiblePerson/GetbyId/{SubProjectResponsiblePersonId}")]
        public IActionResult GetSubProjectResponsiblePersonbyId(int SubProjectResponsiblePersonId)
        {
            var data = _Services.GetSubProjectResponsiblePersonbyId(SubProjectResponsiblePersonId);
            return Json(data);
        }
        [HttpGet]
        [Route("/SubProjectResponsiblePerson/GetbySubProjectId/{SubProjectId}")]
        public IActionResult GetSubProjectResponsiblePersonsbyProjectId(int SubProjectId)
        {
            var data = _Services.GetSubProjectResponsiblePersonsbySubProjectId(SubProjectId);
            return Json(data);
        }
        [HttpPost]
        [Route("/SubProjectResponsiblePerson/Setup")]
        public IActionResult SubProjectResponsiblePersonSetup(SubProjectResponsiblePerson request)
        {
            var data = _Services.SubProjectResponsiblePersonSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/SubProjectResponsiblePerson/Delete/{SubProjectResponsiblePersonId}")]
        public IActionResult DeleteSubProjectResponsiblePerson(int SubProjectResponsiblePersonId)
        {

            var data = _Services.DeleteSubProjectResponsiblePerson(SubProjectResponsiblePersonId);

            return Json(data);
        }
        #endregion
        #region IndicatorsStrategyForSubProject
        //IndicatorsStrategyForSubProject
        [HttpGet]
        [Route("/IndicatorsStrategyForSubProject/GetAll")]
        public IActionResult GetAllIndicatorsStrategyForSubProject()
        {
            var data = _Services.GetAllIndicatorsStrategyForSubProject();
            return Json(data);
        }
        [HttpGet]
        [Route("/IndicatorsStrategyForSubProject/GetbyId/{IndicatorsStrategyForSubProjectId}")]
        public IActionResult GetIndicatorsStrategyForSubProjectbyId(int IndicatorsStrategyForSubProjectId)
        {
            var data = _Services.GetIndicatorsStrategyForSubProjectbyId(IndicatorsStrategyForSubProjectId);
            return Json(data);
        }
        [HttpGet]
        [Route("/IndicatorsStrategyForSubProject/GetbySubProjectId/{SubProjectId}")]
        public IActionResult GetIndicatorsStrategyForSubProjectbySubProjectId(int SubProjectId)
        {
            var data = _Services.GetIndicatorsStrategyForSubProjectbySubProjectId(SubProjectId);
            return Json(data);
        }
        [HttpPost]
        [Route("/IndicatorsStrategyForSubProject/Setup")]
        public IActionResult IndicatorsStrategyForSubProjectSetup(IndicatorsStrategyForSubProject request)
        {
            var data = _Services.IndicatorsStrategyForSubProjectSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/IndicatorsStrategyForSubProject/Delete/{IndicatorsStrategyForSubProjectId}")]
        public IActionResult DeleteIndicatorsStrategyForSubProject(int IndicatorsStrategyForSubProjectId)
        {

            var data = _Services.DeleteIndicatorsStrategyForSubProject(IndicatorsStrategyForSubProjectId);

            return Json(data);
        }
        #endregion
        #region ListBudgetForActivity
        //ListBudgetForActivity
        [HttpGet]
        [Route("/ListBudgetForActivity/GetAll")]
        public IActionResult GetAllListBudgetForActivity()
        {
            var data = _Services.GetAllListBudgetForActivity();
            return Json(data);
        }
        [HttpGet]
        [Route("/ListBudgetForActivity/GetbyId/{ListBudgetForActivityId}")]
        public IActionResult GetListBudgetForActivitybyId(int ListBudgetForActivityId)
        {
            var data = _Services.GetListBudgetForActivitybyId(ListBudgetForActivityId);
            return Json(data);
        }
        [HttpGet]
        [Route("/ListBudgetForActivity/GetbyProjectActivityId/{ProjectActivityId}")]
        public IActionResult GetListBudgetForActivitybyProjectActivityId(int ProjectActivityId)
        {
            var data = _Services.GetListBudgetForActivitybyProjectActivityId(ProjectActivityId);
            return Json(data);
        }
        [HttpGet]
        [Route("/ListBudgetForActivity/GetbysubProjectId/{subProjectId}")]
        public IActionResult GetListBudgetForActivitybysubProjectId(int subProjectId)
        {
            var data = _Services.GetListBudgetForActivitybysubProjectId(subProjectId);
            return Json(data);
        }
        [HttpPost]
        [Route("/ListBudgetForActivity/Setup")]
        public IActionResult ListBudgetForActivitySetup(ListBudgetForActivity request)
        {
            var data = _Services.ListBudgetForActivitySetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/ListBudgetForActivity/Delete/{ListBudgetForActivityId}")]
        public IActionResult DeleteListBudgetForActivity(int ListBudgetForActivityId)
        {

            var data = _Services.DeleteListBudgetForActivity(ListBudgetForActivityId);

            return Json(data);
        }
        #endregion
        #region BudgetDisbursementPlan
        //BudgetDisbursementPlan
        [HttpGet]
        [Route("/BudgetDisbursementPlan/GetAll")]
        public IActionResult GetAllBudgetDisbursementPlan()
        {
            var data = _Services.GetAllBudgetDisbursementPlan();
            return Json(data);
        }
        [HttpGet]
        [Route("/BudgetDisbursementPlan/GetbyId/{BudgetDisbursementPlanId}")]
        public IActionResult GetBudgetDisbursementPlanbyId(int BudgetDisbursementPlanId)
        {
            var data = _Services.GetBudgetDisbursementPlanbyId(BudgetDisbursementPlanId);
            return Json(data);
        }
        [HttpPost]
        [Route("/BudgetDisbursementPlan/Setup")]
        public IActionResult BudgetDisbursementPlanSetup(BudgetDisbursementPlan request)
        {
            var data = _Services.BudgetDisbursementPlanSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/BudgetDisbursementPlan/Delete/{BudgetDisbursementPlanId}")]
        public IActionResult DeleteBudgetDisbursementPlan(int BudgetDisbursementPlanId)
        {

            var data = _Services.DeleteBudgetDisbursementPlan(BudgetDisbursementPlanId);

            return Json(data);
        }
        #endregion
        #region PlanMonthlyOperations

        [HttpPost]
        [Route("/PlanMonthlyOperation/Setup")]
        public IActionResult EditPlanMonthlyOperation(PlanMonthlyOperationDto request)
        {
            var data = _SecService.EditPlanMonthlyOperation(request);
            return Json(data);
        }




        #endregion
    }
}
