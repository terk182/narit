using App.Common.Dtos;
using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public List<PlanTypeCommonDto> GetPlanType(int fiscalYear)
        {
            var list1 = new List<PlanTypeCommonDto>();
            var PlanTypes = _database.PlanTypes.Where(x => x.FiscalYear == fiscalYear && x.Active).ToList();
            var data = PlanTypes.Where(x => x.ParentPlanTypeId == null).ToList();
            foreach (var item in data)
            {
                var list2 = new List<PlanTypeCommonDto>();
                foreach (var s in PlanTypes)
                {
                    if (s.ParentPlanTypeId == item.Id)
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

                        });
                    }
                }
                list1.Add(new PlanTypeCommonDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    FiscalYear = item.FiscalYear,
                    Active = item.Active,
                    ParentPlanTypeId = item.ParentPlanTypeId,
                    ReferenceOldId = item.ReferenceOldId,
                    Weight = item.Weight,
                    ParentPlanType = list2
                });



            }

            return list1;
        }
    }
}
