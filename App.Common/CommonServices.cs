using App.Common.Dtos;
using App.Common.Models.Requests;
using App.Common.Models.Responses;
using Microsoft.EntityFrameworkCore;
using narit_mis_api.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace App.Common
{
    public class CommonServices : ICommonServices
    {
        private readonly NARIT_MIS_LINKContext _database;

        public CommonServices(NARIT_MIS_LINKContext context)
        {
            _database = context;
        }

        public CommonBaseResponse EditMisGeneralExpenseMemoFormsSignList(MisGeneralExpenseMemoFormsSignListDto request)
        {

            //_database.Entry(request).State = request.action == 0 ?
            //                           EntityState.Added :
            //                           EntityState.Modified;

            int  result = 0;
            foreach (var item in request.GeneralExpenseMemoFormsSignList)
            {
                _database.Entry(item).State = request.action == 0 ?
                                         EntityState.Added :
                                         EntityState.Modified;


                 result = _database.SaveChanges();
            }
          
            var response = new CommonBaseResponse();
            response.Success = result > 0 ? true : false;
            return response;
        }

        public CommonBaseResponse GeFormActionLog(GeFormActionLogsRequests GeFormActionLog)
        {
            var db = new GeFormActionLog();
            db.Id = GeFormActionLog.Id;
            db.Name = GeFormActionLog.Name;
            db.Active = GeFormActionLog.Active;
            db.StaffId = GeFormActionLog.StaffId;
            db.ActionDate = GeFormActionLog.ActionDate;
            db.Ip = GeFormActionLog.Ip;
            db.HostName = GeFormActionLog.HostName;
            db.ActionTypeEnum = GeFormActionLog.ActionTypeEnum;
            db.StaffName = GeFormActionLog.StaffName;
            db.ClientName = GeFormActionLog.ClientName;
            db.GeneralExpenseMemoFormId = GeFormActionLog.GeneralExpenseMemoFormId;
            db.SignedHashText = GeFormActionLog.SignedHashText;
            db.VerifyData = GeFormActionLog.VerifyData;
            db.SignedHashValue = GeFormActionLog.SignedHashValue;
            db.CipherKeyPairId = GeFormActionLog.CipherKeyPairId;
            db.Jwtpayload = GeFormActionLog.Jwtpayload;
            db.Detail = GeFormActionLog.Detail;
            int result = 0;

            _database.Entry(db).State = EntityState.Added;
            result = _database.SaveChanges();
            var response = new CommonBaseResponse();
            response.Success = result > 0 ? true : false;
            return response;
        }

        public List<GeFormActionLog> GeFormActionLog(int GeneralExpenseMemoFormId)
        {
            var data = _database.GeFormActionLogs.Where(x => x.GeneralExpenseMemoFormId == GeneralExpenseMemoFormId).ToList();
            return data;
        }
        public List<GeFormActionLog> GetGeFormActionLog(int GeneralExpenseMemoFormId)
        {

            var data = _database.GeFormActionLogs.Where(x => x.GeneralExpenseMemoFormId == GeneralExpenseMemoFormId).ToList();
            return data;
        }
        public List<BudgetTypeCommonDto> GetBudgetTypes(int fiscalYear)
        {
            var list1 = new List<BudgetTypeCommonDto>();
            var Departments = _database.BudgetTypes.Where(x => x.FiscalYear == fiscalYear && x.Active).ToList();
            var data = Departments.Where(x => x.ParentBudgetTypeId == null).ToList();
            foreach (var item in data)
            {
                var list2 = new List<BudgetTypeCommonDto>();
                foreach (var s in Departments)
                {
                    if (s.ParentBudgetTypeId == item.Id)
                    {
                        var list3 = new List<BudgetTypeCommonDto>();
                        foreach (var s1 in Departments)
                        {
                            if (s1.ParentBudgetTypeId == s.Id)
                            {
                                var list4 = new List<BudgetTypeCommonDto>();
                                foreach (var s2 in Departments)
                                {
                                    if (s2.ParentBudgetTypeId == s1.Id)
                                    {
                                        list4.Add(new BudgetTypeCommonDto
                                        {
                                            Id = s2.Id,
                                            Name = s2.Name,
                                            Active = s2.Active,
                                            FiscalYear = s2.FiscalYear,
                                            ParentBudgetTypeId = s2.ParentBudgetTypeId,
                                            ReferenceOldId = s2.ReferenceOldId,
                                            ExpenseTypeEnum = s2.ExpenseTypeEnum,
                                            GovExpenseTypeEnum = s2.GovExpenseTypeEnum,
                                        });
                                    }

                                }
                                list3.Add(new BudgetTypeCommonDto
                                {
                                    Id = s1.Id,
                                    Name = s1.Name,
                                    Active = s1.Active,
                                    FiscalYear = s1.FiscalYear,
                                    ParentBudgetTypeId = s1.ParentBudgetTypeId,
                                    ReferenceOldId = s1.ReferenceOldId,
                                    ExpenseTypeEnum = s1.ExpenseTypeEnum,
                                    GovExpenseTypeEnum = s1.GovExpenseTypeEnum,
                                    ParentBudgetType = list4
                                });
                            }

                        }
                        list2.Add(new BudgetTypeCommonDto
                        {
                            Id = s.Id,
                            Name = s.Name,
                            Active = s.Active,
                            FiscalYear = s.FiscalYear,
                            ParentBudgetTypeId = s.ParentBudgetTypeId,
                            ReferenceOldId = s.ReferenceOldId,
                            ExpenseTypeEnum = s.ExpenseTypeEnum,
                            GovExpenseTypeEnum = s.GovExpenseTypeEnum,
                            ParentBudgetType = list3
                        });
                    }
                }
                list1.Add(new BudgetTypeCommonDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    Active = item.Active,
                    FiscalYear = item.FiscalYear,
                    ParentBudgetTypeId = item.ParentBudgetTypeId,
                    ReferenceOldId = item.ReferenceOldId,
                    ExpenseTypeEnum = item.ExpenseTypeEnum,
                    GovExpenseTypeEnum = item.GovExpenseTypeEnum,
                    ParentBudgetType = list2
                });

                

            }

            return list1;
        }



        public List<MisGeneralExpenseMemoFormsSignList> GetMisGeneralExpenseMemoFormsSignList(int GeneralExpenseMemoFormsId)
        {
            var data = _database.MisGeneralExpenseMemoFormsSignLists.Where(x => x.GeneralExpenseMemoFormsId == GeneralExpenseMemoFormsId).ToList();
            return data;
        }

        public List<PlanTypeCommonDto> GetPlanType(int fiscalYear)
        {
            var list1 = new List<PlanTypeCommonDto>();
            var PlanTypes = _database.PlanTypes.Where(x => x.FiscalYear == fiscalYear && x.Active).ToList();
            var data = PlanTypes.Where(x => x.ParentPlanTypeId == null).ToList();
            foreach (var item in data)
            {
                var _SubGetPlanType = SubGetPlanType(PlanTypes, item.Id, item.Id);
                list1.Add(new PlanTypeCommonDto
                {
                     Id = item.Id,
                    Name = item.Name,
                    FiscalYear = item.FiscalYear,
                    Active = item.Active,
                    ParentPlanTypeId = item.ParentPlanTypeId,
                    ReferenceOldId = item.ReferenceOldId,
                    ParentPlanType = _SubGetPlanType,
                    ParentPlanType_txt = JsonSerializer.Serialize(_SubGetPlanType),
                    Weight = item.Weight,
                    
                }
                    );
                //var list2 = new List<PlanTypeCommonDto>();
                //foreach (var s in PlanTypes)
                //{
                //    if (s.ParentPlanTypeId == item.Id)
                //    {
                //        var list3 = new List<PlanTypeCommonDto>();
                //        foreach (var s1 in PlanTypes)
                //        {
                //            if (s1.ParentPlanTypeId == s.Id)
                //            {
                //                list3.Add(new PlanTypeCommonDto
                //                {
                //                    Id = s1.Id,
                //                    Name = s1.Name,
                //                    FiscalYear = s1.FiscalYear,
                //                    Active = s1.Active,
                //                    ParentPlanTypeId = s1.ParentPlanTypeId,
                //                    ReferenceOldId = s1.ReferenceOldId,
                //                    Weight = s1.Weight,
                //                    // PrinciplePlanTag { get; set; }
                //                });
                //            }

                //        }
                //        list2.Add(new PlanTypeCommonDto
                //        {
                //            Id = s.Id,
                //            Name = s.Name,
                //            FiscalYear = s.FiscalYear,
                //            Active = s.Active,
                //            ParentPlanTypeId = s.ParentPlanTypeId,
                //            ReferenceOldId = s.ReferenceOldId,
                //            Weight = s.Weight,
                //            ParentPlanType = list3
                //        });
                //    }
                //}
                //list1.Add(new PlanTypeCommonDto
                //{
                //    Id = item.Id,
                //    Name = item.Name,
                //    FiscalYear = item.FiscalYear,
                //    Active = item.Active,
                //    ParentPlanTypeId = item.ParentPlanTypeId,
                //    ReferenceOldId = item.ReferenceOldId,
                //    Weight = item.Weight,
                //    ParentPlanType = list2
                //});



            }
            //string jsonString = JsonSerializer.Serialize(list1);
            //string[] words = jsonString.Split(',');
            //string txt_response = "";
            //string s1 = "[]";
            //bool pp = false;
            //foreach (var loop in words) //"ParentPlanType":[]}
            //{
            //    bool b = loop.Contains(s1);
            //    if (b ==  true)
            //    {
            //        //txt_response += "}},";
            //        pp = true;
            //    }
            //    else
            //    {
            //        string[] words_check = loop.Split(':');
            //        if(words_check[0] != "Weight")
            //        {
            //            txt_response += String.Format("{0}", loop);
            //        }
            //        else
            //        {
            //            if (pp == true)
            //            {
            //                txt_response += String.Format("{0}", loop) + "}]},";
            //            }
            //            else
            //            {
            //                txt_response += String.Format("{0}", loop) + "}]},";
            //            }
            //            pp = false;
            //        }
                    
            //    }
            //}
            //var f = txt_response ;
            return list1;
        }

        public List<PlanTypeCommonDto> SubGetPlanType(List<PlanType> PlanType, int? ParentStrategyId, int? mainStrategyId)
        {
            var list2 = new List<PlanTypeCommonDto>();
            foreach (var s in PlanType)
            {
                if (s.Id == ParentStrategyId)
                {
                    continue;
                }
                if (s.ParentPlanTypeId == ParentStrategyId)
                {
                   
                            list2.Add(new PlanTypeCommonDto
                            {
                                Id = s.Id,
                                Name = s.Name,
                                FiscalYear = s.FiscalYear,
                                Active = s.Active,
                                ParentPlanTypeId = s.ParentPlanTypeId,
                                ReferenceOldId = s.ReferenceOldId,
                                Weight = s.Weight,
                                ParentPlanType = SubGetPlanType(PlanType, s.Id, s.Id),
                            });
                }
            }
            return list2;


        }

        public List<RegisterProcureItemTypeDto> GetRegisterProcureItemType()
        {
            var response = new List<RegisterProcureItemTypeDto>();
            var data = _database.RegisterProcureItemTypes.ToList();
            foreach (var item in data)
            {
                response.Add(new RegisterProcureItemTypeDto
                {
            Id = item.Id,
            Name = item.Name,
                    Active = item.Active,
                    EnduranceTypeEnum = item.EnduranceTypeEnum,
                    ParentRegisterProcureItemTypeId = item.ParentRegisterProcureItemTypeId,
                    TypeCode = item.TypeCode,
                    UsefulLife = item.UsefulLife,
                });
            }
            return response;
        }

        public List<CapticalType> GetCapticalType(int fiscalYear)
        {
            var response = _database.CapticalTypes.Where(x => x.Active == true && x.FiscalYear == fiscalYear).ToList();
            return response;
        }

        public List<FundSource> GetFundSource(int fiscalYear)
        {
            var response = _database.FundSources.Where(x => x.Active == true && x.FiscalYear == fiscalYear).ToList();
            return response;
        }
    }
}
