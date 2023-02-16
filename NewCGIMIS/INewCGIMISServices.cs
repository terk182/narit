using App.NewCGIMIS.Dtos;
using App.NewCGIMIS.Models.Requests;
using App.NewCGIMIS.Responses;
using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.NewCGIMIS
{
    public interface INewCGIMISServices
    {
        ////////////////////////////NEW NEW NEW by ardin///////////////////////////////
        #region MainGovtStatement
        //MainGovtStatement
        List<MainGovtStatement> GetAllMainGovtStatement();
        List<MainGovtStatement> GetMainGovtStatementbyFisicalYear(int FisicalYear);
        List<MainGovtStatement> GetMainGovtStatementbyId(int MainGovtStatementId);
        NewBaseResponse MainGovtStatementSetup(MainGovtStatement request);
        NewBaseResponse DeleteMainGovtStatement(int MainGovtStatementId);
        #endregion
        #region GovtStrategic
        //GovtStrategic
        List<GovtStrategic> GetAllGovtStrategic();
        List<GovtStrategic> GetGovtStrategicbyId(int GovtStrategicId);
        NewBaseResponse GovtStrategicSetup(GovtStrategic request);
        NewBaseResponse DeleteGovtStrategic(int GovtStrategicId);
        #endregion
        #region GovtPlan
        //GovtPlan
        List<GovtPlan> GetAllGovtPlan();
        List<GovtPlan> GetGovtPlanbyId(int GovtPlanId);
        NewBaseResponse GovtPlanSetup(GovtPlan request);
        NewBaseResponse DeleteGovtPlan(int GovtPlanId);
        #endregion
        #region MainProject
        //MainProject
        List<MainProject> GetAllMainProject();
        List<MainProject> GetMainProjectbyId(int MainProjectId);
        NewBaseResponse MainProjectSetup(MainProject request);
        NewBaseResponse DeleteMainProject(int MainProjectId);
        #endregion
        #region MainActivity
        //MainActivity
        List<MainActivity> GetAllMainActivity();
        List<MainActivity> GetMainActivitybyId(int MainActivityId);
        NewBaseResponse MainActivitySetup(MainActivity request);
        NewBaseResponse DeleteMainActivity(int MainActivityId);
        #endregion
        #region ScheduleFisicalYears
        //ScheduleFisicalYears
        List<ScheduleFisicalYear> GetScheduleFisicalYear();
        List<ScheduleFisicalYear> GetScheduleFisicalYearbyYear(int year);
        NewBaseResponse EditScheduleFisicalYear(string name, bool active);
        NewBaseResponse ScheduleFisicalYearSetUp(ScheduleFisicalYear Request);
        #endregion
        #region StrategicIssue
        //StrategicIssue
        List<StrategicIssue> GetAllStrategicIssue();
        List<StrategicIssue> GetStrategicIssuebyId(int StrategicIssueId);
        NewBaseResponse StrategicIssueSetup(StrategicIssue request);
        NewBaseResponse DeleteStrategicIssue(int StrategicIssueId);
        #endregion
        #region ExternalBudgetStrategy
        //ExternalBudgetStrategy
        List<ExternalBudgetStrategy> GetAllExternalBudgetStrategy();
        List<ExternalBudgetStrategy> GetExternalBudgetStrategybyFisicalYear(int FisicalYear);
        List<ExternalBudgetStrategy> GetExternalBudgetStrategybyId(int ExternalBudgetStrategyId);
        NewBaseResponse ExternalBudgetStrategySetup(ExternalBudgetStrategy request);
        NewBaseResponse DeleteExternalBudgetStrategy(int ExternalBudgetStrategyId);
        #endregion
        #region InternalStrategy
        //InternalStrategy
        List<InternalStrategy> GetAllInternalStrategy();
        List<InternalStrategy> GetInternalStrategybyFisicalYear(int FisicalYear);
        List<InternalStrategy> GetInternalStrategybyId(int InternalStrategyId);
        NewBaseResponse InternalStrategySetup(InternalStrategy request);
        NewBaseResponse DeleteInternalStrategy(int InternalStrategyId);
        #endregion
        #region PlanType
        //PlanType
        List<NewPlanTypeDto> PlanTypeGetAll();
        List<NewPlanTypeDto> PlanTypeGetByFiscalYear(int FiscalYear);
        List<NewPlanTypeDto> PlanTypeGetByFiscalYearandPlanTypeid(int FiscalYear, int id);
        List<NewPlanTypeDto> PlanTypeDetailGetByPlanTypeid(int id);
        List<NewPlanTypeDto> PlanTypeNameGetByPlanTypeid(int id);
        NewBaseResponse PlanTypeSetup(NewPlanTypeRequest request);
        NewBaseResponse DeletePlanType(int PlanTypeId);
        #endregion
        #region Mission
        //Mission
        List<Mission> MissionSetupByFiscalYear(int FiscalYear);
        NewBaseResponse MissionSetup(Mission request);
        NewBaseResponse DeleteMission(int MissionId);
        #endregion
        #region Department
        //Department
        List<Department> GetAllDepartment();
        List<Department> GetDepartmentbyFisicalYear(int FisicalYear);
        List<Department> GetDepartmentbyId(int DepartmentId);
        NewBaseResponse DepartmentSetup(Department request);
        NewBaseResponse DeleteDepartment(int DepartmentId);
        #endregion
        #region AnnualBudget
        //AnnualBudget
        List<AnnualBudget> GetAllAnnualBudget();
        List<AnnualBudget> GetAnnualBudgetbyFisicalYear(int FisicalYear);
        List<AnnualBudget> GetAnnualBudgetbyId(int AnnualBudgetId);
        NewBaseResponse AnnualBudgetSetup(AnnualBudget request);
        NewBaseResponse DeleteAnnualBudget(int AnnualBudgetId);
        #endregion
        #region SubAnnualBudget
        //SubAnnualBudget
        List<SubAnnualBudget> GetAllSubAnnualBudget();
        List<SubAnnualBudget> GetSubAnnualBudgetbyFisicalYear(int FisicalYear);
        List<SubAnnualBudget> GetSubAnnualBudgetbyId(int SubAnnualBudgetId);
        NewBaseResponse SubAnnualBudgetSetup(SubAnnualBudget request);
        NewBaseResponse DeleteSubAnnualBudget(int SubAnnualBudgetId);
        #endregion
        #region CapticalType
        //CapticalType
        List<CapticalType> GetAllCapticalType();
        List<CapticalType> GetCapticalTypebyFisicalYear(int FisicalYear);
        List<CapticalType> GetCapticalTypebyId(int CapticalTypeId);
        NewBaseResponse CapticalTypeSetup(CapticalType request);
        NewBaseResponse DeleteCapticalType(int CapticalTypeId);
        #endregion
        #region Project
        //Project
        List<Project> GetAllProject();
        List<Project> GetProjectbyFisicalYear(int FisicalYear);
        List<Project> GetProjectbyId(int ProjectId);
        NewBaseResponse GetsubProjectorProjectActivitybyProjectId(int ProjectId);
        NewBaseResponse ProjectSetup(Project request);
        NewBaseResponse DeleteProject(int ProjectId);
        #endregion
        #region ProjectCaptical
        //ProjectCaptical
        List<ProjectCaptical> GetAllProjectCaptical();
        List<ProjectCaptical> GetProjectCapticalbyId(int ProjectCapticalId);
        NewBaseResponse ProjectCapticalSetup(ProjectCaptical request);
        NewBaseResponse DeleteProjectCaptical(int ProjectCapticalId);
        #endregion
        #region ProjectResponsiblePerson
        //ProjectResponsiblePerson
        List<ProjectResponsiblePerson> GetAllProjectResponsiblePersons();
        List<ProjectResponsiblePerson> GetProjectResponsiblePersonsbyId(int ProjectResponsiblePersonsId);
        List<ProjectResponsiblePerson> GetProjectResponsiblePersonsbyProjectId(int ProjectId);
        NewBaseResponse ProjectResponsiblePersonsSetup(ProjectResponsiblePerson request);
        NewBaseResponse DeleteProjectResponsiblePersons(int ProjectResponsiblePersonsId);
        #endregion
        #region IndicatorsStrategyForProject
        //IndicatorsStrategyForProject
        List<IndicatorsStrategyForProject> GetAllIndicatorsStrategyForProject();
        List<IndicatorsStrategyForProject> GetIndicatorsStrategyForProjectbyId(int IndicatorsStrategyForProjectId);
        List<IndicatorsStrategyForProject> GetIndicatorsStrategyForProjectbyProjectId(int ProjectId);
        NewBaseResponse IndicatorsStrategyForProjectSetup(IndicatorsStrategyForProject request);
        NewBaseResponse DeleteIndicatorsStrategyForProject(int IndicatorsStrategyForProjectId);
        #endregion
        #region ProjectActivity
        //ProjectActivity
        List<ProjectActivity> GetAllProjectActivity();
        List<ProjectActivity> GetProjectActivitybyId(int ProjectActivityId);
        List<ProjectActivity> GetProjectActivityforProjectbyId(int ProjectId);
        List<ProjectActivity> GetProjectActivityfromSubProjectId(int SubProjectId);
        NewBaseResponse ProjectActivitySetup(ProjectActivity request);
        NewBaseResponse DeleteProjectActivity(int ProjectActivityId);
        #endregion
        #region ProjectActivityResponsiblePerson
        //ProjectActivityResponsiblePerson
        List<ProjectActivityResponsiblePerson> GetAllProjectActivityResponsiblePerson();
        List<ProjectActivityResponsiblePerson> GetProjectActivityResponsiblePersonbyId(int ProjectActivityResponsiblePersonId);
        List<ProjectActivityResponsiblePerson> GetProjectActivityResponsiblePersonsbyProjectId(int ProjectActivityId);
        NewBaseResponse ProjectActivityResponsiblePersonSetup(ProjectActivityResponsiblePerson request);
        NewBaseResponse DeleteProjectActivityResponsiblePerson(int ProjectActivityResponsiblePersonId);
        #endregion
        #region IndicatorsStrategyForProjectActivity
        //IndicatorsStrategyForProjectActivity
        List<IndicatorsStrategyForProjectActivity> GetAllIndicatorsStrategyForProjectActivity();
        List<IndicatorsStrategyForProjectActivity> GetIndicatorsStrategyForProjectActivitybyId(int IndicatorsStrategyForProjectActivityId);
        List<IndicatorsStrategyForProjectActivity> GetIndicatorsStrategyForProjectActivitybyProjectActivityId(int ProjectActivityId);
        NewBaseResponse IndicatorsStrategyForProjectActivitySetup(IndicatorsStrategyForProjectActivity request);
        NewBaseResponse DeleteIndicatorsStrategyForProjectActivity(int IndicatorsStrategyForProjectActivityId);
        #endregion
        #region SubProject
        //SubProject
        List<SubProject> GetAllSubProject();
        List<SubProject> GetSubProjectbyId(int SubProjectId);
        List<SubProject> GetSubProjectforProjectbyId(int ProjectId);
        NewBaseResponse SubProjectSetup(SubProject request);
        NewBaseResponse DeleteSubProject(int SubProjectId);
        #endregion
        #region SubProjectResponsiblePerson
        //SubProjectResponsiblePerson
        List<SubProjectResponsiblePerson> GetAllSubProjectResponsiblePerson();
        List<SubProjectResponsiblePerson> GetSubProjectResponsiblePersonbyId(int SubProjectResponsiblePersonId);
        List<SubProjectResponsiblePerson> GetSubProjectResponsiblePersonsbySubProjectId(int SubProjectId);
        NewBaseResponse SubProjectResponsiblePersonSetup(SubProjectResponsiblePerson request);
        NewBaseResponse DeleteSubProjectResponsiblePerson(int SubProjectResponsiblePersonId);
        #endregion
        #region IndicatorsStrategyForSubProject
        //IndicatorsStrategyForSubProject
        List<IndicatorsStrategyForSubProject> GetAllIndicatorsStrategyForSubProject();
        List<IndicatorsStrategyForSubProject> GetIndicatorsStrategyForSubProjectbyId(int IndicatorsStrategyForSubProjectId);
        List<IndicatorsStrategyForSubProject> GetIndicatorsStrategyForSubProjectbySubProjectId(int SubProjectId);
        NewBaseResponse IndicatorsStrategyForSubProjectSetup(IndicatorsStrategyForSubProject request);
        NewBaseResponse DeleteIndicatorsStrategyForSubProject(int IndicatorsStrategyForSubProjectId);
        #endregion
        #region ListBudgetForActivity
        //ListBudgetForActivity
        List<ListBudgetForActivity> GetAllListBudgetForActivity();
        List<ListBudgetForActivity> GetListBudgetForActivitybyId(int ListBudgetForActivityId);
        List<ListBudgetForActivity> GetListBudgetForActivitybyProjectActivityId(int ProjectActivityId);
        List<ListBudgetForActivity> GetListBudgetForActivitybysubProjectId(int subProjectId);
        NewBaseResponse ListBudgetForActivitySetup(ListBudgetForActivity request);
        NewBaseResponse DeleteListBudgetForActivity(int ListBudgetForActivityId);
        #endregion
        #region BudgetDisbursementPlan
        //BudgetDisbursementPlan
        List<BudgetDisbursementPlan> GetAllBudgetDisbursementPlan();
        List<BudgetDisbursementPlan> GetBudgetDisbursementPlanbyId(int BudgetDisbursementPlanId);
        NewBaseResponse BudgetDisbursementPlanSetup(BudgetDisbursementPlan request);
        NewBaseResponse DeleteBudgetDisbursementPlan(int BudgetDisbursementPlanId);
        #endregion
    }
}
