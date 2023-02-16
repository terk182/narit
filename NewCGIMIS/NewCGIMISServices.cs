using App.NewCGIMIS.Dtos;
using App.NewCGIMIS.Models.Requests;
using App.NewCGIMIS.Responses;
using Microsoft.EntityFrameworkCore;
using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.NewCGIMIS
{
    public class NewCGIMISServices : INewCGIMISServices
    {
        private readonly NARIT_MIS_LINKContext _database;
        public NewCGIMISServices(NARIT_MIS_LINKContext context)
        {
            _database = context;
        }
        ///////////////////////new new new by ardin/////////////////////////////
        #region MainGovtStatement
        //MainGovtStatement
        public List<MainGovtStatement> GetAllMainGovtStatement()
        {
            return _database.MainGovtStatements.Where(x => x.Active).ToList();
        }
        public List<MainGovtStatement> GetMainGovtStatementbyFisicalYear(int FisicalYear)
        {
            var data = _database.MainGovtStatements.Where(x => x.FiscalYear == FisicalYear && x.Active).ToList();
            return data;
        }
        public List<MainGovtStatement> GetMainGovtStatementbyId(int MainGovtStatementId)
        {
            var data = _database.MainGovtStatements.Where(x => x.Id == MainGovtStatementId && x.Active).ToList();
            return data;
        }
        public NewBaseResponse MainGovtStatementSetup(MainGovtStatement request)
        {
            _database.Entry(request).State = request.Id == 0 ?
                           EntityState.Added :
                           EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new NewBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = request.Id == 0 ? "update" : "insert";
            return response;
        }
        public NewBaseResponse DeleteMainGovtStatement(int MainGovtStatementId)
        {
            var response = new NewBaseResponse();
            var data = _database.MainGovtStatements.Where(x => x.Id == MainGovtStatementId).FirstOrDefault();
            if (data != null)
            {
                data.Active = false;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delete Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }
        #endregion
        #region GovtStrategic
        //GovtStrategic
        public List<GovtStrategic> GetAllGovtStrategic()
        {
            return _database.GovtStrategics.Where(x => x.Active).ToList();
        }
        public List<GovtStrategic> GetGovtStrategicbyId(int GovtStrategicId)
        {
            var data = _database.GovtStrategics.Where(x => x.Id == GovtStrategicId && x.Active).ToList();
            return data;
        }
        public NewBaseResponse GovtStrategicSetup(GovtStrategic request)
        {
            _database.Entry(request).State = request.Id == 0 ?
                           EntityState.Added :
                           EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new NewBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = request.Id == 0 ? "update" : "insert";
            return response;
        }
        public NewBaseResponse DeleteGovtStrategic(int GovtStrategicId)
        {
            var response = new NewBaseResponse();
            var data = _database.GovtStrategics.Where(x => x.Id == GovtStrategicId).FirstOrDefault();
            if (data != null)
            {
                data.Active = false;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delete Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }
        #endregion
        #region GovtPlan
        //GovtPlan
        public List<GovtPlan> GetAllGovtPlan()
        {
            return _database.GovtPlans.Where(x => x.Active).ToList();
        }
        public List<GovtPlan> GetGovtPlanbyId(int GovtPlanId)
        {
            var data = _database.GovtPlans.Where(x => x.Id == GovtPlanId && x.Active).ToList();
            return data;
        }
        public NewBaseResponse GovtPlanSetup(GovtPlan request)
        {
            _database.Entry(request).State = request.Id == 0 ?
                           EntityState.Added :
                           EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new NewBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = request.Id == 0 ? "update" : "insert";
            return response;
        }
        public NewBaseResponse DeleteGovtPlan(int GovtPlanId)
        {
            var response = new NewBaseResponse();
            var data = _database.GovtPlans.Where(x => x.Id == GovtPlanId).FirstOrDefault();
            if (data != null)
            {
                data.Active = false;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delete Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }
        #endregion
        #region MainProject
        //MainProject
        public List<MainProject> GetAllMainProject()
        {
            return _database.MainProjects.Where(x => x.Active).ToList();
        }
        public List<MainProject> GetMainProjectbyId(int MainProjectId)
        {
            var data = _database.MainProjects.Where(x => x.Id == MainProjectId && x.Active).ToList();
            return data;
        }
        public NewBaseResponse MainProjectSetup(MainProject request)
        {
            _database.Entry(request).State = request.Id == 0 ?
                           EntityState.Added :
                           EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new NewBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = request.Id == 0 ? "update" : "insert";
            return response;
        }
        public NewBaseResponse DeleteMainProject(int MainProjectId)
        {
            var response = new NewBaseResponse();
            var data = _database.MainProjects.Where(x => x.Id == MainProjectId).FirstOrDefault();
            if (data != null)
            {
                data.Active = false;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delete Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }
        #endregion
        #region MainActivity
        //MainActivity
        public List<MainActivity> GetAllMainActivity()
        {
            return _database.MainActivities.Where(x => x.Active).ToList();
        }
        public List<MainActivity> GetMainActivitybyId(int MainActivityId)
        {
            var data = _database.MainActivities.Where(x => x.Id == MainActivityId && x.Active).ToList();
            return data;
        }
        public NewBaseResponse MainActivitySetup(MainActivity request)
        {
            _database.Entry(request).State = request.Id == 0 ?
                           EntityState.Added :
                           EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new NewBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = request.Id == 0 ? "update" : "insert";
            return response;
        }
        public NewBaseResponse DeleteMainActivity(int MainActivityId)
        {
            var response = new NewBaseResponse();
            var data = _database.MainActivities.Where(x => x.Id == MainActivityId).FirstOrDefault();
            if (data != null)
            {
                data.Active = false;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delete Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }
        #endregion
        #region ScheduleFisicalYears
        //ScheduleFisicalYears
        public List<ScheduleFisicalYear> GetScheduleFisicalYear()
        {
            return _database.ScheduleFisicalYears.ToList();
        }
        public List<ScheduleFisicalYear> GetScheduleFisicalYearbyYear(int year)
        {
            var stringyear = year.ToString();
            return _database.ScheduleFisicalYears.Where(x => x.Name == stringyear).ToList();
        }
        public NewBaseResponse EditScheduleFisicalYear(string name, bool active)
        {
            NewBaseResponse response = new NewBaseResponse();
            List<ScheduleFisicalYear> scheduleFisicalYear = _database.ScheduleFisicalYears.OrderByDescending(x => x.Name).ToList();
            if (name == null)
            {
                scheduleFisicalYear.ForEach(item =>
                {
                    item.Active = false;
                    item.AddPlanCoreStatus = false;
                    item.EditPlanCoreStatus = false;
                    item.ApprovePlanCoreStatus = false;
                    item.DisplayPlanCoreStatus = false;
                });
            }
            else
            {
                scheduleFisicalYear.ForEach(item =>
                {
                    if (item.Name == name)
                    {
                        item.Active = active;
                        item.AddPlanCoreStatus = active;
                        item.EditPlanCoreStatus = active;
                        item.ApprovePlanCoreStatus = active;
                        item.DisplayPlanCoreStatus = active;
                    }
                    else
                    {
                        item.Active = false;
                        item.AddPlanCoreStatus = false;
                        item.EditPlanCoreStatus = false;
                        item.ApprovePlanCoreStatus = false;
                        item.DisplayPlanCoreStatus = false;
                    }
                });
                scheduleFisicalYear.ForEach(items =>
                {
                    _database.Entry(items).State = EntityState.Modified;
                    var returnValue = _database.SaveChanges();
                    response.Success = returnValue > 0 ? true : false;
                    response.Messsage = "Success";
                });
            }
            return response;
        }
        public NewBaseResponse ScheduleFisicalYearSetUp(ScheduleFisicalYear Request)
        {
            _database.Entry(Request).State = Request.Id == 0 ?
                                       EntityState.Added :
                                       EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new NewBaseResponse();
            response.Success = result > 0 ? true : false;
            return response;
        }
        #endregion
        #region StrategicIssue
        //StrategicIssue
        public List<StrategicIssue> GetAllStrategicIssue()
        {
            return _database.StrategicIssues.Where(x => x.Active).ToList();
        }
        public List<StrategicIssue> GetStrategicIssuebyId(int StrategicIssueId)
        {
            var data = _database.StrategicIssues.Where(x => x.Id == StrategicIssueId && x.Active).ToList();
            return data;
        }
        public NewBaseResponse StrategicIssueSetup(StrategicIssue request)
        {
            _database.Entry(request).State = request.Id == 0 ?
                           EntityState.Added :
                           EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new NewBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = request.Id == 0 ? "update" : "insert";
            return response;
        }
        public NewBaseResponse DeleteStrategicIssue(int StrategicIssueId)
        {
            var response = new NewBaseResponse();
            var data = _database.StrategicIssues.Where(x => x.Id == StrategicIssueId).FirstOrDefault();
            if (data != null)
            {
                data.Active = false;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delete Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }
        #endregion
        #region ExternalBudgetStrategy
        //ExternalBudgetStrategy
        public List<ExternalBudgetStrategy> GetAllExternalBudgetStrategy()
        {
            return _database.ExternalBudgetStrategies.Where(x => x.Active).ToList();
        }
        public List<ExternalBudgetStrategy> GetExternalBudgetStrategybyFisicalYear(int FisicalYear)
        {
            var data = _database.ExternalBudgetStrategies.Where(x => x.FiscalYear == FisicalYear && x.Active).ToList();
            return data;
        }

        public List<ExternalBudgetStrategy> GetExternalBudgetStrategybyId(int ExternalBudgetStrategyId)
        {
            var data = _database.ExternalBudgetStrategies.Where(x => x.Id == ExternalBudgetStrategyId && x.Active).ToList();
            return data;
        }
        public NewBaseResponse ExternalBudgetStrategySetup(ExternalBudgetStrategy request)
        {
            _database.Entry(request).State = request.Id == 0 ?
                           EntityState.Added :
                           EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new NewBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = request.Id == 0 ? "update" : "insert";
            return response;
        }
        public NewBaseResponse DeleteExternalBudgetStrategy(int ExternalBudgetStrategyId)
        {
            var response = new NewBaseResponse();
            var data = _database.ExternalBudgetStrategies.Where(x => x.Id == ExternalBudgetStrategyId).FirstOrDefault();
            if (data != null)
            {
                data.Active = false;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delete Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }
        #endregion
        #region InternalStrategy
        //InternalStrategy
        public List<InternalStrategy> GetAllInternalStrategy()
        {
            return _database.InternalStrategies.Where(x => x.Active).ToList();
        }
        public List<InternalStrategy> GetInternalStrategybyFisicalYear(int FisicalYear)
        {
            var data = _database.InternalStrategies.Where(x => x.FiscalYear == FisicalYear && x.Active).ToList();
            return data;
        }
        public List<InternalStrategy> GetInternalStrategybyId(int InternalStrategyId)
        {
            var data = _database.InternalStrategies.Where(x => x.Id == InternalStrategyId && x.Active).ToList();
            return data;
        }
        public NewBaseResponse InternalStrategySetup(InternalStrategy request)
        {
            _database.Entry(request).State = request.Id == 0 ?
                           EntityState.Added :
                           EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new NewBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = request.Id == 0 ? "update" : "insert";
            return response;
        }
        public NewBaseResponse DeleteInternalStrategy(int InternalStrategyId)
        {
            var response = new NewBaseResponse();
            var data = _database.InternalStrategies.Where(x => x.Id == InternalStrategyId).FirstOrDefault();
            if (data != null)
            {
                data.Active = false;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delete Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }
        #endregion
        #region PlanType
        //PlanType
        public List<NewPlanTypeDto> PlanTypeGetAll()
        {
            var data = _database.PlanTypes.Where(x => x.Active);
            var result = new List<NewPlanTypeDto>();
            foreach (var item in data)
            {
                result.Add(new NewPlanTypeDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    FiscalYear = item.FiscalYear,
                    Active = item.Active,
                    ParentPlanTypeId = item.ParentPlanTypeId,
                    ReferenceOldId = item.ReferenceOldId,
                    Weight = item.Weight,
                });


            }
            return result;
        }
        public List<NewPlanTypeDto> PlanTypeGetByFiscalYear(int FiscalYear)
        {
            var _PlanTypes = _database.PlanTypes.Where(x => x.FiscalYear == FiscalYear && x.Active).ToList();
            var _PlanTypes_start = _PlanTypes.Where(x => x.ParentPlanTypeId == null).ToList();
            var _PlanTypeDto_list = new List<NewPlanTypeDto>();

            foreach (var item in _PlanTypes_start)
            {
                var _PlanTypeDto_list_sub = new List<NewPlanTypeDto>();
                var _PlanTypesSub = _database.PlanTypes.Where(x => x.ParentPlanTypeId == item.Id && x.Active);



                foreach (var subPlanType in _PlanTypesSub)
                {
                    _PlanTypeDto_list_sub.Add(new NewPlanTypeDto
                    {
                        Id = subPlanType.Id,
                        Name = subPlanType.Name,
                        FiscalYear = subPlanType.FiscalYear,
                        Active = subPlanType.Active,
                        ParentPlanTypeId = subPlanType.ParentPlanTypeId,
                        ReferenceOldId = subPlanType.ReferenceOldId,
                        Weight = subPlanType.Weight,

                    });
                }

                _PlanTypeDto_list.Add(new NewPlanTypeDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    FiscalYear = item.FiscalYear,
                    Active = item.Active,
                    ParentPlanTypeId = item.ParentPlanTypeId,
                    ReferenceOldId = item.ReferenceOldId,
                    Weight = item.Weight,
                    planType = _PlanTypeDto_list_sub


                });
            }
            return _PlanTypeDto_list;
        }
        public List<NewPlanTypeDto> PlanTypeGetByFiscalYearandPlanTypeid(int FiscalYear, int id)
        {

            var result = new List<NewPlanTypeDto>();
            var data = _database.PlanTypes.Where(x => x.FiscalYear == FiscalYear & x.ParentPlanTypeId == id).ToList();
            foreach (var item in data)
            {
                result.Add(new NewPlanTypeDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    FiscalYear = item.FiscalYear,
                    Active = item.Active,
                    ParentPlanTypeId = item.ParentPlanTypeId,
                    ReferenceOldId = item.ReferenceOldId,
                    Weight = item.Weight
                });

            }
            return result;
        }
        public List<NewPlanTypeDto> PlanTypeDetailGetByPlanTypeid(int id)
        {

            var result = new List<NewPlanTypeDto>();
            var data = _database.PlanTypes.Where(x => x.Id == id && x.Active).ToList();
            foreach (var item in data)
            {
                result.Add(new NewPlanTypeDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    FiscalYear = item.FiscalYear,
                    Active = item.Active,
                    ParentPlanTypeId = item.ParentPlanTypeId,
                    ReferenceOldId = item.ReferenceOldId,
                    Weight = item.Weight
                });

            }
            return result;
        }
        public List<NewPlanTypeDto> PlanTypeNameGetByPlanTypeid(int id)
        {

            var result = new List<NewPlanTypeDto>();
            var data = _database.PlanTypes.Where(x => x.Id == id).ToList();
            foreach (var item in data)
            {
                result.Add(new NewPlanTypeDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    FiscalYear = item.FiscalYear,
                    Active = item.Active,
                    ParentPlanTypeId = item.ParentPlanTypeId,
                    ReferenceOldId = item.ReferenceOldId,
                    Weight = item.Weight
                });

            }
            return result;
        }
        public NewBaseResponse PlanTypeSetup(NewPlanTypeRequest request)
        {
            var _PlanType = new PlanType();
            _PlanType.Id = request.Id;
            _PlanType.Name = request.Name;
            _PlanType.FiscalYear = request.FiscalYear;
            _PlanType.Active = request.Active;
            if (request.ParentPlanTypeId != 0)
            {
                _PlanType.ParentPlanTypeId = request.ParentPlanTypeId;
            }
            _database.Entry(_PlanType).State = _PlanType.Id == 0 ?
                                      EntityState.Added :
                                      EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new NewBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = _PlanType.Id == 0 ? "update" : "insert";
            return response;
        }
        public NewBaseResponse DeletePlanType(int PlanTypeId)
        {
            var response = new NewBaseResponse();
            var data = _database.PlanTypes.Where(x => x.Id == PlanTypeId).FirstOrDefault();
            if (data != null)
            {
                data.Active = false;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delete Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }
        #endregion
        #region Mission
        //Mission
        public List<Mission> MissionSetupByFiscalYear(int FiscalYear)
        {
            var data = _database.Missions.Where(x => x.FiscalYear == FiscalYear & x.Active).ToList();
            return data;
        }
        public NewBaseResponse MissionSetup(Mission request)
        {
            _database.Entry(request).State = request.Id == 0 ?
                           EntityState.Added :
                           EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new NewBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = request.Id == 0 ? "update" : "insert";
            return response;
        }
        public NewBaseResponse DeleteMission(int MissionId)
        {
            var response = new NewBaseResponse();
            var data = _database.InternalStrategies.Where(x => x.Id == MissionId).FirstOrDefault();
            if (data != null)
            {
                data.Active = false;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delete Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }
        #endregion
        #region Department
        //Department
        public List<Department> GetAllDepartment()
        {
            return _database.Departments.Where(x => x.Active).ToList();
        }
        public List<Department> GetDepartmentbyFisicalYear(int FisicalYear)
        {
            var data = _database.Departments.Where(x => x.FiscalYear == FisicalYear && x.Active).ToList();
            return data;
        }
        public List<Department> GetDepartmentbyId(int DepartmentId)
        {
            var data = _database.Departments.Where(x => x.Id == DepartmentId && x.Active).ToList();
            return data;
        }
        public NewBaseResponse DepartmentSetup(Department request)
        {
            _database.Entry(request).State = request.Id == 0 ?
                           EntityState.Added :
                           EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new NewBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = request.Id == 0 ? "update" : "insert";
            return response;
        }
        public NewBaseResponse DeleteDepartment(int DepartmentId)
        {
            var response = new NewBaseResponse();
            var data = _database.Departments.Where(x => x.Id == DepartmentId).FirstOrDefault();
            if (data != null)
            {
                data.Active = false;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delete Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }
        #endregion
        #region AnnualBudget
        //AnnualBudget
        public List<AnnualBudget> GetAllAnnualBudget()
        {
            return _database.AnnualBudgets.Where(x => x.Active).ToList();
        }
        public List<AnnualBudget> GetAnnualBudgetbyFisicalYear(int FisicalYear)
        {
            var data = _database.AnnualBudgets.Where(x => x.FiscalYear == FisicalYear && x.Active).ToList();
            return data;
        }
        public List<AnnualBudget> GetAnnualBudgetbyId(int AnnualBudgetId)
        {
            var data = _database.AnnualBudgets.Where(x => x.Id == AnnualBudgetId && x.Active).ToList();
            return data;
        }
        public NewBaseResponse AnnualBudgetSetup(AnnualBudget request)
        {
            _database.Entry(request).State = request.Id == 0 ?
                           EntityState.Added :
                           EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new NewBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = request.Id == 0 ? "update" : "insert";
            return response;
        }
        public NewBaseResponse DeleteAnnualBudget(int AnnualBudgetId)
        {
            var response = new NewBaseResponse();
            var data = _database.AnnualBudgets.Where(x => x.Id == AnnualBudgetId).FirstOrDefault();
            if (data != null)
            {
                data.Active = false;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delete Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }
        #endregion
        #region SubAnnualBudget
        //SubAnnualBudget
        public List<SubAnnualBudget> GetAllSubAnnualBudget()
        {
            return _database.SubAnnualBudgets.Where(x => x.Active).ToList();
        }
        public List<SubAnnualBudget> GetSubAnnualBudgetbyFisicalYear(int FisicalYear)
        {
            var data = _database.SubAnnualBudgets.Where(x => x.FiscalYear == FisicalYear && x.Active).ToList();
            return data;
        }
        public List<SubAnnualBudget> GetSubAnnualBudgetbyId(int SubAnnualBudgetId)
        {
            var data = _database.SubAnnualBudgets.Where(x => x.Id == SubAnnualBudgetId && x.Active).ToList();
            return data;
        }
        public NewBaseResponse SubAnnualBudgetSetup(SubAnnualBudget request)
        {
            _database.Entry(request).State = request.Id == 0 ?
                           EntityState.Added :
                           EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new NewBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = request.Id == 0 ? "update" : "insert";
            return response;
        }
        public NewBaseResponse DeleteSubAnnualBudget(int SubAnnualBudgetId)
        {
            var response = new NewBaseResponse();
            var data = _database.SubAnnualBudgets.Where(x => x.Id == SubAnnualBudgetId).FirstOrDefault();
            if (data != null)
            {
                data.Active = false;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delete Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }
        #endregion
        #region CapticalType
        //CapticalType
        public List<CapticalType> GetAllCapticalType()
        {
            return _database.CapticalTypes.Where(x => x.Active).ToList();
        }
        public List<CapticalType> GetCapticalTypebyFisicalYear(int FisicalYear)
        {
            var data = _database.CapticalTypes.Where(x => x.FiscalYear == FisicalYear && x.Active).ToList();
            return data;
        }
        public List<CapticalType> GetCapticalTypebyId(int CapticalTypeId)
        {
            var data = _database.CapticalTypes.Where(x => x.Id == CapticalTypeId && x.Active).ToList();
            return data;
        }
        public NewBaseResponse CapticalTypeSetup(CapticalType request)
        {
            _database.Entry(request).State = request.Id == 0 ?
                           EntityState.Added :
                           EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new NewBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = request.Id == 0 ? "update" : "insert";
            return response;
        }
        public NewBaseResponse DeleteCapticalType(int CapticalTypeId)
        {
            var response = new NewBaseResponse();
            var data = _database.CapticalTypes.Where(x => x.Id == CapticalTypeId).FirstOrDefault();
            if (data != null)
            {
                data.Active = false;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delete Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }
        #endregion
        #region Project
        //Project
        public List<Project> GetAllProject()
        {
            return _database.Projects.Where(x => x.Active).ToList();
        }
        public List<Project> GetProjectbyFisicalYear(int FisicalYear)
        {
            var data = _database.Projects.Where(x => x.FiscalYear == FisicalYear && x.Active).ToList();
            return data;
        }
        public List<Project> GetProjectbyId(int ProjectId)
        {
            var data = _database.Projects.Where(x => x.Id == ProjectId && x.Active).ToList();
            return data;
        }

        public NewBaseResponse GetsubProjectorProjectActivitybyProjectId(int ProjectId)
        {
            var response = new NewBaseResponse();
            var data = _database.SubProjects.Where(x => x.ProjectId == ProjectId && x.Active).ToList();
            var data2 = _database.ProjectActivities.Where(x => x.ProjectId == ProjectId && x.ProjectStatus == 0 && x.Active).ToList();
            if (data.Count != 0)
            {
                GetSubProjectforProjectbyId(ProjectId);
                response.Success = true;
                response.Messsage = "Have SubProject";
                response.Data = data;
            }
            else
            {
                GetProjectActivityforProjectbyId(ProjectId);
                response.Success = true;
                response.Messsage = "Have ProjectActivity";
                response.Data = data2;
            }
            return response;
        }
        public NewBaseResponse ProjectSetup(Project request)
        {
            _database.Entry(request).State = request.Id == 0 ?
                           EntityState.Added :
                           EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new NewBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = request.Id == 0 ? "update" : "insert";
            return response;
        }
        public NewBaseResponse DeleteProject(int ProjectId)
        {
            var response = new NewBaseResponse();
            var data = _database.Projects.Where(x => x.Id == ProjectId).FirstOrDefault();
            if (data != null)
            {
                data.Active = false;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delete Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }
        #endregion 
        #region ProjectCaptical
        //ProjectCaptical
        public List<ProjectCaptical> GetAllProjectCaptical()
        {
            return _database.ProjectCapticals.Where(x => x.Active).ToList();
        }
        public List<ProjectCaptical> GetProjectCapticalbyId(int ProjectCapticalId)
        {
            var data = _database.ProjectCapticals.Where(x => x.Id == ProjectCapticalId && x.Active).ToList();
            return data;
        }
        public NewBaseResponse ProjectCapticalSetup(ProjectCaptical request)
        {
            _database.Entry(request).State = request.Id == 0 ?
                           EntityState.Added :
                           EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new NewBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = request.Id == 0 ? "update" : "insert";
            return response;
        }
        public NewBaseResponse DeleteProjectCaptical(int ProjectCapticalId)
        {
            var response = new NewBaseResponse();
            var data = _database.ProjectCapticals.Where(x => x.Id == ProjectCapticalId).FirstOrDefault();
            if (data != null)
            {
                data.Active = false;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delete Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }
        #endregion
        #region ProjectResponsiblePerson
        //ProjectResponsiblePerson
        public List<ProjectResponsiblePerson> GetAllProjectResponsiblePersons()
        {
            return _database.ProjectResponsiblePersons.Where(x => x.Active).ToList();
        }
        public List<ProjectResponsiblePerson> GetProjectResponsiblePersonsbyId(int ProjectResponsiblePersonsId)
        {
            var data = _database.ProjectResponsiblePersons.Where(x => x.Id == ProjectResponsiblePersonsId && x.Active).ToList();
            return data;
        }
        public List<ProjectResponsiblePerson> GetProjectResponsiblePersonsbyProjectId(int ProjectId)
        {
            var data = _database.ProjectResponsiblePersons.Where(x => x.ProjectId == ProjectId && x.Active).ToList();
            return data;
        }
        public NewBaseResponse ProjectResponsiblePersonsSetup(ProjectResponsiblePerson request)
        {
            _database.Entry(request).State = request.Id == 0 ?
                           EntityState.Added :
                           EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new NewBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = request.Id == 0 ? "update" : "insert";
            return response;
        }
        public NewBaseResponse DeleteProjectResponsiblePersons(int ProjectResponsiblePersonsId)
        {
            var response = new NewBaseResponse();
            var data = _database.ProjectResponsiblePersons.Where(x => x.Id == ProjectResponsiblePersonsId).FirstOrDefault();
            if (data != null)
            {
                data.Active = false;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delete Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }
        #endregion
        #region IndicatorsStrategyForProject
        //IndicatorsStrategyForProject
        public List<IndicatorsStrategyForProject> GetAllIndicatorsStrategyForProject()
        {
            return _database.IndicatorsStrategyForProjects.Where(x => x.Active).ToList();
        }
        public List<IndicatorsStrategyForProject> GetIndicatorsStrategyForProjectbyId(int IndicatorsStrategyForProjectId)
        {
            var data = _database.IndicatorsStrategyForProjects.Where(x => x.Id == IndicatorsStrategyForProjectId && x.Active).ToList();
            return data;
        }
        public List<IndicatorsStrategyForProject> GetIndicatorsStrategyForProjectbyProjectId(int ProjectId)
        {
            var data = _database.IndicatorsStrategyForProjects.Where(x => x.ProjectId == ProjectId && x.Active).ToList();
            return data;
        }
        public NewBaseResponse IndicatorsStrategyForProjectSetup(IndicatorsStrategyForProject request)
        {
            _database.Entry(request).State = request.Id == 0 ?
                           EntityState.Added :
                           EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new NewBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = request.Id == 0 ? "update" : "insert";
            return response;
        }
        public NewBaseResponse DeleteIndicatorsStrategyForProject(int IndicatorsStrategyForProjectId)
        {
            var response = new NewBaseResponse();
            var data = _database.IndicatorsStrategyForProjects.Where(x => x.Id == IndicatorsStrategyForProjectId).FirstOrDefault();
            if (data != null)
            {
                data.Active = false;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delete Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }
        #endregion
        #region ProjectActivity
        //ProjectActivity
        public List<ProjectActivity> GetAllProjectActivity()
        {
            return _database.ProjectActivities.Where(x => x.Active).ToList();
        }

        public List<ProjectActivity> GetProjectActivitybyId(int ProjectActivityId)
        {
            var data = _database.ProjectActivities.Where(x => x.Id == ProjectActivityId && x.Active).ToList();
            return data;
        }
        public List<ProjectActivity> GetProjectActivityforProjectbyId(int ProjectId)
        {
            var data = _database.ProjectActivities.Where(x => x.ProjectId == ProjectId && x.ProjectStatus == 0 && x.Active).ToList();
            return data;
        }
        public List<ProjectActivity> GetProjectActivityfromSubProjectId(int SubProjectId)
        {
            var data = _database.ProjectActivities.Where(x => x.ProjectId == SubProjectId && x.ProjectStatus == 1 && x.Active).ToList();
            return data;
        }
        public NewBaseResponse ProjectActivitySetup(ProjectActivity request)
        {
            _database.Entry(request).State = request.Id == 0 ?
                           EntityState.Added :
                           EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new NewBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = request.Id == 0 ? "update" : "insert";
            return response;
        }
        public NewBaseResponse DeleteProjectActivity(int ProjectActivityId)
        {
            var response = new NewBaseResponse();
            var data = _database.ProjectActivities.Where(x => x.Id == ProjectActivityId).FirstOrDefault();
            if (data != null)
            {
                data.Active = false;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delete Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }
        #endregion
        #region ProjectActivityResponsiblePerson
        //ProjectActivityResponsiblePerson
        public List<ProjectActivityResponsiblePerson> GetAllProjectActivityResponsiblePerson()
        {
            return _database.ProjectActivityResponsiblePersons.Where(x => x.Active).ToList();
        }
        public List<ProjectActivityResponsiblePerson> GetProjectActivityResponsiblePersonbyId(int ProjectActivityResponsiblePersonId)
        {
            var data = _database.ProjectActivityResponsiblePersons.Where(x => x.Id == ProjectActivityResponsiblePersonId && x.Active).ToList();
            return data;
        }
        public List<ProjectActivityResponsiblePerson> GetProjectActivityResponsiblePersonsbyProjectId(int ProjectActivityId)
        {
            var data = _database.ProjectActivityResponsiblePersons.Where(x => x.ProjectActivityId == ProjectActivityId && x.Active).ToList();
            return data;
        }
        public NewBaseResponse ProjectActivityResponsiblePersonSetup(ProjectActivityResponsiblePerson request)
        {
            _database.Entry(request).State = request.Id == 0 ?
                           EntityState.Added :
                           EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new NewBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = request.Id == 0 ? "update" : "insert";
            return response;
        }
        public NewBaseResponse DeleteProjectActivityResponsiblePerson(int ProjectActivityResponsiblePersonId)
        {
            var response = new NewBaseResponse();
            var data = _database.ProjectActivityResponsiblePersons.Where(x => x.Id == ProjectActivityResponsiblePersonId).FirstOrDefault();
            if (data != null)
            {
                data.Active = false;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delete Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }
        #endregion
        #region IndicatorsStrategyForProjectActivity
        //IndicatorsStrategyForProjectActivity
        public List<IndicatorsStrategyForProjectActivity> GetAllIndicatorsStrategyForProjectActivity()
        {
            return _database.IndicatorsStrategyForProjectActivities.Where(x => x.Active).ToList();
        }
        public List<IndicatorsStrategyForProjectActivity> GetIndicatorsStrategyForProjectActivitybyId(int IndicatorsStrategyForProjectActivityId)
        {
            var data = _database.IndicatorsStrategyForProjectActivities.Where(x => x.Id == IndicatorsStrategyForProjectActivityId && x.Active).ToList();
            return data;
        }
        public List<IndicatorsStrategyForProjectActivity> GetIndicatorsStrategyForProjectActivitybyProjectActivityId(int ProjectActivityId)
        {
            var data = _database.IndicatorsStrategyForProjectActivities.Where(x => x.ProjectActivityId == ProjectActivityId && x.Active).ToList();
            return data;
        }
        public NewBaseResponse IndicatorsStrategyForProjectActivitySetup(IndicatorsStrategyForProjectActivity request)
        {
            _database.Entry(request).State = request.Id == 0 ?
                           EntityState.Added :
                           EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new NewBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = request.Id == 0 ? "update" : "insert";
            return response;
        }
        public NewBaseResponse DeleteIndicatorsStrategyForProjectActivity(int IndicatorsStrategyForProjectActivityId)
        {
            var response = new NewBaseResponse();
            var data = _database.IndicatorsStrategyForProjectActivities.Where(x => x.Id == IndicatorsStrategyForProjectActivityId).FirstOrDefault();
            if (data != null)
            {
                data.Active = false;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delete Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }
        #endregion
        #region SubProject
        //SubProject
        public List<SubProject> GetAllSubProject()
        {
            return _database.SubProjects.Where(x => x.Active).ToList();
        }

        public List<SubProject> GetSubProjectbyId(int SubProjectId)
        {
            var data = _database.SubProjects.Where(x => x.Id == SubProjectId && x.Active).ToList();
            return data;
        }
        public List<SubProject> GetSubProjectforProjectbyId(int ProjectId)
        {
            var data = _database.SubProjects.Where(x => x.ProjectId == ProjectId && x.Active).ToList();
            return data;
        }
        public NewBaseResponse SubProjectSetup(SubProject request)
        {
            _database.Entry(request).State = request.Id == 0 ?
                           EntityState.Added :
                           EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new NewBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = request.Id == 0 ? "update" : "insert";
            return response;
        }
        public NewBaseResponse DeleteSubProject(int ProjectId)
        {
            var response = new NewBaseResponse();
            var data = _database.SubProjects.Where(x => x.Id == ProjectId).FirstOrDefault();
            if (data != null)
            {
                data.Active = false;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delete Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }
        #endregion
        #region SubProjectResponsiblePerson
        //SubProjectResponsiblePerson
        public List<SubProjectResponsiblePerson> GetAllSubProjectResponsiblePerson()
        {
            return _database.SubProjectResponsiblePersons.Where(x => x.Active).ToList();
        }
        public List<SubProjectResponsiblePerson> GetSubProjectResponsiblePersonbyId(int SubProjectResponsiblePersonId)
        {
            var data = _database.SubProjectResponsiblePersons.Where(x => x.Id == SubProjectResponsiblePersonId && x.Active).ToList();
            return data;
        }
        public List<SubProjectResponsiblePerson> GetSubProjectResponsiblePersonsbySubProjectId(int SubProjectId)
        {
            var data = _database.SubProjectResponsiblePersons.Where(x => x.SubProjectId == SubProjectId && x.Active).ToList();
            return data;
        }
        public NewBaseResponse SubProjectResponsiblePersonSetup(SubProjectResponsiblePerson request)
        {
            _database.Entry(request).State = request.Id == 0 ?
                           EntityState.Added :
                           EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new NewBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = request.Id == 0 ? "update" : "insert";
            return response;
        }
        public NewBaseResponse DeleteSubProjectResponsiblePerson(int SubProjectResponsiblePersonId)
        {
            var response = new NewBaseResponse();
            var data = _database.SubProjectResponsiblePersons.Where(x => x.Id == SubProjectResponsiblePersonId).FirstOrDefault();
            if (data != null)
            {
                data.Active = false;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delete Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }
        #endregion
        #region IndicatorsStrategyForSubProject
        //IndicatorsStrategyForSubProject
        public List<IndicatorsStrategyForSubProject> GetAllIndicatorsStrategyForSubProject()
        {
            return _database.IndicatorsStrategyForSubProjects.Where(x => x.Active).ToList();
        }
        public List<IndicatorsStrategyForSubProject> GetIndicatorsStrategyForSubProjectbyId(int IndicatorsStrategyForSubProjectId)
        {
            var data = _database.IndicatorsStrategyForSubProjects.Where(x => x.Id == IndicatorsStrategyForSubProjectId && x.Active).ToList();
            return data;
        }
        public List<IndicatorsStrategyForSubProject> GetIndicatorsStrategyForSubProjectbySubProjectId(int SubProjectId)
        {
            var data = _database.IndicatorsStrategyForSubProjects.Where(x => x.SubProjectId == SubProjectId && x.Active).ToList();
            return data;
        }
        public NewBaseResponse IndicatorsStrategyForSubProjectSetup(IndicatorsStrategyForSubProject request)
        {
            _database.Entry(request).State = request.Id == 0 ?
                           EntityState.Added :
                           EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new NewBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = request.Id == 0 ? "update" : "insert";
            return response;
        }
        public NewBaseResponse DeleteIndicatorsStrategyForSubProject(int IndicatorsStrategyForSubProjectId)
        {
            var response = new NewBaseResponse();
            var data = _database.IndicatorsStrategyForSubProjects.Where(x => x.Id == IndicatorsStrategyForSubProjectId).FirstOrDefault();
            if (data != null)
            {
                data.Active = false;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delete Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }
        #endregion
        #region ListBudgetForActivity
        //ListBudgetForActivity
        public List<ListBudgetForActivity> GetAllListBudgetForActivity()
        {
            return _database.ListBudgetForActivities.Where(x => x.Active).ToList();
        }
        public List<ListBudgetForActivity> GetListBudgetForActivitybyId(int ListBudgetForActivityId)
        {
            var data = _database.ListBudgetForActivities.Where(x => x.Id == ListBudgetForActivityId && x.Active).ToList();
            return data;
        }
        public List<ListBudgetForActivity> GetListBudgetForActivitybyProjectActivityId(int ProjectActivityId)
        {
            var data = _database.ListBudgetForActivities.Where(x => x.ProjectActivitiyId == ProjectActivityId && x.Active).ToList();
            return data;
        }
        public List<ListBudgetForActivity> GetListBudgetForActivitybysubProjectId(int subProjectId)
        {
            var data = _database.ListBudgetForActivities.Where(x => x.ProjectId == subProjectId && x.Active).ToList();
            return data;
        }
        public NewBaseResponse ListBudgetForActivitySetup(ListBudgetForActivity request)
        {
            _database.Entry(request).State = request.Id == 0 ?
                           EntityState.Added :
                           EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new NewBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = request.Id == 0 ? "update" : "insert";
            return response;
        }
        public NewBaseResponse DeleteListBudgetForActivity(int ListBudgetForActivityId)
        {
            var response = new NewBaseResponse();
            var data = _database.ListBudgetForActivities.Where(x => x.Id == ListBudgetForActivityId).FirstOrDefault();
            if (data != null)
            {
                data.Active = false;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delete Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }
        #endregion
        #region BudgetDisbursementPlan
        //BudgetDisbursementPlan
        public List<BudgetDisbursementPlan> GetAllBudgetDisbursementPlan()
        {
            return _database.BudgetDisbursementPlans.Where(x => x.Active).ToList();
        }
        public List<BudgetDisbursementPlan> GetBudgetDisbursementPlanbyId(int BudgetDisbursementPlanId)
        {
            var data = _database.BudgetDisbursementPlans.Where(x => x.Id == BudgetDisbursementPlanId && x.Active).ToList();
            return data;
        }

        public NewBaseResponse BudgetDisbursementPlanSetup(BudgetDisbursementPlan request)
        {
            _database.Entry(request).State = request.Id == 0 ?
                           EntityState.Added :
                           EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new NewBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = request.Id == 0 ? "update" : "insert";
            return response;
        }
        public NewBaseResponse DeleteBudgetDisbursementPlan(int BudgetDisbursementPlanId)
        {
            var response = new NewBaseResponse();
            var data = _database.BudgetDisbursementPlans.Where(x => x.Id == BudgetDisbursementPlanId).FirstOrDefault();
            if (data != null)
            {
                data.Active = false;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delete Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }
        #endregion
    }
}
