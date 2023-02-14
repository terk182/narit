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
        //MainGovtStatement
        List<MainGovtStatement> GetAllMainGovtStatement();
        List<MainGovtStatement> GetMainGovtStatementbyFisicalYear(int FisicalYear);
        List<MainGovtStatement> GetMainGovtStatementbyId(int MainGovtStatementId);
        NewBaseResponse MainGovtStatementSetup(MainGovtStatement request);
        NewBaseResponse DeleteMainGovtStatement(int MainGovtStatementId);
        ////GovtStrategic
        //List<GovtStrategic> GetAllGovtStrategic();
        //List<GovtStrategic> GetGovtStrategicbyId(int GovtStrategicId);
        //NewBaseResponse GovtStrategicSetup(GovtStrategic request);
        //NewBaseResponse DeleteGovtStrategic(int GovtStrategicId);
        ////GovtPlan
        //List<GovtPlan> GetAllGovtPlan();
        //List<GovtPlan> GetGovtPlanbyId(int GovtPlanId);
        //NewBaseResponse GovtPlanSetup(GovtPlan request);
        //NewBaseResponse DeleteGovtPlan(int GovtPlanId);
        ////MainProject
        //List<MainProject> GetAllMainProject();
        //List<MainProject> GetMainProjectbyId(int MainProjectId);
        //NewBaseResponse MainProjectSetup(MainProject request);
        //NewBaseResponse DeleteMainProject(int MainProjectId);
        ////MainActivity
        //List<MainActivity> GetAllMainActivity();
        //List<MainActivity> GetMainActivitybyId(int MainActivityId);
        //NewBaseResponse MainActivitySetup(MainActivity request);
        //NewBaseResponse DeleteMainActivity(int MainActivityId);
    }
}
